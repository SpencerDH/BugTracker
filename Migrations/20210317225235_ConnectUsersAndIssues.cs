using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class ConnectUsersAndIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "40975571-e8c6-4f15-92c5-b2a0e72a2a19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "9f434f69-f1f2-4296-9027-ef6eb33e745d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2139873a-52be-4407-80aa-d7d361a5c28b", "AQAAAAEAACcQAAAAEKVJJNYNwQfSlDqW+ihwX3EeA+F/CJ45kvd6p9WfVW92Ys9yU2tfVjXUf8YjRCn27w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f3ec9ff-d67f-47a0-a09e-e2c079614ac3", "AQAAAAEAACcQAAAAEK0WQhfmff1iFz8ValnCPkCFwSUowz0LSAXMGeYObBClyiWT8ORb+02UZy6YT6+urg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9956aa47-8cf9-4540-a004-4128b5bf24b2", "AQAAAAEAACcQAAAAELN6OON7HIHvOJt4bfA1lwW9mySvDWhnHg/c4iUgHiiUQ8XtRaBRSwNY2nGsHFJXvA==" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserIssue_IssuesID",
                table: "AppUserIssue",
                column: "IssuesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserIssue");

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
    }
}
