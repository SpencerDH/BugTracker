using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class FixingUserIssueConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_AspNetUsers_AppUserId",
                table: "Issues");

            migrationBuilder.DropIndex(
                name: "IX_Issues_AppUserId",
                table: "Issues");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Issues");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserIssue");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Issues",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "32eda406-e16f-4628-b958-c6daf68963fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "f911b514-76d2-45eb-b607-f316e572991a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "778211e7-249d-4a5d-92e5-21d9043475eb", "AQAAAAEAACcQAAAAELmiFRvSmG8V/PJcEA0Odu+R8fzL9Kk9E+bpXp7LD50zszxY/NXW/K+UAXGyuY+kXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "458fd178-2f1f-4ab5-8ce0-1a757a6aff17", "AQAAAAEAACcQAAAAEJjBDpv/HFtXIyjCzobVms4CqZmEbdDi0eJkzIs9EvoUsxEax3nzyR81ZN2xELBpgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ed5ad99-5e87-49ed-a265-21ccba1aef37", "AQAAAAEAACcQAAAAEKq4UsncUKhZ/DCo+CHIu+lZrPhnbo/znSN/X+/84ZOPAlhK+P1ZG1t4qYgEDxvrPw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Issues_AppUserId",
                table: "Issues",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_AspNetUsers_AppUserId",
                table: "Issues",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
