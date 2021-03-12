using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class TimeCreatedIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8914a210-ad77-413b-8492-322178573efb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "9401a945-3179-48f8-8ba8-786234bc80f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bee96551-12ba-4340-8f52-2e47625ee784", "AQAAAAEAACcQAAAAEEEyXA25qJvLnaUUXyAg9L7DYYfzadG+jwk56wG4F4l+vXB13+5n0Dt/XiwsHGil+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cd2d95f-de08-40ef-94e9-ba8f1413a5b8", "AQAAAAEAACcQAAAAEJOQbs9GUou4O/J2aV1xcn/Qs8052NjgDKRA55xLMX0FHVU3Q0a9TDFPSsfWMwbNwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42757d16-20e1-4ac3-8f83-5b9e069c9a58", "AQAAAAEAACcQAAAAEKsyPK3cw4qcJQ+gDcZQ7K3NbdqYlP9b97l2cP/Awdd+ymtq4sTs+mfPj03KcwsWyw==" });
        }
    }
}
