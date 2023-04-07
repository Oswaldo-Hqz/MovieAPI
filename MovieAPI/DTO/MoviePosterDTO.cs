using System.ComponentModel.DataAnnotations;

namespace MovieAPI.DTO
{
    public class MoviePosterDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public IFormFile? Poster { get; set; }
    }
}
