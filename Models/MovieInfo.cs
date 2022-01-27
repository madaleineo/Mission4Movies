using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FilmCollectionMission4.Models
{
    public class MovieInfo : DbContext
    {
        public MovieInfo (DbContextOptions<MovieInfo> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Captain America: The First Avenger",
                    Year = 2011,
                    DirectorFirst = "Joe",
                    DirectorLast = "Johnston",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    Category = "Action/Adventure",
                    Title = "Captain America: Civil War",
                    Year = 2016,
                    DirectorFirst = "Joe",
                    DirectorLast = "Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    Category = "Action/Adventure",
                    Title = "Captain America: Winter Soldier",
                    Year = 2014,
                    DirectorFirst = "Joe",
                    DirectorLast = "Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                }
            );
        }
    }
}
