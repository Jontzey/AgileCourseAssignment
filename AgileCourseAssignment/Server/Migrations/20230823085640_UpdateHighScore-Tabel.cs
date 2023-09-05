using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgileCourseAssignment.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHighScoreTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HighScore",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Score", "Time" },
                values: new object[] { "Player1", 250, 120 });

            migrationBuilder.InsertData(
                table: "HighScore",
                columns: new[] { "Id", "Name", "Score", "Time" },
                values: new object[,]
                {
                    { 2, "Player2", 180, 90 },
                    { 3, "Player3", 320, 150 },
                    { 4, "Player4", 200, 110 },
                    { 5, "Player5", 280, 130 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HighScore",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HighScore",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HighScore",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HighScore",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "HighScore",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Score", "Time" },
                values: new object[] { "Test", 150, 100 });
        }
    }
}
