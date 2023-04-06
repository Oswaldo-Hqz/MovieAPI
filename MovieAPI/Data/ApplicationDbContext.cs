using Microsoft.EntityFrameworkCore;
using MovieAPI.Data.Seeds;
using MovieAPI.Models;
using System.Reflection;

namespace MovieAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            RoleSeeds.Seeds(modelBuilder);
            UserSeeds.Seeds(modelBuilder);
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<MovieRating> MoviesRating => Set<MovieRating>();
    }
}
