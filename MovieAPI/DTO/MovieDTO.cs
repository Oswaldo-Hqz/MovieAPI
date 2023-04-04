namespace MovieAPI.DTO
{
    public class MovieDTO
    {
        public string MovieName { get; set; } = null!;
        public int ReleaseYear { get; set; }
        public string? Synopsis { get; set; }
        public IFormFile? Poster { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
    }
}
