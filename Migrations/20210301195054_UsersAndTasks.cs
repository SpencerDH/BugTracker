using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UsersAndTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUserProjectTask",
                columns: table => new
                {
                    AppUsersId = table.Column<int>(type: "int", nullable: false),
                    ProjectTasksID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserProjectTask", x => new { x.AppUsersId, x.ProjectTasksID });
                    table.ForeignKey(
                        name: "FK_AppUserProjectTask_AspNetUsers_AppUsersId",
                        column: x => x.AppUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserProjectTask_ProjectTasks_ProjectTasksID",
                        column: x => x.ProjectTasksID,
                        principalTable: "ProjectTasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "f59b8ee4-fdd5-4f04-bffd-06f4c2f9f617");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "eee59c97-6a85-40d0-930e-d3f68465d842");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55e46c4b-8545-4e56-8075-059ee3008589", "AQAAAAEAACcQAAAAEA1N5UE1kJy72Rf6W6lmCEjY7HUlYYVJsm2FVNBwPoc5IiFX7OaeEKzNDbs60/Z8OA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9317bd34-b311-4497-bd06-b5eb9579725e", "AQAAAAEAACcQAAAAEFLqXl1aCgVPIgdYbUoX98sQ/ZYWr6JvkNyzYMUB7wqBJCGA2kompGxMFBspWA41ww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "217ac4da-3928-4262-950d-a8c4e5daf9bd", "AQAAAAEAACcQAAAAEMn1VAk++LlGLUHqSxsFgzExaAuv7aP7lBFG4hlsQkrDUG+rulH/vwSksG6ACQDhng==" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserProjectTask_ProjectTasksID",
                table: "AppUserProjectTask",
                column: "ProjectTasksID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserProjectTask");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "16a336bd-6ce2-4e95-a713-62221ed966ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "02f209f8-841d-4b3b-becb-c454e5dd3ddc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff8c9b7b-d3e2-4e67-9247-e7c5140e07cf", "AQAAAAEAACcQAAAAEEKcZimoaFoBQxUrHBFUMuSbyIhqFZ2U1Lpt6VGylyEZJcaEC52ftTrxUnwRNk1dwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2831b009-e135-4daa-8245-1e1479342fe6", "AQAAAAEAACcQAAAAEIThsSu7tp4TSkACvUfts57zth9CzdQRBykerMS2eKkYk9CRE/kgigoBLtOOFVa6yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10d12aec-c4ed-4682-9723-9d4fc74177fc", "AQAAAAEAACcQAAAAEEvwI9LhxGojG0G3P7ADYypl5TA1MuEYyFnV/MadrUF0hC9Tt5S6K62lG+MEr5m3+A==" });
        }
    }
}
