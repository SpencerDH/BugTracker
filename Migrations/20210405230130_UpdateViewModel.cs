using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdateViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "4cc2e472-08d2-49cf-be89-6603d2ef9b08");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "6999e0b5-75bc-40b0-9253-ad8a1cbd02a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e2ed140-94fd-45e0-ad5d-64088dc5c516", "AQAAAAEAACcQAAAAEOeImRKIX+KagdzhI3z0wsRnbSKaRuaop+WPOkZ4atZIVujz11MzAIJ2lOd43yT9og==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe921846-c9b0-48b4-9b7c-11cd87628087", "AQAAAAEAACcQAAAAECbwoMryPf536VDaUL15Eux1HDlP4K7Hse1edXI0LDMEskHoNNLnR40vJ92daeIVtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c7ae87b-3883-418b-ab2e-efdd47d14d11", "AQAAAAEAACcQAAAAECrHwpZwkNN5sYddqvE/a3ClgXHYytTRihlzF1lo8SfDbs13q/9WuI2ReBiopWo7oQ==" });
        }
    }
}
