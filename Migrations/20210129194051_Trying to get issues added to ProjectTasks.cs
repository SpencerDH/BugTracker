using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class TryingtogetissuesaddedtoProjectTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "dc8ebe78-0ba6-46a5-9bbb-fcef9c7d5499");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "165ea6e7-62b3-4e28-8ecb-a7b5873714af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3046da5-0f96-41c7-aabf-7fe7fc9cac0d", "AQAAAAEAACcQAAAAEExx83G1BCzVlBcGEtG6NxVM8iA4ffROUaD/Ua4cjacXGVCyyNm/xiQKmimk/y3PKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9395a0b5-c10a-4fb0-8ea4-b3aced2292f4", "AQAAAAEAACcQAAAAEOH+KQaMKlG8/dTQ1aaAe9WEPBtHOHd2qlzYl9CcsnctRjEYbG6N2UM23D4jk/aGVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3e1c6a5-f24a-4259-bb80-64a6b09bf6ef", "AQAAAAEAACcQAAAAEBPQKEZPEd8l3wEnt1GTy4drFBY6mR55MOmDz7DYLk0j7WN6BhYklMmo6NFYKMwUcg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9c8dc949-e061-4019-826a-55581bdbd7a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8d319af8-e807-4500-99d0-a6414a6f0203");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06ae258e-3025-4a82-bc26-13ed06e6c9c4", "AQAAAAEAACcQAAAAEDsx+sS5FLQki6hL6so5HH7Il/XKRKVhz+LPYmsXVFZ/Y3+H9Fj8JrxI9ABqrTD94g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4edd2b92-bfd3-427f-bfec-1bbb45d8ad04", "AQAAAAEAACcQAAAAEOG36WEtUm66X3XXx8XcsK7zYE8opa56l4WTCtEmkrVEX7M2m2kMJPwqep4rxxttEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec6efd50-6562-4637-84bd-76fd3a9635cd", "AQAAAAEAACcQAAAAEN6sQHHwRrIp2Sl+1++3D88cfGEEULv+QTQR5hWXAoVUY5SyYsUsMuw6c444jpV8kg==" });
        }
    }
}
