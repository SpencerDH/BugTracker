using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class BTSOOYifthisdoesntwork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c2cbc0d0-45bb-4954-b7c2-8190692de4c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b0a977c4-9d66-440c-8538-051eb8485402");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "9d4e19c1-1ab5-4e66-823d-3b726b7deb82", null, false, "Josh", "Maddox", false, null, null, null, "AQAAAAEAACcQAAAAENwhgb6IbMbjYVXCQn6K1uh4cT5SO5HLVIMrMuGI13wHTDY94Hb6yjvyEdm28iVp2w==", null, false, null, false, "JoshFM" },
                    { 2, 0, "e0bc0ced-b1da-407f-98bf-1b15fc1eb94b", null, false, "Lauren", "Ackleh", false, null, null, null, "AQAAAAEAACcQAAAAEMqSBltAKWCanOvacfYjY2cC5JD0ZcIaHeX9SOYvMrm2S8ukvIgZi1Co3cAJhclNiA==", null, false, null, false, "LaurenGA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0af723e2-e057-4b15-bc64-b4f8ee1cb33d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "060cea5f-fb7f-4cd5-9935-414f687b015d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 3, 0, "aaa433eb-d8c8-499c-a1f2-81d9e0c95053", null, false, "Josh", "Maddox", false, null, null, null, null, null, false, null, false, "JoshFM" },
                    { 4, 0, "7ddee749-9bc5-4b18-939d-f8410f830950", null, false, "Lauren", "Ackleh", false, null, null, null, null, null, false, null, false, "LaurenGA" }
                });
        }
    }
}
