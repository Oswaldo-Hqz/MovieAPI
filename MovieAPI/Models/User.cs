using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public DateTime CreatedDate { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

        public List<MovieRating> MoviesRatings { get; set; } = new List<MovieRating>();
    }
}
