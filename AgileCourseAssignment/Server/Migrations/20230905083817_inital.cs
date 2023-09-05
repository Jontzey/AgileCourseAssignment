using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgileCourseAssignment.Server.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
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
                    { 1, "Germany", "Germany.jpg", false },
                    { 2, "Austria", "Austria.jpg", false },
                    { 3, "Spain", "Bandera_de_España.jpg", false },
                    { 4, "Belgium", "Flag_of_Belgium_(civil).jpg", false },
                    { 5, "Bulgaria", "Flag_of_Bulgaria.jpg", false },
                    { 6, "Croatia", "Flag_of_Croatia.jpg", false },
                    { 7, "Denmark", "Flag_of_Denmark.svg.jpg", false },
                    { 8, "Estonia", "Flag_of_Estonia.svg.jpg", false },
                    { 9, "Finland", "Flag_of_Finland_(bordered).jpg", false },
                    { 10, "Iceland", "Flag_of_Iceland.jpg", false },
                    { 11, "Italy", "Flag_of_Italy.jpg", false },
                    { 12, "Lithuania", "Flag_of_Lithuania.svg.jpg", false },
                    { 13, "Poland", "Flag_of_Poland.jpg", false },
                    { 14, "Slovakia", "Flag_of_Slovakia.svg.jpg", false },
                    { 15, "Slovenia", "Flag_of_Slovenia.jpg", false },
                    { 16, "Sweden", "Flag_of_Sweden.svg.jpg", false },
                    { 17, "Turkey", "Flag_of_Turkey.svg.jpg", false },
                    { 18, "Albania", "Flag-Albania.jpg", false },
                    { 19, "Czech Republic", "flag-czech-vector-illustration_514344-268.jpg", false },
                    { 20, "Hungary", "Flag-Hungary.jpg", false },
                    { 21, "Ireland", "FLAG-Ireland.jpg", false },
                    { 22, "Latvia", "Flag-Latvia.jpg", false },
                    { 23, "Norway", "Flag-Norway.jpg", false },
                    { 24, "Ukraine", "Flag-Ukraine.jpg", false },
                    { 25, "France", "france-151928_640.jpg", false },
                    { 26, "Greece", "greece.jpg", false },
                    { 27, "Portugal", "portugals-flagga.jpg", false },
                    { 28, "Netherlands", "iStock-471776245.jpg", false },
                    { 29, "Switzerland", "Switzerland-Flag.jpg", false }
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
