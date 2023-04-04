using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Data;
using MovieAPI.DTO;
using MovieAPI.Models;
using System.Security.Claims;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public MoviesController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromForm] MovieDTO req, [FromForm] List<int> categoryIds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var movie = new Movie
            {
                MovieName = req.MovieName,
                ReleaseYear = req.ReleaseYear,
                Synopsis = req.Synopsis,
                CreatedUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value),
                CreatedDate = DateTime.UtcNow
            };

            if (req.Poster != null)
            {
                using var stream = new MemoryStream();
                await req.Poster.CopyToAsync(stream);
                await SaveImageAsync(movie.Id, stream.ToArray());

                //movie.Poster = ;
            }

            foreach (var categoryId in categoryIds)
            {
                var category = await _context.Categories.FindAsync(categoryId);
                if (category == null)
                {
                    return BadRequest($"Category with id {categoryId} not found");
                }
                movie.Categories.Add(category);
            }

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }


        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }




        private async Task SaveImageAsync(int movieId, byte[] imageBytes)
        {
            var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var filePath = Path.Combine(uploadsFolder, $"{movieId}.jpg");
            await System.IO.File.WriteAllBytesAsync(filePath, imageBytes);
        }
    }
}
