using System.ComponentModel.DataAnnotations;

namespace MovieAPI.DTO
{
    public class RegisterDTO
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
