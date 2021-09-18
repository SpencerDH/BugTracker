using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class ChangeTaskDisplayName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a9c25fd0-8ade-4226-821e-b1400db5b51f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "060956b7-26e4-4806-b7db-170f54aafe8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b13285d-d262-42de-b80a-ab48aa585625", "AQAAAAEAACcQAAAAEIrDu3Idn1VNqfPafhNb5phvOCmYeVZjlXZllULvT4h5G8jnJwTBzG1ma9WUo7m0nQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c95ec81-e70d-41cf-a985-453d299b8b55", "AQAAAAEAACcQAAAAEIFKMVKo9O9jMX9K70wiLB9nf0E16Qp9m8I56Y9tXDdFLA46D8V4SdHPRlKLWZminQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0e02997-66dd-4ce4-9d15-87523522b581", "AQAAAAEAACcQAAAAELYjMr2rGo860k29OzVnQ9TOgGylVQaH8ONK+ufTgYcRy/CImOYInxiNZa0nvzZbhw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "b0cacd4b-9988-4cb9-a5ef-207b8871bfbb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "32f0e9cf-d14e-481c-8d94-f01bf5e7eaf6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2c06b76-e693-41e7-8db0-737fc961a6e4", "AQAAAAEAACcQAAAAEHDsjzEe79D01bm1/vkfDuxRnDeSLl2vvo/lIeS1wtAYtDxXAGTG4OHu/krqnIM8Ig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b695d90b-43eb-4eb6-91ad-acc2608e75aa", "AQAAAAEAACcQAAAAEJCKtqdA+n8Zl36bWrLHu8eP5JcERIfLUWLqmKuKs06/E7jS2ndsmesXYSgU2ruiPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2ff1e5f-1240-451c-be12-d168e151d17b", "AQAAAAEAACcQAAAAELZKEE37LP/hcmpkE+T5C2ILNQsRkccgz+mAjv42z+Iy4osqseM7GgpLBvqgNQMrzA==" });
        }
    }
}
