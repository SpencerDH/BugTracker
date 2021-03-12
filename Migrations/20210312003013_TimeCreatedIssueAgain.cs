using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class TimeCreatedIssueAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeCreated",
                table: "Issues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "089c2ed6-ff9a-43a7-8ddc-80cd2f29172d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "f145ebb9-1616-423a-ad43-12744fb6a0d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d204db0-2e89-45b1-9d37-310d19082c29", "AQAAAAEAACcQAAAAEMFkul/ODJJcppEQiSoeBuUCIVFmSqNdGemHA5rVw4fkn8VWv74KgXPEv6LirXzYbg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "882ca98d-fb67-4eb8-9d31-19b8bd19a877", "AQAAAAEAACcQAAAAEBU51G5IvG38YnsVIIbwnxUrJlA6IOWqZoz4T9Xc5sgv6ZCBT0TTEU7PI0v53+wAJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0eba6f37-22db-452d-85fa-38e82af22353", "AQAAAAEAACcQAAAAEHuoppJThb+qHlWKvXsUi/qYOCTDoZiTaQBz4knu8q8WlgO7eWPf7FwGG+unb+QdKw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeCreated",
                table: "Issues");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "5e28aa39-9476-4cd7-8470-2c7d0a98aeba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a95981d7-8e16-4c7b-9bf5-09d546f4a65f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03b37062-2e38-4df1-b959-c7fa2f116f1a", "AQAAAAEAACcQAAAAELYJ0qCDrb4NUCURV3cUKqPVrEhFL3/4zfFD9gFxZltRFD2fYO+Mv9mKwiju6u7h9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee5ac69c-8554-4edc-a77c-487d7adf8ab1", "AQAAAAEAACcQAAAAEJJEHukL2tJPzqJsuKN79d2zjpNFTtqH/Bs84B9ieUkaGOmWGcLOXirHH6wwX17U9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "829ffa57-d6c1-4f34-90c0-945111f1ed4b", "AQAAAAEAACcQAAAAELIpB/98I8pGfknhHGiCfhyWXKed1ztYORzhvtgAVeOh0pyRpQzj+V2rkAIvwTYksw==" });
        }
    }
}
