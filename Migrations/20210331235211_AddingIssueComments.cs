using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddingIssueComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IssueComment_AspNetUsers_AppUserId",
                table: "IssueComment");

            migrationBuilder.DropForeignKey(
                name: "FK_IssueComment_Issues_IssueID",
                table: "IssueComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IssueComment",
                table: "IssueComment");

            migrationBuilder.RenameTable(
                name: "IssueComment",
                newName: "IssueComments");

            migrationBuilder.RenameIndex(
                name: "IX_IssueComment_IssueID",
                table: "IssueComments",
                newName: "IX_IssueComments_IssueID");

            migrationBuilder.RenameIndex(
                name: "IX_IssueComment_AppUserId",
                table: "IssueComments",
                newName: "IX_IssueComments_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IssueComments",
                table: "IssueComments",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "42ee940e-a197-4f0f-9f6f-65fd75f1dc0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "314bff69-628d-47a0-b471-af9c5b56a6e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a567cd7-3c0b-4d93-bc3b-e0fa1c20354f", "AQAAAAEAACcQAAAAEGRc3QdDsgkDo5Ga41rvHecaEObJ0VuhIlLOr7Pgq5HHYeH2XX89+fqlI3AGSQAMSA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc471fe0-d5cb-42a5-9b91-3aa6353bd5e1", "AQAAAAEAACcQAAAAEOA/MpoBAH2grC2GEfgzY9E4/8ljLRt7aQtPMqRRggAJH1UVp7gkIR5Ug+nSmVmGxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d50826e-bc22-409e-b791-7c1c2a71bb8f", "AQAAAAEAACcQAAAAEBQke/uK9XqU4J7HkBBHlSSxAOAJpXXzfkfva4dxz77m5+1IZh7w0Cu8+Rt7nGNlfg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_IssueComments_AspNetUsers_AppUserId",
                table: "IssueComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IssueComments_Issues_IssueID",
                table: "IssueComments",
                column: "IssueID",
                principalTable: "Issues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IssueComments_AspNetUsers_AppUserId",
                table: "IssueComments");

            migrationBuilder.DropForeignKey(
                name: "FK_IssueComments_Issues_IssueID",
                table: "IssueComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IssueComments",
                table: "IssueComments");

            migrationBuilder.RenameTable(
                name: "IssueComments",
                newName: "IssueComment");

            migrationBuilder.RenameIndex(
                name: "IX_IssueComments_IssueID",
                table: "IssueComment",
                newName: "IX_IssueComment_IssueID");

            migrationBuilder.RenameIndex(
                name: "IX_IssueComments_AppUserId",
                table: "IssueComment",
                newName: "IX_IssueComment_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IssueComment",
                table: "IssueComment",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ecef021c-2d03-4960-9489-efa30c50a402");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a175757c-51df-477b-b50a-0d294333c548");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a974e36d-c389-47ed-ac96-ebe922488310", "AQAAAAEAACcQAAAAEE6BzDwXL3IQXpEEb+4DBQG0C2gEQib7+vPoYe82Pow5DkQURWVHB7U4exhVMJmnlg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44cfffbd-8dcf-4c9f-8aa5-5a2edb789a7a", "AQAAAAEAACcQAAAAEA2jREUY6O1PCf7vytseDMFeu86+6WLq7kHtacc+15uYsKyDjhetUiNCcb7/K1Foog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe5b59d0-0c30-42d3-a340-ecf9bb67efdb", "AQAAAAEAACcQAAAAEJScj6983x2hvx7pcaEKXSyoWTJXi1g0b2/e4nNz1VpkbJvRJdpNJpNc8dEh16sYaw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_IssueComment_AspNetUsers_AppUserId",
                table: "IssueComment",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IssueComment_Issues_IssueID",
                table: "IssueComment",
                column: "IssueID",
                principalTable: "Issues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
