using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddUserRoletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e8e8b183-9e76-4e4c-9a43-d8087249002f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "45449ebe-be48-4dc8-913c-10c7c50ba75d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09f5bbbe-c306-46ba-80b5-3a7c792cde53", "AQAAAAEAACcQAAAAEI1jByh+AwXDEFfRJRzjL3Anore4xAx/EgXamsfOuYPvv+QifbFkLvHi7JmSBU5d/Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "661a0342-9ffd-4ff8-8ccd-f610823586cc", "AQAAAAEAACcQAAAAELGQHD5WVFAQ/SqJ7TQN4/T1+ApRTIN6wSOLLlsnCOD3XTcR55SuL6TxWRM6Hz499Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d4e19c1-1ab5-4e66-823d-3b726b7deb82", "AQAAAAEAACcQAAAAENwhgb6IbMbjYVXCQn6K1uh4cT5SO5HLVIMrMuGI13wHTDY94Hb6yjvyEdm28iVp2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0bc0ced-b1da-407f-98bf-1b15fc1eb94b", "AQAAAAEAACcQAAAAEMqSBltAKWCanOvacfYjY2cC5JD0ZcIaHeX9SOYvMrm2S8ukvIgZi1Co3cAJhclNiA==" });
        }
    }
}
