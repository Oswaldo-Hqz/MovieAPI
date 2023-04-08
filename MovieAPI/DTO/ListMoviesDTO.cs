using MovieAPI.Models;

namespace MovieAPI.DTO
{
    public class ListMoviesDTO
    {
        public int Id { get; set; }
        public string MovieName { get; set; } = null!;
        public int ReleaseYear { get; set; }
        public string? Synopsis { get; set; }
        public string? Poster { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
