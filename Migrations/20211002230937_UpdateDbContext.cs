using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdateDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserViewedIssue_AspNetUsers_AppUserId",
                table: "AppUserViewedIssue");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserViewedIssue_Issues_IssueID",
                table: "AppUserViewedIssue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserViewedIssue",
                table: "AppUserViewedIssue");

            migrationBuilder.RenameTable(
                name: "AppUserViewedIssue",
                newName: "AppUserViewedIssues");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserViewedIssue_IssueID",
                table: "AppUserViewedIssues",
                newName: "IX_AppUserViewedIssues_IssueID");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserViewedIssue_AppUserId",
                table: "AppUserViewedIssues",
                newName: "IX_AppUserViewedIssues_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserViewedIssues",
                table: "AppUserViewedIssues",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ce709480-93ce-479e-943c-3d2e4cbd3005");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "6c6d3bee-039d-4d4e-a367-4a8b2715f97b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dabbd1f4-50b4-4f36-a467-c4204e7d0328", "AQAAAAEAACcQAAAAEMhWhGvOv77wVK4I+ROeIDZaI2EtjWc+Hul5CbyNYe2BJyvkPUFwWCWHPTmpfDpH1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdbb87c0-4d33-4581-a276-0114807f7cce", "AQAAAAEAACcQAAAAEIwMp0m2OnBDMs6nkdd6C+KeUedV17a68KYP/caCcOlMRj3ncDGLAMyLJ53/yhslqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d8350b9-fb39-4d1c-bfc1-e2db43e2c79b", "AQAAAAEAACcQAAAAEIkT+bTpJ7aSJJ/D4yv24KzxPaXeX2I/VpgnfW/eBrddP+jgVRIyAsXUffKi2eU9Nw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserViewedIssues_AspNetUsers_AppUserId",
                table: "AppUserViewedIssues",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserViewedIssues_Issues_IssueID",
                table: "AppUserViewedIssues",
                column: "IssueID",
                principalTable: "Issues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserViewedIssues_AspNetUsers_AppUserId",
                table: "AppUserViewedIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserViewedIssues_Issues_IssueID",
                table: "AppUserViewedIssues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserViewedIssues",
                table: "AppUserViewedIssues");

            migrationBuilder.RenameTable(
                name: "AppUserViewedIssues",
                newName: "AppUserViewedIssue");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserViewedIssues_IssueID",
                table: "AppUserViewedIssue",
                newName: "IX_AppUserViewedIssue_IssueID");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserViewedIssues_AppUserId",
                table: "AppUserViewedIssue",
                newName: "IX_AppUserViewedIssue_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserViewedIssue",
                table: "AppUserViewedIssue",
                column: "ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserViewedIssue_AspNetUsers_AppUserId",
                table: "AppUserViewedIssue",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserViewedIssue_Issues_IssueID",
                table: "AppUserViewedIssue",
                column: "IssueID",
                principalTable: "Issues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
