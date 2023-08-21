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


                },
                new FlagsModel()
                {
                    Id = 2,
                    CountryName = "Austria",
                    Image = "Austria.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id=3,
                    CountryName = "Spain",
                    Image = "Bandera_de_España.jpg",
                    IsUsed = false,
                    
                },
                new FlagsModel()
                {
                    Id = 4,
                    CountryName = "Belgium",
                    Image = "Flag_of_Belgium_(civil).jpg",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id=5,
                    CountryName = "Bulgaria",
                    Image = "Flag_of_Bulgaria.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 6,
                    CountryName = "Croatia",
                    Image = "Flag_of_Croatia.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 7,
                    CountryName = "Denmark",
                    Image = "Flag_of_Denmark.svg.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 8,
                    CountryName = "Estonia",
                    Image = "Flag_of_Estonia.svg.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 9,
                    CountryName = "Finland",
                    Image = "Flag_of_Finland_(bordered).jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 10,
                    CountryName = "Iceland",
                    Image = "Flag_of_Iceland.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 11,
                    CountryName = "Italy",
                    Image = "Flag_of_Italy.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 12,
                    CountryName = "Lithuania",
                    Image = "Flag_of_Lithuania.svg.jpg",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 13,
                    CountryName = "Poland",
                    Image = "Flag_of_Poland.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 14,
                    CountryName = "Slovakia",
                    Image = "Flag_of_Slovakia.svg.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id= 15,
                    CountryName = "Slovenia",
                    Image = "Flag_of_Slovenia.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 16,
                    CountryName = "Sweden",
                    Image = "Flag_of_Sweden.svg.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 17,
                    CountryName = "Turkey",
                    Image = "Flag_of_Turkey.svg.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 18,
                    CountryName = "Albania",
                    Image = "Flag-Albania.jpg",
                    IsUsed = false
                },
                new FlagsModel()
                {
                    Id=19,
                    CountryName = "Czech Republic",
                    Image = "flag-czech-vector-illustration_514344-268.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 20,
                    CountryName = "Hungary",
                    Image = "Flag-Hungary.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 21,
                    CountryName = "Ireland",
                    Image = "FLAG-Ireland.jpg",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 22,
                    CountryName = "Latvia",
                    Image = "Flag-Latvia.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 23,
                    CountryName = "Norway",
                    Image = "Flag-Norway.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id=24,  
                    CountryName = "Ukraine",
                    Image = "Flag-Ukraine.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 25,
                    CountryName = "France",
                    Image = "france-151928_640.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 26,
                    CountryName = "Greece",
                    Image = "greece.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 27,
                    CountryName = "Portugal",
                    Image = "portugals-flagga.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 28,
                    CountryName = "Netherlands",
                    Image = "iStock-471776245.jpg",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 29,
                    CountryName = "Switzerland",
                    Image = "Switzerland-Flag.jpg",
                    IsUsed = false,
                }



                ) ;
        }

    }
}
