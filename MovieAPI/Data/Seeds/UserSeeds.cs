using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
using MovieAPI.Utils;

namespace MovieAPI.Data.Seeds
{
    public class UserSeeds
    {
        public static void Seeds(ModelBuilder modelBuilder)
        {
            var passwordUtils = new PasswordUtils();
            byte[] PasswordHash, PasswordSalt;

            passwordUtils.CreatePasswordHash("12345678", out PasswordHash, out PasswordSalt);

            var admin = new User()
            {
                Id = 1,
                FirstName = "El",
                LastName = "Admin",
                Email = "admin@ravn.com",
                PasswordHash = PasswordHash,
                PasswordSalt = PasswordSalt,
                CreatedDate = DateTime.UtcNow,
                RoleId = 1
            };

            passwordUtils.CreatePasswordHash("87654321", out PasswordHash, out PasswordSalt);

            var user = new User()
            {
                Id = 2,
                FirstName = "David",
                LastName = "Peres",
                Email = "userDavid@ravn.com",
                PasswordHash = PasswordHash,
                PasswordSalt = PasswordSalt,
                CreatedDate = DateTime.UtcNow,
                RoleId = 2
            };

            modelBuilder.Entity<User>().HasData(admin, user);
        }
    }
}
