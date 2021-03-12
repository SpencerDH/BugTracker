using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdateIssueComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IssueComment_AspNetUsers_AppUserID",
                table: "IssueComment");

            migrationBuilder.DropIndex(
                name: "IX_IssueComment_AppUserID",
                table: "IssueComment");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "IssueComment");

            migrationBuilder.AddColumn<string>(
                name: "UserCreated",
                table: "IssueComment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "accbdb24-51df-44f5-b738-7122a5b4c3df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8e9e1b0c-d198-442d-944f-523c0be27c75");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa971e07-b772-431c-bd57-bdadf0c662b9", "AQAAAAEAACcQAAAAEMCjFeLHOxypw6lYvbJ0EITR2wjn17jNNOzORZWaJM/5Q0d0KYmS9Te1D7JTZ2LoHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea9983ba-4663-4ab2-bb16-cdc2f0b53a4f", "AQAAAAEAACcQAAAAEI7y8Dv3BvQ5oRPiHXt5OhexxIUeCi/qqduy8z+dwHuD6YPzZUk7K4zDAoZ4RvRCFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67a36be7-8ae9-4109-9306-d751603684cb", "AQAAAAEAACcQAAAAEOyZuIBlmBN2a0Sx0owqFMxwcH+DcQQbHM5QS5zngUBgOsOJRgtsH9h3hzdP/gPhUw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCreated",
                table: "IssueComment");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "IssueComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_IssueComment_AppUserID",
                table: "IssueComment",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_IssueComment_AspNetUsers_AppUserID",
                table: "IssueComment",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
