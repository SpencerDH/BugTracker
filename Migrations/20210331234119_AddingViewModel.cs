using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddingViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ecef021c-2d03-4960-9489-efa30c50a402");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "a175757c-51df-477b-b50a-0d294333c548");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a974e36d-c389-47ed-ac96-ebe922488310", "AQAAAAEAACcQAAAAEE6BzDwXL3IQXpEEb+4DBQG0C2gEQib7+vPoYe82Pow5DkQURWVHB7U4exhVMJmnlg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44cfffbd-8dcf-4c9f-8aa5-5a2edb789a7a", "AQAAAAEAACcQAAAAEA2jREUY6O1PCf7vytseDMFeu86+6WLq7kHtacc+15uYsKyDjhetUiNCcb7/K1Foog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe5b59d0-0c30-42d3-a340-ecf9bb67efdb", "AQAAAAEAACcQAAAAEJScj6983x2hvx7pcaEKXSyoWTJXi1g0b2/e4nNz1VpkbJvRJdpNJpNc8dEh16sYaw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "28ad0593-a53d-458e-acb5-c94775d40502");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "664f2543-1ec9-494f-9989-2e876ea00e27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfa0764a-72fb-4941-b17d-60bc4763caaf", "AQAAAAEAACcQAAAAEEfV/OtJ5xcwsmcxwI7Wsb8WYHcLh9kd5ei6r0bL32DjOaTROI/nOO+NJXHbrPpKDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26f4e8eb-5a2c-4a72-b4a3-c10d9c02c964", "AQAAAAEAACcQAAAAEN3aYRUtIqkctQSsfrcbmgprsrJoO6EUDysbr1geH7cb0mp+10EdeDoCz4Q5+oSang==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "905e1660-ecc9-49d8-8fa4-f6a85e7869a1", "AQAAAAEAACcQAAAAEDMCAMNtmSJIXPE47AmX3omIbZMc4RFNrgpWW1zizYWj0wYy6Xl9UDFvm5TiGBOOUA==" });
        }
    }
}
