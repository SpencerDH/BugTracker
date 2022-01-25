using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdateAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f868573d-6fbf-439d-b577-f5baacf51ce7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "2d93fd98-3510-46ac-9fba-36ab6f2e57cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e17b20e5-c0a7-4dc2-8750-7a317b2de039", "AQAAAAEAACcQAAAAEL2Da3nN9/1vvjog3+o8U9xqCwexLaIB3wdxsPc1UdVho+AQgL4pMT72Pcg2a8bsNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13e7b199-66a4-4b91-b9a4-1657755df130", "AQAAAAEAACcQAAAAEPtWTfjmLoBgzMXZEalU29Gn6rP290yLGaANyLqtXqi/j7damvaRnNpeTCDmyuqGzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "806aed7e-e64a-4de2-be47-59d85eb0e838", "AQAAAAEAACcQAAAAEF5ctv8yKqYQBBylxcOddtc4iyooPZiV4hGMXryl1IHgKEUdxJmGQO/ZWNF4WVz9Bg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ce06fa4e-693d-47c8-87c4-e0f5312f8324");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "66bc8e90-4d31-4290-bb76-c8889a3042d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebe985f2-24a7-4f30-b5b5-bf7f27216ee0", "AQAAAAEAACcQAAAAEIEw3Q4gebLetaDffwqnpgt8kdyUUM/CAQkAZKUIUZGZQBUKtaZ4V2AUdJaQjUZfCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d222c164-2a0e-4350-9c60-90e9e6769f31", "AQAAAAEAACcQAAAAEIB55SoDLKAVa04pVqVd3RX5hDMRu0ixyiLLfiKc+ZEwKQv51w1OUM3hqaKIiaflKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9edd2f96-3f2a-4be2-a82d-6051164ba096", "AQAAAAEAACcQAAAAEIk+Sal7QMDDy0JpyPP8v6W/wVRLQ42BNoDqNs2WzkVNpZv/MTC1s+NI8IL+T0u0vw==" });
        }
    }
}
