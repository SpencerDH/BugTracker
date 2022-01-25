using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class RecentlyViewedIssuesAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "7a23e3a6-e9b3-46a5-b99f-cd45b00695c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "7901b282-2d3e-4a18-b99f-e6b551d8748a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e495893-4458-413b-a721-db262bcd16a1", "AQAAAAEAACcQAAAAEKaseS7aUNJTbArqpfpb7H9rKg7FCDREhWi/VvCjyEcvMeYbppwXi/SSAbE81jBuJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f83a90f0-12ac-44ef-9c97-7da4d7b0936d", "AQAAAAEAACcQAAAAEIIrhp6uTISxmFsz7Qaum4iKmlisUWHHnWY1OyjaBv7AxxS0qIMgJXP6DdiOhiT5Qw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbaec05c-ee44-42d2-8003-c21c17b1372f", "AQAAAAEAACcQAAAAEFY/QpHgeDQkEmpgYRF2mvAsKaHoMey9UtabvHih9yn4CXJbRDjIfLaLwmUWD6yN+w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8eb9a9e2-a5e3-4ea2-b6db-23e3618263bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4a64f5b1-8971-4e4a-b0e1-a5381459c863");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f85ac2e-e6e5-4ce3-b953-e68649f1035a", "AQAAAAEAACcQAAAAEEnqoy0HxRoi+hjCVwJb4ekPpKKpt+t1feWaQfxqhYpf7PAUNIDP9wovHFQW5e4ufQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "221b9c97-769c-446a-8707-726b4326f0cb", "AQAAAAEAACcQAAAAEMLykReaCcT+B2NQ+C0Gb0icNwEPoouPFy9T6g51vZU6cKaHESJkOnHN2F+8idafgg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb7a38d8-5ee2-4d67-8cb1-b6c1eef60739", "AQAAAAEAACcQAAAAEGihZq0GvEpzLZoQGVYRomxuIr3gficf78rpUmqiUmmqDTqNISsPUIIj9Clfpt7EQw==" });
        }
    }
}
