using Microsoft.AspNetCore.Authorization;
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
    public class RatingController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;

        public RatingController(ApplicationDbContext dbContext)
        {
            _Context = dbContext;
        }

        // GET: api/Rating/myRatings
        [HttpGet("myRatings"), Authorize(Roles = "admin,user")]
        public async Task<ActionResult<IEnumerable<MovieRatingDTO>>> GetMyRatings()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var movies = await _Context.Movies
                .Include(m => m.Categories)
                .Include(m => m.MoviesRatings.Where(mr => mr.UserId == userId))
                .Where(m => m.MoviesRatings.Any(mr => mr.UserId == userId))
                .ToListAsync();

            var moviesRatings = movies
                .Select(m => new
                {
                    m.Id,
                    m.MovieName,
                    m.ReleaseYear,
                    m.Synopsis,
                    m.Poster,
                    Categories = m.Categories.Select(c => new { c.Id, c.Name }).ToList(),
                    Ratings = m.MoviesRatings.Where(mr => mr.UserId == userId).Select(mr => mr.Rating).FirstOrDefault()
                }).ToList();

            return Ok(moviesRatings);
        }

        // POST: api/Rating/rateMovie
        [HttpPost("rateMovie"), Authorize(Roles = "admin,user")]
        public async Task<IActionResult> RateMovie([FromBody] MovieRatingDTO ratingDto)
        {
            int currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (await _Context.MoviesRating.AnyAsync(mr => mr.MovieId == ratingDto.MovieId && mr.UserId == currentUserId))
            {
                return BadRequest("You have already rated this movie.");
            }

            var rating = new MovieRating
            {
                MovieId = ratingDto.MovieId,
                UserId = currentUserId,
                Rating = ratingDto.Rating,
                CreatedDate = DateTime.UtcNow
            };
            _Context.MoviesRating.Add(rating);
            await _Context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Rating/deleteRating/5
        [HttpDelete("deleteRating/{movieId}"), Authorize(Roles = "admin,user")]
        public async Task<IActionResult> DeleteMovieRating(int movieId)
        {
            int currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            if (await _Context.MoviesRating.AnyAsync(mr => mr.MovieId == movieId && mr.UserId == currentUserId))
            {
                return NotFound();
            }

            var movieRating = await _Context.MoviesRating.FirstOrDefaultAsync(mr => mr.MovieId == movieId && mr.UserId == currentUserId);

            _Context.MoviesRating.Remove(movieRating);
            await _Context.SaveChangesAsync();

            return NoContent();
        }
    }
}
