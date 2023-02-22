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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                
                new Category { CategoryId=1, CategoryName="Sci-Fi"},
                new Category { CategoryId=2, CategoryName="Drama"},
                new Category { CategoryId=3, CategoryName="Romance"}

            );

            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                { 
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "A New Hope",
                    Year = 1978,
                    Director = "George Lucas",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "The Godfather",
                    Year = 1972,
                    Director = "Francis Ford Coppola",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "Forrest Gump",
                    Year = 1994,
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
