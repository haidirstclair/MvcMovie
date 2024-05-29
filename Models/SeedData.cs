using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Oppenheimer",
                    ReleaseDate = DateTime.Parse("2023-7-21"),
                    Genre = "Drama",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Barbie",
                    ReleaseDate = DateTime.Parse("2023-7-21"),
                    Genre = "Comedy",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Dune: Part Two",
                    ReleaseDate = DateTime.Parse("2023-11-3"),
                    Genre = "Science Fiction",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "The Marvels",
                    ReleaseDate = DateTime.Parse("2023-11-10"),
                    Genre = "Action",
                    Price = 13.99M
                },
                new Movie
                {
                    Title = "Avatar: The Way of Water",
                    ReleaseDate = DateTime.Parse("2022-12-16"),
                    Genre = "Adventure",
                    Price = 15.99M
                }
            );
            context.SaveChanges();
        }
    }
}