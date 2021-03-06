using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class removingappusersfromprojecttasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
