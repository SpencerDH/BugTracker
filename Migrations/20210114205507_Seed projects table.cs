using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class Seedprojectstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Moving to Atlanta" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Starting front-end studies" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Name" },
                values: new object[] { 3, "Algorithm practice" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
