using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class ConnectingUsersToIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "862f0df9-ba82-4bf5-81e3-0c1cf1cf4d85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "df061672-ae0e-466c-92ae-5d776aa438d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ade87af9-59e1-44cf-9e2e-702e7d049251", "AQAAAAEAACcQAAAAELg2iVE9hYUJl7c/Od3MYrao35B6DbPVPZJTkxXUxSRYuyK1SY9p38uAf8npQxW/Dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dde261dc-bcc0-4463-8c84-d9ab2b5652fb", "AQAAAAEAACcQAAAAEKRZHiREuEzvOyiv5t35GTlwzVUQQ1GEmWq+wFj47cMLldBxRo0mZkD3J3sdtuwyrg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f80eb8e2-9fee-480a-923e-61de8ce316bf", "AQAAAAEAACcQAAAAEJGfH5WxTNVlyj+TL0pjpyGyYv//mbV8H4kiYeV+0NCCkgEnZ5djL9BEiaFr20BP9g==" });
        }
    }
}
