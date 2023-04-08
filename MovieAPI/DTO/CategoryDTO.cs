using System.ComponentModel.DataAnnotations;

namespace MovieAPI.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string CreatedUserBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
