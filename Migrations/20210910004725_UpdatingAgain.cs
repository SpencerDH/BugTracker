using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdatingAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserIssue");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0fe25b39-bbe4-4652-9ef7-36a8ae58328a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "ec3471be-702d-4dd4-8fe7-93ff43579ec9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0cf2361-5e69-4ed5-b0d6-4e856de94c43", "AQAAAAEAACcQAAAAEIs7mqNSWzOCZw8OJApWmo6PJsLaqsXz1C1EnnrODUPrXfXfQ8xRZqVKOLKDQAogbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6addfbe3-b955-4fb6-a0f0-aba5d989b809", "AQAAAAEAACcQAAAAEOZLRnQwLz0slzM1ePcKsSLDt5ObEMDv0aR5hNZRtx0R4qZes+kY2WauNykDD6apug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d629ede4-697a-42d9-b4de-f75c8eba08fc", "AQAAAAEAACcQAAAAEBObgwXjMuwDhVBchrjNDpDdyFcCq2Y8veseELBSMiOKk9Wv3HL9wAqXWgh+rA3TRA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUserIssue",
                columns: table => new
                {
                    AppUsersId = table.Column<int>(type: "int", nullable: false),
                    IssuesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserIssue", x => new { x.AppUsersId, x.IssuesID });
                    table.ForeignKey(
                        name: "FK_AppUserIssue_AspNetUsers_AppUsersId",
                        column: x => x.AppUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserIssue_Issues_IssuesID",
                        column: x => x.IssuesID,
                        principalTable: "Issues",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f050372b-4a1d-4db8-a54e-14acbba804d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "9fe498f1-c62e-4629-a9fd-25da6d160f75");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fda3a839-733e-4eec-8796-4a036b82accf", "AQAAAAEAACcQAAAAEP2IKyJTMIW/ytIkcgqyQpJ5pnydpnXhAk7nXMyYSJRQp+27dZQJjouqStIOCDztyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df61f304-306b-4dda-ad25-89d0e338a2fc", "AQAAAAEAACcQAAAAEP0hX1DvoDG8PHth7MAS2dhhT1NB3a1sEWpdIJU+sgyyt3qw2HtWvVBrcjG0jdQRQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c420ea97-7e73-4092-9276-05f5fc7f5918", "AQAAAAEAACcQAAAAENLd7X6IeV0+vca3mXZWibIzHG318dzR4ft8Wf2tL8XO7s1DVk/veaK8dRjBhP3NGQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserIssue_IssuesID",
                table: "AppUserIssue",
                column: "IssuesID");
        }
    }
}
