using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class TryingtogetUserRoleseeded : Migration
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
                value: "9f11902c-77b7-48ca-907a-661a8d8e629f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "71d9a372-aac9-457a-8cee-fcf67053d920");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { 4, 3, "UserRole" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dc50ee6-8849-433b-9f75-b1ba30bbb65d", "AQAAAAEAACcQAAAAEOBks7Uw9i/QQhEJwKap9qrEitg9rSkfxvZmH38LzyBEHE90BwlGbcoxJXkpavpbMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58c8ed1b-82aa-4730-b5d6-293cfcb50a77", "AQAAAAEAACcQAAAAEEBuExX3cwJO6KIj2yFakx7dEz0Mn794gnrHSp8Aks9L607Nvh14bImwkfsVDSvUpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28a27a9d-a99f-4fc2-bdff-2f90c23d7a46", "AQAAAAEAACcQAAAAEBGexbip6Ft6Aj2TG8KDMuSG0S7A0C6wv79s482hrllskVccYnaU74yiMGn6OXNgsw==" });
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
                value: "22fef099-d949-475f-8075-0e26804e33fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "648f055e-aa41-4836-8372-5238e56e7f1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88ef82d2-e26d-4a80-8b49-11e532784d91", "AQAAAAEAACcQAAAAEECFRMFsr6fg1tyelzL22zZQzDL2n4sZ21ujhtPoll3mLRVsWNPgVoiU00GfsKdHiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab82e35f-77af-45d6-b0db-971563cfb30a", "AQAAAAEAACcQAAAAEEBLS0zLR6Guo7O9/lJK2pbmIiUWv0PmJI9Zq4z1LPt6igDarUqMBmm2nf5oCJhGmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9762b7b-94c2-4330-a3bf-cf4cae2e7da9", "AQAAAAEAACcQAAAAEIhcQz9n90hFZ6D8xABiHdGLBqXChiZc7RPMhPqG7CNXukaAGihdGo7LcOa/2ZgMQw==" });
        }
    }
}
