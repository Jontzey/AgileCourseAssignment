using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgileCourseAssignment.Server.Migrations
{
    /// <inheritdoc />
    public partial class HighScoreUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HighScore",
                columns: new[] { "Id", "Name", "Score", "Time" },
                values: new object[] { 1, "Test", 150, 100 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HighScore",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
