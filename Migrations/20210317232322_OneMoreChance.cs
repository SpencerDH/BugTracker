using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class OneMoreChance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserIssues",
                columns: table => new
                {
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    IssueID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIssues", x => new { x.AppUserID, x.IssueID });
                    table.ForeignKey(
                        name: "FK_UserIssues_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserIssues_Issues_IssueID",
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
                value: "56673bac-a172-4c4d-84a1-1b2f4284cbbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "64f39617-b019-4c1e-8d28-0d8727c263cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a95c5eb-9675-45a1-9e23-136787c65f24", "AQAAAAEAACcQAAAAEDtAJeSRHfJ59dI65wNxEzKrrYmDgkB6rV+gsvcNl9U/Ii4CgLjrCpq5+Ic+zH8veg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0c2f3c8-9715-422b-b8ed-713fe5534209", "AQAAAAEAACcQAAAAEBqFIgAcGWwbtWsoZpJwIzFQZtaz8zM7V2yIjAJbUlJePA8NsCjzNEmcn69s60pGrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68eb6619-cb0c-41a5-b9ec-a04862ed651c", "AQAAAAEAACcQAAAAEPsgVquNxqpBEHV56iToK/Fc2QsVYzGVQnMbWh1PssT4mYp0pEMWgZRXbVNuWygxXQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserIssues_IssueID",
                table: "UserIssues",
                column: "IssueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserIssues");

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
        }
    }
}
