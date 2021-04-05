using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdatingViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "42ee940e-a197-4f0f-9f6f-65fd75f1dc0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "314bff69-628d-47a0-b471-af9c5b56a6e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a567cd7-3c0b-4d93-bc3b-e0fa1c20354f", "AQAAAAEAACcQAAAAEGRc3QdDsgkDo5Ga41rvHecaEObJ0VuhIlLOr7Pgq5HHYeH2XX89+fqlI3AGSQAMSA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc471fe0-d5cb-42a5-9b91-3aa6353bd5e1", "AQAAAAEAACcQAAAAEOA/MpoBAH2grC2GEfgzY9E4/8ljLRt7aQtPMqRRggAJH1UVp7gkIR5Ug+nSmVmGxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d50826e-bc22-409e-b791-7c1c2a71bb8f", "AQAAAAEAACcQAAAAEBQke/uK9XqU4J7HkBBHlSSxAOAJpXXzfkfva4dxz77m5+1IZh7w0Cu8+Rt7nGNlfg==" });
        }
    }
}
