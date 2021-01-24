using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class Addmyaccounttoadministratorrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "1d8cb543-2637-43eb-ad55-2906c7a33368");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "10bc92c1-65c9-43b8-a2d8-efdad0ed8845");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { 4, 3, "UserRole" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e16d50c-1d7f-4d04-810f-50128dd005f3", "AQAAAAEAACcQAAAAED2+1CqEqGjMwK4nK/OfnCt5CSwWnPr4fJc4dNsy2X6U9eQZDzuMajtRnpcuzcNOsQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2869bf95-4533-495f-ad83-afb5ddf94ce8", "AQAAAAEAACcQAAAAEG+H2WJyK8xVAxzVDRGZ8Lxm+5Zni3m3oGY1oSBuvjkV1qksuxwbjLEI2e1x1BBDjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d517a032-1977-44d4-a39c-7a74283c08f6", "AQAAAAEAACcQAAAAECiU//BB9B9UfVP9GyMhw8ceOtzO+B5+acooZNLdcfBAkDIf438cTjEgz3brXLd5cA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "536d2f65-aa36-4bd8-8be7-6df6e9417351");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8a2014a2-1ee5-451d-b97c-8921ea6bd92f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53c196eb-2eda-49ee-8ec4-458bd155ee40", "AQAAAAEAACcQAAAAEPr1KDwGtJN+mBM507zuJ6l9QqH4L4IWreNKq0nD0JDRHVZebjXB28/KFkR/L+eZxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "529565f4-7c1d-4bde-84eb-2ed0dcfcebea", "AQAAAAEAACcQAAAAEG02sOyyp1ny7xW9yJ2SpooMXvGvvr242NoUSqaIf3B2OzptWSzo9T73pioM05fNYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f980609-ab3f-4980-ba2a-9a2ac381e821", "AQAAAAEAACcQAAAAEI98JQr4iFT7wSZwqVBxFkH6MiqPJZYPxBEop7tWNuGTqNp3H9v6WW0tA3MoWQTGwQ==" });
        }
    }
}
