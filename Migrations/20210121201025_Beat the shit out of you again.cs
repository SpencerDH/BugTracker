using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class Beattheshitoutofyouagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8555f798-1256-48a9-8406-136562cc3ce8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6433c19f-a2a2-43d8-9de8-33c0f06f50ad");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "4ca50453-aba3-473d-b071-2bdff907b6d3", "Beat the shit out of you", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25ded6fd-af86-4a70-9aa6-78a17fdfa2a1", "AQAAAAEAACcQAAAAEJk1Kg6CjFShqIX5Lqe3La5ylAaAPf7ODmuJKBeytuNzuDhdZGliQ/H8UkiaGIt1QA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bc4984b-7c7d-41af-bf4b-9836302a861e", "AQAAAAEAACcQAAAAEIw8YTsdsjQBxcFLle0ptACZ6Qtv9L9/9GG3pWBwwnmkmOA5t2yD6/zM/HQKf97qLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ddafb1f-2373-40b7-8d06-3408256aba70", "AQAAAAEAACcQAAAAEKrh98lAp4+TobZxYrg7hShycMJbjg8cpcynwhBXFKXpD+Z6QVZRdt8lASMLj7LgUQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
