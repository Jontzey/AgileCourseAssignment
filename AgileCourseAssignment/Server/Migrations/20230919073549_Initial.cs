using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgileCourseAssignment.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HighScore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighScore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyInformation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Flags",
                columns: new[] { "Id", "CountryName", "Description", "Image", "IsUsed" },
                values: new object[,]
                {
                    { 1, "Germany", "The tricolour flag was designed in 1832, and the black, red, and gold colours were taken from the uniforms of German soldiers during the Napoleonic Wars.", "Germany.png", false },
                    { 2, "Austria", "Stripes of red and white have been a collective emblem of Austria for over 800 years, and they were first used on the flag in 1191.", "Austria.png", false },
                    { 3, "Spain", "The flag of Spain was officially adopted on 19 July 1927 as the merchant naval flag, and on 29 December 1978 as the national flag in order to easily differentiate his ships from those of other European nations. ", "spain.png", false },
                    { 4, "Belgium", "Black, gold and red are symbolic of the country's coat of arms. The three-striped vertical layout was inspired by the French Tricolour. Black and gold were chosen where the Belgian Revolution started and red was added as a symbol of the blood spilled during the uprising.", "Belgium.png", false },
                    { 5, "Bulgaria", "The flag of Bulgaria was adopted in 1989 and consists of three horizontal bands of white, green and red.", "Bulgaria.png", false },
                    { 6, "Croatia", "The flag of Croatia, adopted in December 1990, consists of three equal horizontal stripes of red, white and blue and the coat of arms of Croatia in the center.", "Croatia.png", false },
                    { 7, "Denmark", "It is the world's oldest state flag still in use. Legend has it that it appeared as a sign from heaven to King Valdemar II in 1219. This blood-red flag with an off-centred white cross became a model for other regional flags.", "Denmark.png", false },
                    { 8, "Estonia", "It was officially re-adopted on May 8, 1990.Blue represents loyalty, and the country's beautiful blue skies, seas and lakes; black is symbolic of past oppression and the fertile soil; and white represents virtue, winter snows", "Estonia.png", false },
                    { 9, "Finland", "The off-centred blue cross is based on the Nordic Cross, widely used on Nordic national flags. The blue colour is symbolic of blue skies, and the thousands of lakes in Finland. The white represents the winter snows.", "Finland.png", false },
                    { 10, "Iceland", "The flag of Iceland was adopted in June 1915 to represent Iceland. It is a reverse colour image of the Flag of Norway. The blue represents the sea, the white represents the snow and glaciers and the red symbolises volcanic lava.", "Iceland.png", false },
                    { 11, "Italy", "Derived from an original design by Napoleon, it consists of three vertical bands of equal width, displaying the national colours of Italy: green, white, and red. Green stands for hope, white for loyalty and red represents the blood spread to unify the country.", "Italy.png", false },
                    { 12, "Lithuania", "Yellow is symbolic of the country's wheat fields, green symbolic of the forests, and red symbolises patriotism. Collectively the colours represent hope for the future, freedom from oppression, and the courage", "Lithuania.png", false },
                    { 13, "Poland", "The flag of Poland was officially adopted on August 1, 1919. The colours red and white have long been associated with Poland and its coat of arms, at least since 3 May 1791.", "Poland.png", false },
                    { 14, "Slovakia", "Adopted on September 1, 1992. White, blue and red are traditional Pan-Slavic colours. The superimposed Slovakian arms feature a dominant white cross atop a blue symbolic reference to the European country's mountains.", "Slovakia.png", false },
                    { 15, "Slovenia", "Adopted on June 24, 1991. Red, white, and blue are taken from the Carniolan coat of arms. The mountains shown in white are representative of the Alps, and Mount Triglav, Slovenia's national symbol, in particular", "Slovenia.png", false },
                    { 16, "Sweden", "Was officially adopted on June 22, 1906. The off-centre yellow cross (the Nordic Cross) is taken from the Danish flag. The yellow and blue colours are taken from the national coat of arms.", "Sweden.png", false },
                    { 17, "Turkey", "The flag of Turkey is a red flag with a white crescent moon and a star in its centre. The flag is called Ay Yıldız ( Moon Star) or Red flag. It was adopted in 1844 with the Tanzimat reforms; though the shape, placement and shade of the colour .", "Turkey.png", false },
                    { 18, "Albania", "The flag of Albania, adopted in April 1912, is a red flag with a black two-headed eagle in the centre. It is derived from the seal of Gjergj Skanderbeg, on 15th-century  who led a revolt against the Ottoman Empire that resulted in brief independence for Albania from 1443 ", "Albania.png", false },
                    { 19, "Czech Republic", "The first flag of Czechoslovakia was white over red, and those colours are the heraldic colours of Bohemia. The blue triangle was added to the flag to distinguish it from the flag of Poland, and blue is said to represent the State of Moravia.", "Czech.png", false },
                    { 20, "Hungary", "The flag of Hungary was officially adopted in 1848.\r\nThe colors of the tricolour design are derived from the historical Hungarian coat of arms. Red is said to symbolise strength, white faithfulness, and green hope.", "Hungary.png", false },
                    { 21, "Ireland", "Dating from the 19th century and officially adopted in 1937. the colours of the Irish tricolour symbolise two communities. Green represents the Roman Catholic nationalist tradition. Orange represents the Protestant unionist community.", "Ireland.png", false },
                    { 22, "Latvia", "The flag of Latvia was officially re-adopted on February 27, 1990.The design is adopted from a 13th-century chronicle where \"red divided by white\" is said to be a Latvian flag.", "Latvia.png", false },
                    { 23, "Norway", "The flag of Norway is red with a blue Nordic cross outlined in white; the vertical part of the cross is shifted to the hoist side in the style of the Dannebrog, the flag of Denmark. It was adopted in 1821.", "Norway.png", false },
                    { 24, "Ukraine", "Was adopted in 1991, shortly after the collapse of the former Soviet Union. The shade of blue is said to be symbolic of the sky, while the yellow represents Ukraine's golden wheat fields.", "Ukraine.png", false },
                    { 25, "France", "Officially adopted on February 15, 1794. Red, white and blue have come to represent liberty, equality and fraternity—the ideals of the French Revolution. ", "France.png", false },
                    { 26, "Greece", "Adopted as the national flag in 1978. The alternating white and blue stripes are said to represent the nine syllables of the phrase \"Eleftheria i thanatos\" (\"Freedom or Death\"), a popular motto during the Greek War of Independence.", "Greece.png", false },
                    { 27, "Portugal", "Adopted in 1911. The colours representing the hope of the nation (green) and the blood (red) of those who died defending it.", "Portugal.png", false },
                    { 28, "Netherlands", "The flag of Luxembourg was officially adopted in 1972 and uses a combination of red, white, and blue that dates to the 13th century", "Netherlands.png", false },
                    { 29, "Switzerland", "The flag of Switzerland consists of a red square with a bold, equilateral white Greek cross in the centre. It is one of only two square flags, the other being that of the Vatican City.", "Switzerland.png", false }
                });

            migrationBuilder.InsertData(
                table: "HighScore",
                columns: new[] { "Id", "Name", "Score", "Time" },
                values: new object[,]
                {
                    { 1, "Player1", 250, 120 },
                    { 2, "Player2", 180, 90 },
                    { 3, "Player3", 320, 150 },
                    { 4, "Player4", 200, 110 },
                    { 5, "Player5", 280, 130 }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "BodyInformation", "Titel" },
                values: new object[,]
                {
                    { 1, "Im glad to announce that a project has started for fun learning experience.", "Development" },
                    { 2, "There is now a Quiz game where you guess the flag!", "Quiz v.1" },
                    { 3, "There is now a highscore page where you can compare results from yourself and others.", "Highscore table" },
                    { 4, "A second Quiz game has been added, check it out!", "Quiz v.2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flags");

            migrationBuilder.DropTable(
                name: "HighScore");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
