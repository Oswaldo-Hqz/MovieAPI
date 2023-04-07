using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieAPI.Models.Configurations
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(m => m.MovieName).HasMaxLength(250);
            builder.Property(m => m.Synopsis).HasMaxLength(1000);
        }
    }
}
