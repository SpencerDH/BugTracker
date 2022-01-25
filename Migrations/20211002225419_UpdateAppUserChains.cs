using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdateAppUserChains : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e21619cd-94b2-4508-9941-f7489230e4c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d39b78c9-d29f-45e0-a8cb-510e77cd2eeb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "806c82fd-5b12-4e6f-89ca-e4cf9f21c505", "AQAAAAEAACcQAAAAEHggpkLeuMJWXI+BUeie8EY8RIFX37rOoSyNlHyZ8UY28z2VLpJ9H8e9FGDjxAn8gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c14fd14-c5c0-423e-9ebd-81723188b71d", "AQAAAAEAACcQAAAAEBXAedzHzZzfElCCOned1Udd2s6EDEdcrWJSa+/TePzlxRmf6nMMbnLpMifgWZi12A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5770a36-abc8-4783-b75a-2fc0a178fa33", "AQAAAAEAACcQAAAAEC1cscNP/uUKaExuJg5SEsjaZD8+se8qHF4z9ePV2jK7diHwhmhUB+wl82LBr3+hQQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
