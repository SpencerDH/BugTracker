using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class CreatedDateInIssueComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "IssueComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "IssueComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "3c36bb75-c150-41db-823f-7fdd92a495fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "80545179-cd20-40e6-9399-0b60b7007d46");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f75184b-0f87-45d4-bb4a-cd1d1cb13ddb", "AQAAAAEAACcQAAAAEEl73zqqdt7ECbEapjHudZQrlsCru0Uhyi7kL9QoQ4sTZ1r/FsRXe+UvO+hYAT1zmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b468e90-d1e5-475a-aea4-ba14deca7d41", "AQAAAAEAACcQAAAAEGtwiwZutYaoC7/fK3Jw8FLltTyC7deU8408zW2HQLtqZfUPY3Mod49JKupjxdsJ3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d829091-05a8-4a1f-8830-a4e5d414c839", "AQAAAAEAACcQAAAAEGvFeZ2YqFJyMPbfo/pn2dSEe+vIAAsl8KBTWJGIlQZkZeGQiN9brfw93d9l4rrZnA==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "IssueComment");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "21342889-e033-4892-bc79-e02066d1a65b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d0a41c54-8191-4624-9ffb-9b15193be687");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79b28e41-27a0-472d-96f2-e0d7158b4e7c", "AQAAAAEAACcQAAAAEDgxrUNdczexGTfyyK63fsf8CrwwUDiM87/XVInqxeI/aVRsx58KO3vfxKxreNop2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34354dbe-5b7d-41b4-a039-0846f2963732", "AQAAAAEAACcQAAAAEGIZjwz9RYUVnxtOSh3C0BXq/ReuR8hHiFde10mKRbSU+84RrZ4tDvI3uYKh3jWXHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfcff94c-bb1f-4d0a-ad76-6b0c0bd5f59f", "AQAAAAEAACcQAAAAEDgN///CQzsR2lhVyQr2KDlLo8kOGu9akTUIgCA17ZYmPj7ke0UROtyd8BZ9gQwAig==" });
        }
    }
}
