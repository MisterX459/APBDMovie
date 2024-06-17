using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using APBD_11.Data;
using System;
using System.Linq;



namespace APBD_11.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<MvcMovieContext>>()))
        {
            
            if (context.Movie.Any())
            {
                return;   
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "Zelenyi Slonik",
                    ReleaseDate = DateTime.Parse("1999-2-12"),
                    Genre = "Horror",
                    Rating = "R",
                    Price = 148.8M
                },

                new Movie
                {
                    Title = "Shrek",
                    ReleaseDate = DateTime.Parse("2001-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 10.99M
                },

                new Movie
                {
                    Title = "Shrek 2",
                    ReleaseDate = DateTime.Parse("2004-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 22.8M
                },

                new Movie
                {
                    Title = "Shrek 3",
                    ReleaseDate = DateTime.Parse("2007-4-15"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 17.7M
                }
            );
            context.SaveChanges();
        }
    }
}