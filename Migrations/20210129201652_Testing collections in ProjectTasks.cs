using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class TestingcollectionsinProjectTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Issues",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "ProjectTaskID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "15fb5bbc-2eed-4645-810a-391fe8ba905e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "fa1e6ee6-613c-4d7a-abd7-5dadd7cd12b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bdfc79d3-ab40-4550-9703-3e43016fff4a", "AQAAAAEAACcQAAAAEOYMQgP769B9W++1oB8ziUWS5TJJFPqMGkei0zsKJDiUahNOhv81rEp6tWwsIriS7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b55223a4-a6c8-440b-a9ea-ffbaee938270", "AQAAAAEAACcQAAAAEFypO0OY8gDhaxe6UWY8tdFK/ghXqJ5mzZN6QEUYQBxVwgyup4zyQpLFCc0duAWXFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c634eb91-534e-40cd-8e2d-5d4ef423e0c3", "AQAAAAEAACcQAAAAEJyEqV7dj5BI/Xp7xo/wx12Jp3UaBGA2DKZ+9/FWtyKfxOB7ibKqtRQxHEyTylDjpw==" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProjectTaskID",
                table: "AspNetUsers",
                column: "ProjectTaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ProjectTasks_ProjectTaskID",
                table: "AspNetUsers",
                column: "ProjectTaskID",
                principalTable: "ProjectTasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ProjectTasks_ProjectTaskID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProjectTaskID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProjectTaskID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Issues",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "dc8ebe78-0ba6-46a5-9bbb-fcef9c7d5499");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "165ea6e7-62b3-4e28-8ecb-a7b5873714af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3046da5-0f96-41c7-aabf-7fe7fc9cac0d", "AQAAAAEAACcQAAAAEExx83G1BCzVlBcGEtG6NxVM8iA4ffROUaD/Ua4cjacXGVCyyNm/xiQKmimk/y3PKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9395a0b5-c10a-4fb0-8ea4-b3aced2292f4", "AQAAAAEAACcQAAAAEOH+KQaMKlG8/dTQ1aaAe9WEPBtHOHd2qlzYl9CcsnctRjEYbG6N2UM23D4jk/aGVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3e1c6a5-f24a-4259-bb80-64a6b09bf6ef", "AQAAAAEAACcQAAAAEBPQKEZPEd8l3wEnt1GTy4drFBY6mR55MOmDz7DYLk0j7WN6BhYklMmo6NFYKMwUcg==" });
        }
    }
}
