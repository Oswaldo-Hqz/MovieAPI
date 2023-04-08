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
            var movies = await _context.Movies
                .Select(m => new
                {
                    m.Id,
                    m.MovieName,
                    m.ReleaseYear,
                    m.Synopsis,
                    m.Poster,
                    Categories = m.Categories.Select(c => new { c.Id, c.Name }).ToList(),
                    Ratings = (double?)m.MoviesRatings.Average(mr => mr.Rating)
                }).ToListAsync();

            return Ok(movies);
        }

        // GET: api/Movies/{id}
        [HttpGet("{id}"), Authorize(Roles = "admin,user")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var movie = await _context.Movies
                .Select(m => new
                {
                    m.Id,
                    m.MovieName,
                    m.ReleaseYear,
                    m.Synopsis,
                    m.Poster,
                    Categories = m.Categories.Select(c => new { c.Id, c.Name }).ToList(),
                    Ratings = m.MoviesRatings.Where(mr => mr.UserId == userId).Select(mr => mr.Rating).FirstOrDefault()
                }).FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        // GET: api/Movies/FilterMovies
        [HttpGet("FilterMovies"), Authorize(Roles = "admin,user")]
        public async Task<ActionResult<IEnumerable<FilterMoviesDTO>>> FilterMovies(
            [FromQuery] string textSearch = "",
            [FromQuery] int? categoryId = null,
            [FromQuery] int? releaseYear = null,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "CreatedDate",
            [FromQuery] bool ascending = false)
        {
            // Apply text search in name or synipsis
            IQueryable<Movie> query = _context.Movies;
            if (!string.IsNullOrWhiteSpace(textSearch))
            {
                query = query.Where(m => m.MovieName.Contains(textSearch) || m.Synopsis.Contains(textSearch));
            }

            // Apply category filter
            if (categoryId.HasValue)
            {
                query = query.Where(m => m.Categories.Any(c => c.Id == categoryId));
            }

            // Apply release year filter
            if (releaseYear.HasValue)
            {
                query = query.Where(m => m.ReleaseYear == releaseYear);
            }

            // Apply ordering
            if (sortBy == "Year")
                query = ascending ? query.OrderBy(m => m.ReleaseYear) : query.OrderByDescending(m => m.ReleaseYear);
            else if (sortBy == "Name")
                query = ascending ? query.OrderBy(m => m.MovieName) : query.OrderByDescending(m => m.MovieName);
            else if (sortBy == "Rating")
                query = ascending ? query.OrderBy(m => m.MoviesRatings.Average(r => r.Rating)) : query.OrderByDescending(m => m.MoviesRatings.Average(r => r.Rating));
            else
                query = ascending ? query.OrderBy(m => m.CreatedDate) : query.OrderByDescending(m => m.CreatedDate);

            // Apply pagination
            var totalMovies = await query.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalMovies / pageSize);
            var movies = await query
                .Include(m => m.Categories)
                .Include(m => m.MoviesRatings)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(m => m)
                .ToListAsync();

            var result = new
            {
                TotalMovies = totalMovies,
                TotalPages = totalPages,
                Movies = movies
            };
            return Ok(result);
        }

        // POST: api/Movies/createMovie
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

        // POST: api/Movies/AddMoviePoster
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

                movie.Poster = posterURL;
            }

            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();

            return Ok(movie);
        }

        // POST: api/Movies/UpdateMovie/{id}
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

        // DELETE: api/Movies/{id}
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
            string rootPath = _hostingEnvironment.WebRootPath == null ? _hostingEnvironment.ContentRootPath : _hostingEnvironment.WebRootPath;
            string folderPath = Path.Combine(rootPath, "MoviesPosters");

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
