namespace MovieAPI.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public HashSet<User> Users { get; set; } = new HashSet<User>();
    }
}
