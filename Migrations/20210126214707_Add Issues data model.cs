using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddIssuesdatamodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    ProjectTaskID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Issues_ProjectTasks_ProjectTaskID",
                        column: x => x.ProjectTaskID,
                        principalTable: "ProjectTasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9c8dc949-e061-4019-826a-55581bdbd7a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8d319af8-e807-4500-99d0-a6414a6f0203");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06ae258e-3025-4a82-bc26-13ed06e6c9c4", "AQAAAAEAACcQAAAAEDsx+sS5FLQki6hL6so5HH7Il/XKRKVhz+LPYmsXVFZ/Y3+H9Fj8JrxI9ABqrTD94g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4edd2b92-bfd3-427f-bfec-1bbb45d8ad04", "AQAAAAEAACcQAAAAEOG36WEtUm66X3XXx8XcsK7zYE8opa56l4WTCtEmkrVEX7M2m2kMJPwqep4rxxttEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec6efd50-6562-4637-84bd-76fd3a9635cd", "AQAAAAEAACcQAAAAEN6sQHHwRrIp2Sl+1++3D88cfGEEULv+QTQR5hWXAoVUY5SyYsUsMuw6c444jpV8kg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Issues_ProjectTaskID",
                table: "Issues",
                column: "ProjectTaskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issues");

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
    }
}
