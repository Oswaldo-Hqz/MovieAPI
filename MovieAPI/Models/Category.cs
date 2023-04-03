namespace MovieAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public HashSet<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
}
