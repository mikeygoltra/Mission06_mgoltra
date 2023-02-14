using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        }

        public DbSet<ApplicationResponse> Entries { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                { 
                    MovieId = 1,
                    Category = "Sci-Fi",
                    Title = "A New Hope",
                    Year = 1974,
                    Director = "George Lucas",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    Category = "Drama",
                    Title = "The Godfather",
                    Year = 1970,
                    Director = "Francis Ford Coppola",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    Category = "Romance",
                    Title = "Forrest Gump",
                    Year = 1995,
                    Director = "Robert Zemeckis",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }

            );
        }
    }
}
