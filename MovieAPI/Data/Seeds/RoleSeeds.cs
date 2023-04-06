using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
using MovieAPI.Utils;

namespace MovieAPI.Data.Seeds
{
    public class RoleSeeds
    {
        public static void Seeds(ModelBuilder modelBuilder)
        {
            var adminRole = new Role()
            {
                Id = 1,
                Name = "admin",
                CreatedDate = DateTime.UtcNow,
                CreatedUserId = 1,
            };

            var userRole = new Role()
            {
                Id = 2,
                Name = "user",
                CreatedDate = DateTime.UtcNow,
                CreatedUserId = 1,
            };

            modelBuilder.Entity<Role>().HasData(adminRole, userRole);
        }
    }
}
