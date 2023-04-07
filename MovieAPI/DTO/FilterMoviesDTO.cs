namespace MovieAPI.DTO
{
    public class FilterMoviesDTO
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int ReleaseYear { get; set; }
        public string Synopsis { get; set; }
        public string PosterUrl { get; set; }
        public List<string> Categories { get; set; } = new List<string>();
        public double? AverageRating { get; set; }
    }
}
