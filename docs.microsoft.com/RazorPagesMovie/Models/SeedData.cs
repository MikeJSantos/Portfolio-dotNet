using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var dbContextOptions = serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>();
            using (var context = new RazorPagesMovieContext(dbContextOptions))
            {
                // Movie table already populated
                if (context.Movie.Any()) return;

                // TODO: Parse from CSV, web-scrape from IMDB/RottenTomatoes?

                context.Movie.AddRange(
                    new Movie("When Harry Met Sally", "1989-2-12", "Romantic Comedy", 7.99M),
                    new Movie("Ghostbusters", "1984-3-13", "Comedy", 8.99M),
                    new Movie("Ghostbusters 2", "1986-2-23", "Comedy", 9.99M),
                    new Movie("Rio Bravo", "1959-4-15", "Western", 3.99M)
                );

                context.SaveChanges();
            }
        }
    }
}