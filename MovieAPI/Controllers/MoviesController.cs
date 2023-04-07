using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Data;
using MovieAPI.DTO;
using MovieAPI.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;

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
        [HttpGet, Authorize(Roles = "admin,user")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        // GET: api/Movies/5
        [HttpGet("{id}"), Authorize(Roles = "admin,user")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpPost("CreateMovie"), Authorize(Roles = "admin")]
        public async Task<ActionResult> CreateMovie(MovieDTO req)
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

            if (req.CategoriesIds is not null)
            {
                foreach (var categoryId in req.CategoriesIds)
                {
                    var category = await _context.Categories.FindAsync(categoryId);
                    if (category == null)
                    {
                        return BadRequest($"Category with id {categoryId} not found");
                    }
                    movie.Categories.Add(category);
                }
            }

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        [HttpPost("AddMoviePoster"), Authorize(Roles = "admin")]
        public async Task<ActionResult> AddMoviePoster([FromForm] MoviePosterDTO req)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var movie = await _context.Movies.FindAsync(req.Id);
            if (movie == null)
            {
                return NotFound();
            }

            if (req.Poster != null)
            {
                using var stream = new MemoryStream();
                await req.Poster.CopyToAsync(stream);
                var posterURL = await SaveImageAsync(movie.Id, stream.ToArray());
            }

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        [HttpPut("UpdateMovie/{id}"), Authorize(Roles = "admin")]
        public async Task<ActionResult> UpdateMovie(int id, MovieDTO req)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            movie.MovieName = req.MovieName == movie.MovieName ? movie.MovieName : req.MovieName;
            movie.ReleaseYear = req.ReleaseYear == movie.ReleaseYear ? movie.ReleaseYear : req.ReleaseYear;
            movie.Synopsis = req.Synopsis == movie.Synopsis ? movie.Synopsis : req.Synopsis;

            if (req.CategoriesIds is not null)
            {
                foreach (var categoryId in req.CategoriesIds)
                {
                    var category = await _context.Categories.FindAsync(categoryId);
                    if (category == null)
                    {
                        return BadRequest($"Category with id {categoryId} not found");
                    }
                    movie.Categories.Add(category);
                }
            }

            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}"), Authorize(Roles = "admin")]
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

        //--------------

        private async Task<string> SaveImageAsync(int movieId, byte[] imageBytes)
        {
            string folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "MoviesPosters");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var filePath = Path.Combine(folderPath, $"{movieId}.jpg");
            await System.IO.File.WriteAllBytesAsync(filePath, imageBytes);

            return filePath;
        }
    }
}
