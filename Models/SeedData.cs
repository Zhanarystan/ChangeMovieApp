using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Data;
using System;
using System.Linq;

namespace MovieApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new MovieAppContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MovieAppContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Director = "Todd Phillips",
                        Genre = "Crime , Drama , Thriller",
                        Title = "Joker",
                        Poster = "https://5.imimg.com/data5/MS/GJ/MY-48788675/joker-paper-printed-poster-500x500.jpeg",
                        ReleaseDate = new DateTime(2019, 10, 3)
                    },
                    new Movie
                    {
                        Director = "David Leitch",
                        Genre = "Action , Adventure",
                        Title = "Fast & Furious Presents: Hobbs & Shaw",
                        Poster = "https://www.themoviedb.org/t/p/original/qRyy2UmjC5ur9bDi3kpNNRCc5nc.jpg",
                        ReleaseDate = new DateTime(2019, 8, 2)
                    },
                    new Movie
                    {
                        Director = "Jon Favreau",
                        Genre = "Adventure , Animation , Drama , Family , Musical",
                        Title = "The Lion King",
                        Poster = "https://i.pinimg.com/originals/3f/91/74/3f9174c6b303e839c6526c3a175d7af9.jpg",
                        ReleaseDate = new DateTime(2019, 7, 19)
                    },
                    new Movie
                    {
                        Director = "Joachim Rønning",
                        Genre = "Adventure , Family , Fantasy",
                        Title = "Maleficent: Mistress of Evil",
                        Poster = "https://upload.wikimedia.org/wikipedia/en/7/7b/Maleficent_Mistress_of_Evil_%28Official_Film_Poster%29.png",
                        ReleaseDate = new DateTime(2019, 10, 18)
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
