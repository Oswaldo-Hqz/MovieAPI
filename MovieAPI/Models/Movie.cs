namespace MovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; } = null!;
        public int ReleaseYear { get; set; }
        public string? Synopsis { get; set; }
        public string? Poster { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public HashSet<Category> Categories { get; set; } = new HashSet<Category>();
        public List<MovieRating> MoviesRatings { get; set; } = new List<MovieRating>();

    }
}
