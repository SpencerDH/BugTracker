using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class TryingtofixAppRolestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "391167fb-d0cf-4cec-81db-4ba3cdbfb6ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "773f4cc5-51dd-43fa-9d38-8ecb0afd77f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef20f4d0-3da1-4214-afb2-d95c850347da", "AQAAAAEAACcQAAAAEDdxVhbuVItHJiyPO2yETX2KV3FQI5xC82rWZWfTaYbi83haZToKKM2tRr6ltXPYwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16745fe6-9719-4962-a35f-361064209fb8", "AQAAAAEAACcQAAAAEC5Y40mtEOtkhB1LtvvcoFMvBAtoA+86Wd4XbFPAi4rTS9Zq+BSAbTDK4TiXvyRjDw==" });
        }
    }
}
