using AgileCourseAssignment.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileCourseAssignment.Server.Data
{
    public class FlagScapeDb:DbContext
    {


        public FlagScapeDb(DbContextOptions<FlagScapeDb> options) : base(options)
        { 

        }

        public DbSet<FlagsModel> Flags { get; set; }
        public DbSet<HighScoreModel> HighScore { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlagsModel>().HasData(
                new FlagsModel()
                {
                    Id = 1,
                    CountryName = "Germany",
                    Image = "Germany.jpg",
                    IsUsed = false,


                }
                );
        }

    }
}
