using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgileCourseAssignment.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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

            migrationBuilder.InsertData(
                table: "Flags",
                columns: new[] { "Id", "CountryName", "Image", "IsUsed" },
                values: new object[,]
                {
                    { 1, "Germany", "Germany.png", false },
                    { 2, "Austria", "Austria.png", false },
                    { 3, "Spain", "spain.png", false },
                    { 4, "Belgium", "Belgium.png", false },
                    { 5, "Bulgaria", "Bulgaria.png", false },
                    { 6, "Croatia", "Croatia.png", false },
                    { 7, "Denmark", "Denmark.png", false },
                    { 8, "Estonia", "Estonia.png", false },
                    { 9, "Finland", "Finland.png", false },
                    { 10, "Iceland", "Iceland.png", false },
                    { 11, "Italy", "Italy.png", false },
                    { 12, "Lithuania", "Lithuania.png", false },
                    { 13, "Poland", "Poland.png", false },
                    { 14, "Slovakia", "Slovakia.png", false },
                    { 15, "Slovenia", "Slovenia.png", false },
                    { 16, "Sweden", "Sweden.png", false },
                    { 17, "Turkey", "Turkey.png", false },
                    { 18, "Albania", "Albania.png", false },
                    { 19, "Czech Republic", "Czech.png", false },
                    { 20, "Hungary", "Hungary.png", false },
                    { 21, "Ireland", "Ireland.png", false },
                    { 22, "Latvia", "Latvia.png", false },
                    { 23, "Norway", "Norway.png", false },
                    { 24, "Ukraine", "Ukraine.png", false },
                    { 25, "France", "France.png", false },
                    { 26, "Greece", "Greece.png", false },
                    { 27, "Portugal", "Portugal.png", false },
                    { 28, "Netherlands", "Netherlands.png", false },
                    { 29, "Switzerland", "Switzerland.png", false }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flags");

            migrationBuilder.DropTable(
                name: "HighScore");
        }
    }
}
