using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class MovieRating
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [Range(0, 5)]
        public int Rating { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
