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
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SongsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //// GET: api/Songs
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Song>>> GetSongs()
        //{
        //    return await _context.Songs.ToListAsync();
        //}

        // GET: api/Songs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SongViewModel>> GetSong(int id)
        {
            var song = _mapper.Map<SongViewModel>(
                await _context.Songs
                .FirstOrDefaultAsync(x => x.Id == id));

            if (song == null)
            {
                return NotFound();
            }

            song.Artist = await _context.Artists.Where(x => x.Id == song.ArtistId).Select(x => x.Name).FirstOrDefaultAsync();
            song.Liked = await _context.LikedSongs.Where(x => x.SongId == song.Id && x.UserId == UserHelper.UserId).AnyAsync();

            return song;
        }

        [HttpPost("Like/{id}")]
        public async Task<ActionResult> LikeSong(int id)
        {
            if (await _context.Songs.AnyAsync(x => x.Id == id))
                return NotFound("Song Not Found!");
            if (await _context.LikedSongs.AnyAsync(x => x.SongId == id && x.UserId == UserHelper.UserId))
                return BadRequest("Song Already on the Like List");

            await _context.LikedSongs.AddAsync(new LikedSong
            {
                UserId = UserHelper.UserId,
                SongId = id
            });
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("UnLike/{id}")]
        public async Task<ActionResult> UnLikeSong(int id)
        {
            if (await _context.Songs.AnyAsync(x => x.Id == id))
                return NotFound("Song Not Found!");
            var like = await _context.LikedSongs.FirstOrDefaultAsync(x => x.SongId == id && x.UserId == UserHelper.UserId);
            if (like == null)
                return BadRequest("Song Not on the Like List");

            _context.LikedSongs.Remove(like);

            await _context.SaveChangesAsync();
            return Ok();
        }


        //// PUT: api/Songs/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSong(int id, Song song)
        //{
        //    if (id != song.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(song).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SongExists(id))
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

        //// POST: api/Songs
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Song>> PostSong(Song song)
        //{
        //    _context.Songs.Add(song);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSong", new { id = song.Id }, song);
        //}

        //// DELETE: api/Songs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSong(int id)
        //{
        //    var song = await _context.Songs.FindAsync(id);
        //    if (song == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Songs.Remove(song);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool SongExists(int id)
        //{
        //    return _context.Songs.Any(e => e.Id == id);
        //}
    }
}
