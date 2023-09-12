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
                    { 4, "Belgium", "4", "Belgium.png", false },
                    { 5, "Bulgaria", "5", "Bulgaria.png", false },
                    { 6, "Croatia", "6", "Croatia.png", false },
                    { 7, "Denmark", "7", "Denmark.png", false },
                    { 8, "Estonia", "8", "Estonia.png", false },
                    { 9, "Finland", "9", "Finland.png", false },
                    { 10, "Iceland", "10", "Iceland.png", false },
                    { 11, "Italy", "11", "Italy.png", false },
                    { 12, "Lithuania", "12", "Lithuania.png", false },
                    { 13, "Poland", "13", "Poland.png", false },
                    { 14, "Slovakia", "14", "Slovakia.png", false },
                    { 15, "Slovenia", "15", "Slovenia.png", false },
                    { 16, "Sweden", "16", "Sweden.png", false },
                    { 17, "Turkey", "17", "Turkey.png", false },
                    { 18, "Albania", "18", "Albania.png", false },
                    { 19, "Czech Republic", "19", "Czech.png", false },
                    { 20, "Hungary", "20", "Hungary.png", false },
                    { 21, "Ireland", "21", "Ireland.png", false },
                    { 22, "Latvia", "22", "Latvia.png", false },
                    { 23, "Norway", "23", "Norway.png", false },
                    { 24, "Ukraine", "24", "Ukraine.png", false },
                    { 25, "France", "25", "France.png", false },
                    { 26, "Greece", "26", "Greece.png", false },
                    { 27, "Portugal", "27", "Portugal.png", false },
                    { 28, "Netherlands", "28", "Netherlands.png", false },
                    { 29, "Switzerland", "29", "Switzerland.png", false }
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
