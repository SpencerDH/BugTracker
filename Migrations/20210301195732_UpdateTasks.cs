using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdateTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "23451bd4-5be8-45f8-9864-5d2e96e0a38a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8f9fbe55-4077-4d71-98d6-f946d7b4e7d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "642166f3-2e4d-4c93-9118-b43f10ff103d", "AQAAAAEAACcQAAAAEK8XFanD9ysVRQvxSCblhDdmkZaukUWGVA15K469rMHCXpuQpGHJXzvzxG3uJKfbZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86f9e8d1-a9a2-4781-9324-d737f541a836", "AQAAAAEAACcQAAAAEOPJ+mx1ZhM9DbpmJtU02LJHzaE2so3GST+2KySC4ZdUAWhjsQ8TlifysOcycvt81Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31c8caa1-b138-4ffa-a12f-2215fd88f750", "AQAAAAEAACcQAAAAECsKeM6/EhxHIvPt5190AWvqMQDgvIeK+aBl7XA8lXqtNOL5LALokmofHE+bzfM6jQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "ProjectTasks");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f59b8ee4-fdd5-4f04-bffd-06f4c2f9f617");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "eee59c97-6a85-40d0-930e-d3f68465d842");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55e46c4b-8545-4e56-8075-059ee3008589", "AQAAAAEAACcQAAAAEA1N5UE1kJy72Rf6W6lmCEjY7HUlYYVJsm2FVNBwPoc5IiFX7OaeEKzNDbs60/Z8OA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9317bd34-b311-4497-bd06-b5eb9579725e", "AQAAAAEAACcQAAAAEFLqXl1aCgVPIgdYbUoX98sQ/ZYWr6JvkNyzYMUB7wqBJCGA2kompGxMFBspWA41ww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "217ac4da-3928-4262-950d-a8c4e5daf9bd", "AQAAAAEAACcQAAAAEMn1VAk++LlGLUHqSxsFgzExaAuv7aP7lBFG4hlsQkrDUG+rulH/vwSksG6ACQDhng==" });
        }
    }
}
