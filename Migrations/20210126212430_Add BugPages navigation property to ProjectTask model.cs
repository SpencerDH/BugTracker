using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddBugPagesnavigationpropertytoProjectTaskmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectID",
                table: "ProjectTasks");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectID",
                table: "ProjectTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectID",
                table: "ProjectTasks",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectID",
                table: "ProjectTasks");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectID",
                table: "ProjectTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTasks_Projects_ProjectID",
                table: "ProjectTasks",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
