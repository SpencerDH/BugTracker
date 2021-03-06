using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddIssueComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssueComment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueComment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IssueComment_Issues_IssueID",
                        column: x => x.IssueID,
                        principalTable: "Issues",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_IssueComment_IssueID",
                table: "IssueComment",
                column: "IssueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssueComment");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e159bc20-41eb-4c15-bb72-c6339362fe56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "38b59c77-76c2-4121-8ff3-e711a95b91d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd746188-6539-4907-9458-948690e07602", "AQAAAAEAACcQAAAAEBI+rsXFXsNBz2A0LPvotx9G9ZEmftdSSrcXa5tMxUrCJvUmS4tqbbBgvQQ0N0rpZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f5f5b2d-08d8-473b-83c4-5101843b2bbb", "AQAAAAEAACcQAAAAEIx1mrAgvbp6rTsAmLvBWQEhwBNIiWFz5u3OLk4BxEnRqRbxirdtHfQBF2K9MReUqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7be6bb9c-4105-4996-9b6e-434dc2941d92", "AQAAAAEAACcQAAAAEL+ALqSSt59oH6kTnagnauSJyE1JCEx5xaK4VjUUh0ZltJiYuGUPQnQcfZVelznBhw==" });
        }
    }
}
