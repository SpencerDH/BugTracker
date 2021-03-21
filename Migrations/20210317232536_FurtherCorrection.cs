using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class FurtherCorrection : Migration
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
                value: "59de5427-4b6b-421b-aa93-4d3636b526ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4d4ae16e-2050-4ded-852b-3333a68eb51f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5cb5349-8336-4dec-86e9-89e15eca11e3", "AQAAAAEAACcQAAAAECPJxQXggKj8GjGoATU84TyoY0Dn/ThReUAbD9ba2SCnNFBSeKAcBF+LpKSQblyi5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ec2a310-0b09-4b52-9047-6871eb4bf9c5", "AQAAAAEAACcQAAAAEN9l1HJYAUEcs19mCHyiczQr0jZJAYnasC7HvUv0UurTNsIa6HjSE1oK+LbusfMIyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbba527a-8c5b-4311-8605-e6a82e37dbf0", "AQAAAAEAACcQAAAAEE6bmMMticjlcJu3gedUX+NOm3tVEjW1rzXiOVMbjoBJbJ5Of9AeXqcCyEFtyXVEdg==" });
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
                name: "IX_AppUserIssue_IssuesID",
                table: "AppUserIssue",
                column: "IssuesID");
        }
    }
}
