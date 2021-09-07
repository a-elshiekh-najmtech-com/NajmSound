using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NajmSound.Data;
using NajmSound.Helpers;
using NajmSound.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace NajmSound.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AlbumsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //// GET: api/Albums
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Album>>> GetAlbums()
        //{
        //    return await _context.Albums.ToListAsync();
        //}

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlbumViewModel>> GetAlbum(int id)
        {
            var album = _mapper.Map<AlbumViewModel>(
                await _context.Albums.Include(x => x.Artist)
                .FirstOrDefaultAsync(x => x.Id == id)
                );
                

            if (album == null)
            {
                return NotFound();
            }

            //var artist = await _context.Artists.Where(x => x.Id == album.ArtistId).Select(x => x.Name).FirstOrDefaultAsync();

            foreach (var item in album.Songs)
            {
                item.Artist = album.Artist;
                item.LikesCount = await _context.LikedSongs.Where(x => x.SongId == item.Id).CountAsync();
                item.Liked = await _context.LikedSongs.Where(x => x.SongId == item.Id && x.UserId == UserHelper.UserId).AnyAsync();
            }

            return album;
        }

        //// PUT: api/Albums/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAlbum(int id, Album album)
        //{
        //    if (id != album.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(album).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AlbumExists(id))
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

        //// POST: api/Albums
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Album>> PostAlbum(Album album)
        //{
        //    _context.Albums.Add(album);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAlbum", new { id = album.Id }, album);
        //}

        //// DELETE: api/Albums/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAlbum(int id)
        //{
        //    var album = await _context.Albums.FindAsync(id);
        //    if (album == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Albums.Remove(album);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AlbumExists(int id)
        //{
        //    return _context.Albums.Any(e => e.Id == id);
        //}
    }
}
