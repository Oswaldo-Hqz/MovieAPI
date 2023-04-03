using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieAPI.Models.Configurations
{
    public class MovieRatingConfig : IEntityTypeConfiguration<MovieRating>
    {
        public void Configure(EntityTypeBuilder<MovieRating> builder)
        {
            builder.HasKey(mr => new {mr.MovieId, mr.UserId});
        }
    }
}
