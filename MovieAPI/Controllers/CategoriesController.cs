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
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;

        public CategoriesController(ApplicationDbContext dbContext)
        {
            _Context = dbContext;
        }

        // GET: api/categories
        [HttpGet, Authorize(Roles = "admin,user")]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategories()
        {
            var categories = await _Context.Categories.ToListAsync();
            var categoryDtos = categories.Select(c => new CategoryDTO
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();

            return Ok(categoryDtos);
        }

        // GET: api/categories/{id}
        [HttpGet("{id}"), Authorize(Roles = "admin")]
        public async Task<ActionResult<CategoryDTO>> GetCategory(int id)
        {
            var category = await _Context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var user = await _Context.Users.FindAsync(category.CreatedUserId);
            if (user == null)
            {
                return NotFound();
            }

            var categoryDto = new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                CreatedUserBy = user.FirstName + " " + user.LastName,
                CreatedDate = category.CreatedDate
            };

            return Ok(categoryDto);
        }

        // POST: api/categories
        [HttpPost, Authorize(Roles = "admin")]
        public async Task<ActionResult<CategoryDTO>> CreateCategory(CategoryDTO categoryDto)
        {
            if (await _Context.Categories.AnyAsync(c => c.Name == categoryDto.Name))
            {
                return BadRequest("Category name already exists");
            }

            var createdCategory = new Category
            {
                Name = categoryDto.Name,
                CreatedUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value),
                CreatedDate = DateTime.UtcNow
            };

            _Context.Categories.Add(createdCategory);
            await _Context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategory), new { id = createdCategory.Id });
        }

        // PUT: api/categories/{id}
        [HttpPut("{id}"), Authorize(Roles = "admin")]
        public async Task<ActionResult> UpdateCategory(int id, CategoryDTO categoryDto)
        {
            var category = await _Context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            if (await _Context.Categories.AnyAsync(c => c.Id != id && c.Name == categoryDto.Name))
            {
                return BadRequest("Category name already exists");
            }

            category.Name = categoryDto.Name;
            _Context.Categories.Update(category);
            await _Context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/categories/{id}
        [HttpDelete("{id}"), Authorize(Roles = "admin")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            var category = await _Context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            if (await _Context.Movies.AnyAsync(m => m.Categories.Any(c => c.Id == id)))
            {
                return BadRequest("Category is assigned to one or more movies and cannot be deleted");
            }

            _Context.Categories.Remove(category);
            await _Context.SaveChangesAsync();

            return Ok();
        }
    }
}
