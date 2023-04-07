using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieAPI.Data.Seeds
{
    public class MovieCategorySeeds
    {
        public static void Seeds(ModelBuilder modelBuilder)
        {
            #region Category seeds

            var category1 = new Category()
            {
                Id = 1,
                Name = "Action",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category2 = new Category()
            {
                Id = 2,
                Name = "Animation",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category3 = new Category()
            {
                Id = 3,
                Name = "Crimen",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category4 = new Category()
            {
                Id = 4,
                Name = "Comedy",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category5 = new Category()
            {
                Id = 5,
                Name = "Documentary",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category6 = new Category()
            {
                Id = 6,
                Name = "Drama",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category7 = new Category()
            {
                Id = 7,
                Name = "Fantasy",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category8 = new Category()
            {
                Id = 8,
                Name = "Horror",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category9 = new Category()
            {
                Id = 9,
                Name = "Musical",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category10 = new Category()
            {
                Id = 10,
                Name = "Romance",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category11 = new Category()
            {
                Id = 11,
                Name = "Scary",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category12 = new Category()
            {
                Id = 12,
                Name = "Science fiction",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category13 = new Category()
            {
                Id = 13,
                Name = "Thriller",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category14 = new Category()
            {
                Id = 14,
                Name = "War",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var category15 = new Category()
            {
                Id = 15,
                Name = "Western",
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            modelBuilder.Entity<Category>().HasData(
                category1, 
                category2, 
                category3, 
                category4, 
                category5, 
                category6, 
                category7, 
                category8, 
                category9, 
                category10, 
                category11, 
                category12, 
                category13, 
                category14, 
                category15
            );

            #endregion

            #region Movie seeds

            var movie1 = new Movie()
            {
                Id = 1,
                MovieName = "Everything Everywhere All at Once",
                ReleaseYear = 2022,
                Synopsis = "An aging Chinese immigrant is swept up in an insane adventure, where she alone can save what's important to her by connecting with the lives she could have led in other universes.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie2 = new Movie()
            {
                Id = 2,
                MovieName = "John Wick",
                ReleaseYear = 2014,
                Synopsis = "Ex-hitman John Wick comes out of retirement to track down the gangsters that took everything from him.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie3 = new Movie()
            {
                Id = 3,
                MovieName = "All Quiet on the Western Front",
                ReleaseYear = 2022,
                Synopsis = "Full of excitement and patriotic fervour, the boys enthusiastically march into a war they believe in. But once on the Western Front, they discover the soul-destroying horror of World War I.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie4 = new Movie()
            {
                Id = 4,
                MovieName = "Harry Potter and the Philosopher's Stone",
                ReleaseYear = 2001,
                Synopsis = "Harry Potter has lived under the stairs at his aunt and uncle's house his whole life. But on his 11th birthday, he learns he's a powerful wizard—with a place waiting for him at the Hogwarts School of Witchcraft and Wizardry.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie5 = new Movie()
            {
                Id = 5,
                MovieName = "Citizen Kane",
                ReleaseYear = 1941,
                Synopsis = "Newspaper magnate, Charles Foster Kane is taken from his mother as a boy and made the ward of a rich industrialist. As a result, every well-meaning, tyrannical or self-destructive move he makes for the rest of his life appears in some way to be a reaction to that deeply wounding event.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie6 = new Movie()
            {
                Id = 6,
                MovieName = "Spider-Man: Into the Spider-Verse",
                ReleaseYear = 2018,
                Synopsis = "Miles Morales is juggling his life between being a high school student and being Spider-Man. However, when Wilson \"Kingpin\" Fisk uses a super collider, another Spider-Man from another dimension, Peter Parker, accidentally winds up in Miles' dimension.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie7 = new Movie()
            {
                Id = 7,
                MovieName = "La La Land",
                ReleaseYear = 2016,
                Synopsis = "Mia, an aspiring actress, serves lattes to movie stars in between auditions and Sebastian, a jazz musician, scrapes by playing cocktail party gigs in dingy bars, but as success mounts they are faced with decisions that begin to fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie8 = new Movie()
            {
                Id = 8,
                MovieName = "Guillermo del Toro's Pinocchio",
                ReleaseYear = 2022,
                Synopsis = "During the rise of fascism in Mussolini's Italy, a wooden boy brought magically to life struggles to live up to his father's expectations.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie9 = new Movie()
            {
                Id = 9,
                MovieName = "The Secret Life of Walter Mitty",
                ReleaseYear = 2013,
                Synopsis = "A timid magazine photo manager who lives life vicariously through daydreams embarks on a true-life adventure when a negative goes missing.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            var movie10 = new Movie()
            {
                Id = 10,
                MovieName = "Kill Bill: Vol. 1",
                ReleaseYear = 2003,
                Synopsis = "An assassin is shot by her ruthless employer, Bill, and other members of their assassination circle – but she lives to plot her vengeance.",
                Poster = null,
                CreatedUserId = 1,
                CreatedDate = DateTime.UtcNow
            };

            modelBuilder.Entity<Movie>().HasData(
                movie1,
                movie2,
                movie3,
                movie4,
                movie5,
                movie6,
                movie7,
                movie8,
                movie9,
                movie10
            );

            #endregion

            #region MovieCategory seeds

            var tableCategoryMovie = "CategoryMovie";
            var columnCategoriesId = "CategoriesId";
            var columnMoviesId = "MoviesId";

            modelBuilder.Entity(tableCategoryMovie).HasData(

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category1.Id,
                    [columnMoviesId] = movie1.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category4.Id,
                    [columnMoviesId] = movie1.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category7.Id,
                    [columnMoviesId] = movie1.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category1.Id,
                    [columnMoviesId] = movie2.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category13.Id,
                    [columnMoviesId] = movie2.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category6.Id,
                    [columnMoviesId] = movie3.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category14.Id,
                    [columnMoviesId] = movie3.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category1.Id,
                    [columnMoviesId] = movie3.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category7.Id,
                    [columnMoviesId] = movie4.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category1.Id,
                    [columnMoviesId] = movie4.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category6.Id,
                    [columnMoviesId] = movie5.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category1.Id,
                    [columnMoviesId] = movie6.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category2.Id,
                    [columnMoviesId] = movie6.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category4.Id,
                    [columnMoviesId] = movie6.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category7.Id,
                    [columnMoviesId] = movie6.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category4.Id,
                    [columnMoviesId] = movie7.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category6.Id,
                    [columnMoviesId] = movie7.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category9.Id,
                    [columnMoviesId] = movie7.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category10.Id,
                    [columnMoviesId] = movie7.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category2.Id,
                    [columnMoviesId] = movie8.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category6.Id,
                    [columnMoviesId] = movie8.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category7.Id,
                    [columnMoviesId] = movie8.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category1.Id,
                    [columnMoviesId] = movie9.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category4.Id,
                    [columnMoviesId] = movie9.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category6.Id,
                    [columnMoviesId] = movie9.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category7.Id,
                    [columnMoviesId] = movie9.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category10.Id,
                    [columnMoviesId] = movie9.Id
                },

                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category1.Id,
                    [columnMoviesId] = movie10.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category6.Id,
                    [columnMoviesId] = movie10.Id
                },
                new Dictionary<string, object>
                {
                    [columnCategoriesId] = category3.Id,
                    [columnMoviesId] = movie10.Id
                }
            );


            #endregion
        }
    }
}
