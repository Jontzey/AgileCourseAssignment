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
        public DbSet<News> News { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlagsModel>().HasData(
                new FlagsModel()
                {
                    Id = 1,
                    CountryName = "Germany",
                    Image = "Germany.png",
                    IsUsed = false,


                },
                new FlagsModel()
                {
                    Id = 2,
                    CountryName = "Austria",
                    Image = "Austria.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id=3,
                    CountryName = "Spain",
                    Image = "spain.png",
                    IsUsed = false,
                    
                },
                new FlagsModel()
                {
                    Id = 4,
                    CountryName = "Belgium",
                    Image = "Belgium.png",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id=5,
                    CountryName = "Bulgaria",
                    Image = "Bulgaria.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 6,
                    CountryName = "Croatia",
                    Image = "Croatia.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 7,
                    CountryName = "Denmark",
                    Image = "Denmark.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 8,
                    CountryName = "Estonia",
                    Image = "Estonia.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 9,
                    CountryName = "Finland",
                    Image = "Finland.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 10,
                    CountryName = "Iceland",
                    Image = "Iceland.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 11,
                    CountryName = "Italy",
                    Image = "Italy.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 12,
                    CountryName = "Lithuania",
                    Image = "Lithuania.png",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 13,
                    CountryName = "Poland",
                    Image = "Poland.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 14,
                    CountryName = "Slovakia",
                    Image = "Slovakia.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id= 15,
                    CountryName = "Slovenia",
                    Image = "Slovenia.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 16,
                    CountryName = "Sweden",
                    Image = "Sweden.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 17,
                    CountryName = "Turkey",
                    Image = "Turkey.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 18,
                    CountryName = "Albania",
                    Image = "Albania.png",
                    IsUsed = false
                },
                new FlagsModel()
                {
                    Id=19,
                    CountryName = "Czech Republic",
                    Image = "Czech.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 20,
                    CountryName = "Hungary",
                    Image = "Hungary.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 21,
                    CountryName = "Ireland",
                    Image = "Ireland.png",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 22,
                    CountryName = "Latvia",
                    Image = "Latvia.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 23,
                    CountryName = "Norway",
                    Image = "Norway.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id=24,  
                    CountryName = "Ukraine",
                    Image = "Ukraine.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 25,
                    CountryName = "France",
                    Image = "France.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 26,
                    CountryName = "Greece",
                    Image = "Greece.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 27,
                    CountryName = "Portugal",
                    Image = "Portugal.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 28,
                    CountryName = "Netherlands",
                    Image = "Netherlands.png",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 29,
                    CountryName = "Switzerland",
                    Image = "Switzerland.png",
                    IsUsed = false,
                }



                ) ;

            modelBuilder.Entity<HighScoreModel>().HasData(
               new HighScoreModel()
               {
                   Id = 1,
                   Name = "Player1",
                   Score = 250,
                   Time = 120
               },
               new HighScoreModel()
               {
                   Id = 2,
                   Name = "Player2",
                   Score = 180,
                   Time = 90
               },

               new HighScoreModel()
               {
                   Id = 3,
                   Name = "Player3",
                   Score = 320,
                   Time = 150
               },
               new HighScoreModel()
               {
                   Id = 4,
                   Name = "Player4",
                   Score = 200,
                   Time = 110
               },
               new HighScoreModel()
               {
                   Id = 5,
                   Name = "Player5",
                   Score = 280,
                   Time = 130
               }

               );

            modelBuilder.Entity<News>().HasData(
                    new News()
                    {
                        Id = 1,
                        Titel = "Development",
                        BodyInformation = "Im glad to announce that a project has started for fun learning experience."
                    },
                    new News()
                    {
                         Id = 2,
                         Titel = "Quiz v.1",
                         BodyInformation = "There is now a Quiz game where you guess the flag!"
                    },
                    new News()
                    {
                         Id = 3,
                         Titel = "Highscore table",
                         BodyInformation = "There is now a highscore page where you can compare results from yourself and others."
                    },
                    new News()
                    {
                         Id = 4,
                         Titel = "Quiz v.2",
                         BodyInformation = "A second Quiz game has been added, check it out!"
                    }
                
                );
        }

    }
}
