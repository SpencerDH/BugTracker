using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class RemoveBugPagesfromdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BugPages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "cb262032-151e-44b5-8d03-19671453f094");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "b8e1d54f-0df5-42fc-bb18-e44274009b62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2ffdd20-4021-4ba9-85da-434ec25086dd", "AQAAAAEAACcQAAAAEAvYg/JFDBv0XbOP4H4sWSAjFj9Mcf5EympmRzTnUXlkNnvR08UuWeelJK6p9q6Zow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb0c6966-4ee9-498c-a7c3-794844003a83", "AQAAAAEAACcQAAAAED9Qhk8apa3bi+gss6ge4ZdLYjvqHWKKOJ+l/0InYxD2OdY9EpyadM6ddi6t81nngw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a2bb5d9-fa13-4efd-a318-9b57bbc8d191", "AQAAAAEAACcQAAAAEFPIZfKbQzmICrqnARydc6OzVs3W6Ovtm0Sw6AdA8Ghkb4lbJS7sS+F87WPD34IDmw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BugPages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectTaskID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugPages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BugPages_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BugPages_ProjectTasks_ProjectTaskID",
                        column: x => x.ProjectTaskID,
                        principalTable: "ProjectTasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "578c0d7d-0621-4b4b-bd9a-2707287ae1f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d59ed6f9-7835-4b93-9ed0-caf4e10b4e51");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5241038-417c-4e87-a456-92d44a99131d", "AQAAAAEAACcQAAAAEB4D7rzRBrv7vGFfB2hsFR3g/w0c6kbm5OXt9Rk4JpDfFWyPD4WgLPJxbPkK4Zxuag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f9157e9-e902-4b43-8beb-4785b272fc80", "AQAAAAEAACcQAAAAEO0yFb2kJjV7XJxIo7QpPwaA254VzZ/erEUHdfNqe6W7dEmMgFR0x50rgoikIDCAxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f1f1d36-03ab-4b3b-963d-fa2313abb182", "AQAAAAEAACcQAAAAEDAvR1upSJuJc5DC+xlX3KdQ7dcjj/3RGhSzfwxodbarf80Bb6az4MV8gsHeh2y71Q==" });

            migrationBuilder.CreateIndex(
                name: "IX_BugPages_ProjectID",
                table: "BugPages",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_BugPages_ProjectTaskID",
                table: "BugPages",
                column: "ProjectTaskID");
        }
    }
}
