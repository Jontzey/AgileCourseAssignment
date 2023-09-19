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
                    Description = "Black, gold and red are symbolic of the country's coat of arms. The three-striped vertical layout was inspired by the French Tricolour. Black and gold were chosen where the Belgian Revolution started and red was added as a symbol of the blood spilled during the uprising.",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 5,
                    CountryName = "Bulgaria",
                    Image = "Bulgaria.png",
                    Description = "The flag of Bulgaria was adopted in 1989 and consists of three horizontal bands of white, green and red.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 6,
                    CountryName = "Croatia",
                    Image = "Croatia.png",
                    Description = "The flag of Croatia, adopted in December 1990, consists of three equal horizontal stripes of red, white and blue and the coat of arms of Croatia in the center.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 7,
                    CountryName = "Denmark",
                    Image = "Denmark.png",
                    Description = "It is the world's oldest state flag still in use. Legend has it that it appeared as a sign from heaven to King Valdemar II in 1219. This blood-red flag with an off-centred white cross became a model for other regional flags.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 8,
                    CountryName = "Estonia",
                    Image = "Estonia.png",
                    Description = "It was officially re-adopted on May 8, 1990.Blue represents loyalty, and the country's beautiful blue skies, seas and lakes; black is symbolic of past oppression and the fertile soil; and white represents virtue, winter snows",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 9,
                    CountryName = "Finland",
                    Image = "Finland.png",
                    Description = "The off-centred blue cross is based on the Nordic Cross, widely used on Nordic national flags. The blue colour is symbolic of blue skies, and the thousands of lakes in Finland. The white represents the winter snows.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 10,
                    CountryName = "Iceland",
                    Image = "Iceland.png",
                    Description = "The flag of Iceland was adopted in June 1915 to represent Iceland. It is a reverse colour image of the Flag of Norway. The blue represents the sea, the white represents the snow and glaciers and the red symbolises volcanic lava.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 11,
                    CountryName = "Italy",
                    Image = "Italy.png",
                    Description = "Derived from an original design by Napoleon, it consists of three vertical bands of equal width, displaying the national colours of Italy: green, white, and red. Green stands for hope, white for loyalty and red represents the blood spread to unify the country.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 12,
                    CountryName = "Lithuania",
                    Image = "Lithuania.png",
                    Description = "Yellow is symbolic of the country's wheat fields, green symbolic of the forests, and red symbolises patriotism. Collectively the colours represent hope for the future, freedom from oppression, and the courage",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 13,
                    CountryName = "Poland",
                    Image = "Poland.png",
                    Description = "The flag of Poland was officially adopted on August 1, 1919. The colours red and white have long been associated with Poland and its coat of arms, at least since 3 May 1791.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 14,
                    CountryName = "Slovakia",
                    Image = "Slovakia.png",
                    Description = "Adopted on September 1, 1992. White, blue and red are traditional Pan-Slavic colours. The superimposed Slovakian arms feature a dominant white cross atop a blue symbolic reference to the European country's mountains.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 15,
                    CountryName = "Slovenia",
                    Image = "Slovenia.png",
                    Description = "Adopted on June 24, 1991. Red, white, and blue are taken from the Carniolan coat of arms. The mountains shown in white are representative of the Alps, and Mount Triglav, Slovenia's national symbol, in particular",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 16,
                    CountryName = "Sweden",
                    Image = "Sweden.png",
                    Description = "Was officially adopted on June 22, 1906. The off-centre yellow cross (the Nordic Cross) is taken from the Danish flag. The yellow and blue colours are taken from the national coat of arms.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 17,
                    CountryName = "Turkey",
                    Image = "Turkey.png",
                    Description = "The flag of Turkey is a red flag with a white crescent moon and a star in its centre. The flag is called Ay Yıldız ( Moon Star) or Red flag. It was adopted in 1844 with the Tanzimat reforms; though the shape, placement and shade of the colour .",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 18,
                    CountryName = "Albania",
                    Image = "Albania.png",
                    Description = "The flag of Albania, adopted in April 1912, is a red flag with a black two-headed eagle in the centre. It is derived from the seal of Gjergj Skanderbeg, on 15th-century  who led a revolt against the Ottoman Empire that resulted in brief independence for Albania from 1443. ",
                    IsUsed = false
                },
                new FlagsModel()
                {
                    Id = 19,
                    CountryName = "Czech Republic",
                    Image = "Czech.png",
                    Description = "The first flag of Czechoslovakia was white over red, and those colours are the heraldic colours of Bohemia. The blue triangle was added to the flag to distinguish it from the flag of Poland, and blue is said to represent the State of Moravia.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 20,
                    CountryName = "Hungary",
                    Image = "Hungary.png",
                    Description = "The flag of Hungary was officially adopted in 1848.\r\nThe colors of the tricolour design are derived from the historical Hungarian coat of arms. Red is said to symbolise strength, white faithfulness, and green hope.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 21,
                    CountryName = "Ireland",
                    Image = "Ireland.png",
                    Description = "Dating from the 19th century and officially adopted in 1937. the colours of the Irish tricolour symbolise two communities. Green represents the Roman Catholic nationalist tradition. Orange represents the Protestant unionist community.",
                    IsUsed = false,

                },
                new FlagsModel()
                {
                    Id = 22,
                    CountryName = "Latvia",
                    Image = "Latvia.png",
                    Description = "The flag of Latvia was officially re-adopted on February 27, 1990.The design is adopted from a 13th-century chronicle where \"red divided by white\" is said to be a Latvian flag.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 23,
                    CountryName = "Norway",
                    Image = "Norway.png",
                    Description = "The flag of Norway is red with a blue Nordic cross outlined in white; the vertical part of the cross is shifted to the hoist side in the style of the Dannebrog, the flag of Denmark. It was adopted in 1821.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 24,
                    CountryName = "Ukraine",
                    Image = "Ukraine.png",
                    Description = "Was adopted in 1991, shortly after the collapse of the former Soviet Union. The shade of blue is said to be symbolic of the sky, while the yellow represents Ukraine's golden wheat fields.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 25,
                    CountryName = "France",
                    Image = "France.png",
                    Description = "Officially adopted on February 15, 1794. Red, white and blue have come to represent liberty, equality and fraternity—the ideals of the French Revolution. ",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 26,
                    CountryName = "Greece",
                    Image = "Greece.png",
                    Description = "Adopted as the national flag in 1978. The alternating white and blue stripes are said to represent the nine syllables of the phrase \"Eleftheria i thanatos\" (\"Freedom or Death\"), a popular motto during the Greek War of Independence.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 27,
                    CountryName = "Portugal",
                    Image = "Portugal.png",
                    Description = "Adopted in 1911. The colours representing the hope of the nation (green) and the blood (red) of those who died defending it.",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 28,
                    CountryName = "Netherlands",
                    Image = "Netherlands.png",
                    Description = "The flag of Luxembourg was officially adopted in 1972 and uses a combination of red, white, and blue that dates to the 13th century",
                    IsUsed = false,
                },
                new FlagsModel()
                {
                    Id = 29,
                    CountryName = "Switzerland",
                    Image = "Switzerland.png",
                    Description = "The flag of Switzerland consists of a red square with a bold, equilateral white Greek cross in the centre. It is one of only two square flags, the other being that of the Vatican City.",
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
