using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddingProjectTasksmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectTaskID",
                table: "BugPages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "2a110bbe-92e7-4a30-ac60-44b712bee7aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "10d95c80-90d7-4b41-a75b-1c63883ecb9f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b84a865-04e3-47c6-8d53-0cf8958e8656", "AQAAAAEAACcQAAAAEDpgAY2lVENgc3uJmNvyd2ymoApp9Tmzwo9lHKVdfqSDzMjA9yPLyBKvaWIySC5B8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d6e49fc-857f-4ab8-919e-c734981ad550", "AQAAAAEAACcQAAAAEPsV9uMNhz1wVwVhf7lQA2Spu7do18xVQWutrVMim4Ms0E9zsTSdDP3uE9j3IGlx5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b820f50-aee8-4acc-8081-f5d8c7a628b2", "AQAAAAEAACcQAAAAECrtLpodZvO7C6hpN1TUqJXTUWuzTlsoQJNbLm6Sb+BUh+NrEIYiplL9ZOqKGmrdcg==" });

            migrationBuilder.CreateIndex(
                name: "IX_BugPages_ProjectTaskID",
                table: "BugPages",
                column: "ProjectTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_ProjectID",
                table: "ProjectTasks",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_BugPages_ProjectTasks_ProjectTaskID",
                table: "BugPages",
                column: "ProjectTaskID",
                principalTable: "ProjectTasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugPages_ProjectTasks_ProjectTaskID",
                table: "BugPages");

            migrationBuilder.DropTable(
                name: "ProjectTasks");

            migrationBuilder.DropIndex(
                name: "IX_BugPages_ProjectTaskID",
                table: "BugPages");

            migrationBuilder.DropColumn(
                name: "ProjectTaskID",
                table: "BugPages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9f11902c-77b7-48ca-907a-661a8d8e629f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "71d9a372-aac9-457a-8cee-fcf67053d920");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dc50ee6-8849-433b-9f75-b1ba30bbb65d", "AQAAAAEAACcQAAAAEOBks7Uw9i/QQhEJwKap9qrEitg9rSkfxvZmH38LzyBEHE90BwlGbcoxJXkpavpbMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58c8ed1b-82aa-4730-b5d6-293cfcb50a77", "AQAAAAEAACcQAAAAEEBuExX3cwJO6KIj2yFakx7dEz0Mn794gnrHSp8Aks9L607Nvh14bImwkfsVDSvUpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28a27a9d-a99f-4fc2-bdff-2f90c23d7a46", "AQAAAAEAACcQAAAAEBGexbip6Ft6Aj2TG8KDMuSG0S7A0C6wv79s482hrllskVccYnaU74yiMGn6OXNgsw==" });
        }
    }
}
