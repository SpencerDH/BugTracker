using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdatingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "862f0df9-ba82-4bf5-81e3-0c1cf1cf4d85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "df061672-ae0e-466c-92ae-5d776aa438d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ade87af9-59e1-44cf-9e2e-702e7d049251", "AQAAAAEAACcQAAAAELg2iVE9hYUJl7c/Od3MYrao35B6DbPVPZJTkxXUxSRYuyK1SY9p38uAf8npQxW/Dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dde261dc-bcc0-4463-8c84-d9ab2b5652fb", "AQAAAAEAACcQAAAAEKRZHiREuEzvOyiv5t35GTlwzVUQQ1GEmWq+wFj47cMLldBxRo0mZkD3J3sdtuwyrg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f80eb8e2-9fee-480a-923e-61de8ce316bf", "AQAAAAEAACcQAAAAEJGfH5WxTNVlyj+TL0pjpyGyYv//mbV8H4kiYeV+0NCCkgEnZ5djL9BEiaFr20BP9g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "36d6e082-c887-49e3-a7f7-93fb00f92094");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "f68b9759-4584-4850-8638-3b560a135cac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be83f5d7-a981-4ec9-9119-0c40c1362598", "AQAAAAEAACcQAAAAEAdxf4T/ko0ike8PaV/rrcp8J7vG96xwcc6nq0fFH3itxE4dCH1jtIcL2iM2j1Bq5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55909399-a6b3-4fdd-be33-57209e7aa54b", "AQAAAAEAACcQAAAAENJNyL8tioANSwtJcMfuYo1sUDT4x9yjlvuYAgIJ8mgj2RFc01NoDeJdSiNgOGP7Hg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c14a64ae-f945-4a35-a76e-1e6642978dac", "AQAAAAEAACcQAAAAEL6UJUSPwIZhhoMISWplGDWYFH0Ltu73SEBWTwwa5xv+8cjvr1h9ZC7wKDrnzGWv6g==" });
        }
    }
}
