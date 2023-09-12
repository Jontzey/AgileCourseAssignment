using AgileCourseAssignment.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileCourseAssignment.Server.Data
{
    public class FlagScapeDb : DbContext
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
                    Description = "The tricolour flag was designed in 1832, and the black, red, and gold colours were taken from the uniforms of German soldiers during the Napoleonic Wars.",
                    IsUsed = false,


                },
                new FlagsModel()
                {
                    Id = 2,
                    CountryName = "Austria",
                    Image = "Austria.png",
                    Description = "Stripes of red and white have been a collective emblem of Austria for over 800 years, and they were first used on the flag in 1191.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 3,
                    CountryName = "Spain",
                    Image = "spain.png",
                    Description = "The flag of Spain was officially adopted on 19 July 1927 as the merchant naval flag, and on 29 December 1978 as the national flag in order to easily differentiate his ships from those of other European nations. ",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 4,
                    CountryName = "Belgium",
                    Image = "Belgium.png",
                    Description = "4",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 5,
                    CountryName = "Bulgaria",
                    Image = "Bulgaria.png",
                    Description = "5",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 6,
                    CountryName = "Croatia",
                    Image = "Croatia.png",
                    Description = "6",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 7,
                    CountryName = "Denmark",
                    Image = "Denmark.png",
                    Description = "7",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 8,
                    CountryName = "Estonia",
                    Image = "Estonia.png",
                    Description = "8",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 9,
                    CountryName = "Finland",
                    Image = "Finland.png",
                    Description = "9",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 10,
                    CountryName = "Iceland",
                    Image = "Iceland.png",
                    Description = "10",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 11,
                    CountryName = "Italy",
                    Image = "Italy.png",
                    Description = "11",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 12,
                    CountryName = "Lithuania",
                    Image = "Lithuania.png",
                    Description = "12",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 13,
                    CountryName = "Poland",
                    Image = "Poland.png",
                    Description = "13",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 14,
                    CountryName = "Slovakia",
                    Image = "Slovakia.png",
                    Description = "14",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 15,
                    CountryName = "Slovenia",
                    Image = "Slovenia.png",
                    Description = "15",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 16,
                    CountryName = "Sweden",
                    Image = "Sweden.png",
                    Description = "16",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 17,
                    CountryName = "Turkey",
                    Image = "Turkey.png",
                    Description = "17",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 18,
                    CountryName = "Albania",
                    Image = "Albania.png",
                    Description = "18",
                    IsUsed = false
                },
                new FlagsModel()
                {
                    Id = 19,
                    CountryName = "Czech Republic",
                    Image = "Czech.png",
                    Description = "19",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 20,
                    CountryName = "Hungary",
                    Image = "Hungary.png",
                    Description = "20",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 21,
                    CountryName = "Ireland",
                    Image = "Ireland.png",
                    Description = "21",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 22,
                    CountryName = "Latvia",
                    Image = "Latvia.png",
                    Description = "22",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 23,
                    CountryName = "Norway",
                    Image = "Norway.png",
                    Description = "23",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 24,
                    CountryName = "Ukraine",
                    Image = "Ukraine.png",
                    Description = "24",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 25,
                    CountryName = "France",
                    Image = "France.png",
                    Description = "25",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 26,
                    CountryName = "Greece",
                    Image = "Greece.png",
                    Description = "26",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 27,
                    CountryName = "Portugal",
                    Image = "Portugal.png",
                    Description = "27",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 28,
                    CountryName = "Netherlands",
                    Image = "Netherlands.png",
                    Description = "28",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 29,
                    CountryName = "Switzerland",
                    Image = "Switzerland.png",
                    Description = "29",
                    IsUsed = false,
                }



                );

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
