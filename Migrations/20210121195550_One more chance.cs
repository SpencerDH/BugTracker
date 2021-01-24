using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class Onemorechance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b9260a4e-69dd-45e9-9b8c-9f2097e449c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "584ec19c-cff5-44f2-887a-05d5e56e71d8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23fe7a53-2a49-4592-a27f-84ae2747a067", "AQAAAAEAACcQAAAAEBlFoJYtzk6fPZbc2h+VUOobkYuTa1+QpA5ppQ8MTP/VJoSzd5TGdPtG9idwBl69dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7142a107-5f49-41b6-acd7-c4074bdc67ee", "AQAAAAEAACcQAAAAEFywtIGDVQDj2EO86Iju4Umr1xlIKnVAgClpiXXiA4MrNch2qmaoTnXzhO1gegdhmA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "815b677d-ccad-4f6a-93fb-b08902b4f6ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "42ac0d4a-734f-40f5-9d28-f4813a811f4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ddce1516-f54e-4567-8632-a2d470153e69", "AQAAAAEAACcQAAAAELPsqdq2pGrYlYP1s5oKX9GvM+yh5JwNpR8mo4kcvARgEEdoQyzg2reatOLppeK79Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ed1cf1b-62c5-49e4-945b-59baaf4fa853", "AQAAAAEAACcQAAAAEBd+8HE+t/hZdVe87oX7Kz0hzic0OZdrmicSMQGFk/Lyjm3kFmyNLHuE2FRql1kxRQ==" });
        }
    }
}
