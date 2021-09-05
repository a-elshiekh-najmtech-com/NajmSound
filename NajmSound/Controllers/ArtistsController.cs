using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NajmSound.Data;
using NajmSound.Helpers;
using NajmSound.Models;
using NajmSound.ViewModel;

namespace NajmSound.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ArtistsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Artists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArtistListViewModel>>> GetArtists()
        {
            var result = await _context.Artists.Include(x => x.Songs).Include(x => x.Albums)
                .Select(x => _mapper.Map<ArtistListViewModel>(x))
                .ToListAsync();


            foreach (var item in result)
            {
                var artistLikes = _context.LikedArtists.Where(x => x.ArtistId == item.Id).AsQueryable();
                item.LikesCount = await artistLikes.CountAsync();
                item.liked = await artistLikes.Where(x => x.UserId == UserHelper.UserId).AnyAsync();
            }



            return result;
        }

        // GET: api/Artists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArtistViewModel>> GetArtist(int id)
        {
            var artist = await _context.Artists.Include(x => x.Songs).Include(x => x.Albums)
                .Where(x => x.Id == id)
                .Select(x => _mapper.Map<ArtistViewModel>(x))
                .FirstOrDefaultAsync();

            if (artist == null)
            {
                return NotFound();
            }

            foreach (var item in artist.Albums)
                item.Artist = artist.Name;
            foreach (var item in artist.Songs)
            { 
                item.Artist = artist.Name;
                item.LikesCount = await _context.LikedSongs.Where(x => x.SongId == item.Id).CountAsync();
                item.Liked = await _context.LikedSongs.Where(x => x.SongId == item.Id && x.UserId == UserHelper.UserId).AnyAsync();
            }


            return artist;
        }

        [HttpPost("Like/{id}")]
        public async Task<ActionResult> LikeArtist(int id)
        {
            if (await _context.Artists.AnyAsync(x => x.Id == id))
                return NotFound("Artist Not Found!");
            if (await _context.LikedArtists.AnyAsync(x => x.ArtistId == id && x.UserId == UserHelper.UserId))
                return BadRequest("Artist Already on the Like List");

            await _context.LikedArtists.AddAsync(new LikedArtist
            {
                UserId = UserHelper.UserId,
                ArtistId = id
            });
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("UnLike/{id}")]
        public async Task<ActionResult> UnLikeArtist(int id)
        {
            if (await _context.Artists.AnyAsync(x => x.Id == id))
                return NotFound("Artist Not Found!");
            var like = await _context.LikedArtists.FirstOrDefaultAsync(x => x.ArtistId == id && x.UserId == UserHelper.UserId);
            if (like == null)
                return BadRequest("Artist Not on the Like List");

            _context.LikedArtists.Remove(like);

            await _context.SaveChangesAsync();
            return Ok();
        }

        //// PUT: api/Artists/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutArtist(int id, Artist artist)
        //{
        //    if (id != artist.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(artist).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ArtistExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Artists
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Artist>> PostArtist(Artist artist)
        //{
        //    _context.Artists.Add(artist);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetArtist", new { id = artist.Id }, artist);
        //}

        //// DELETE: api/Artists/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteArtist(int id)
        //{
        //    var artist = await _context.Artists.FindAsync(id);
        //    if (artist == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Artists.Remove(artist);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ArtistExists(int id)
        //{
        //    return _context.Artists.Any(e => e.Id == id);
        //}
    }
}
