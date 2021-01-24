using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class Beattheshitoutofyou : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "52754f0a-4af5-4d85-a4f0-ee87e654eccd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "44437d8c-cab2-4f8f-b865-618745d1e643");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42a20874-60b1-4610-8dec-e50a89b75868", "AQAAAAEAACcQAAAAEKfkqo2AsgM3bjMaA1B90bPCUw2IstOVZQo2INpDOUpfs/HfWlMfumifIIH2xvJZIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ebe72aa-db00-49db-9746-c2ce68b0fddc", "AQAAAAEAACcQAAAAEEZQdZz0eZOx3OpfOTUMId15wTlzpU9W3XvRB+DtqWvgnMK1aa0r9Xnq7AQdrSQ6pw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22f0f248-c7e9-4ab3-97af-a524b28a2444", "AQAAAAEAACcQAAAAEJc3m6+vezwRmtQ5alMoZVWgce3TzRvYDmgeaLMGOvO5OuUxuqYdbxDCzEkmhHYEWA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cc004d30-e8d6-4809-a00f-908eabd52761");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b6226b62-6299-4809-8e57-81ff03c0007a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f1d0c14-efce-4e4b-915c-85cac08678cb", "AQAAAAEAACcQAAAAEIEkZH2yFZYaDaJOa2f9776x2H8e+pQhtICv1/ymLFZ90w5rNrmOp/SRrv6J4rcAqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2106fa80-e8a3-4dbb-8327-4bad70163d69", "AQAAAAEAACcQAAAAEORZ+a8VoVU2lQ8GN2lKvHX4cXiGeFugqhPpUkJmOYElFuqQgL6m0p0PSwkK9nxoEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8020228-6d2e-44d7-82f7-5ead44a836d0", "AQAAAAEAACcQAAAAEK27OrmbEpNlAHyWA9ApuH9XIvQa9iv6PPyGO2YsLMu9i/kj27CxxBIu18gNB/k50Q==" });
        }
    }
}
