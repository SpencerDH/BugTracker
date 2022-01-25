using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class UpdateRecentIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "2f9b6eb1-b841-4945-9407-e6cc73de23d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "435c5f8b-88f4-4603-9364-46bd45d27fe9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb97c870-211f-40ab-a152-7b61d6213708", "AQAAAAEAACcQAAAAEB9WPZ9zFBNPeTiVUC5xaRUckfqd4XVNVT2UTIPdkSI7QuRJVEKQ1JV8dOcWoPIBpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a983c23-7ced-476c-9828-b93807b2abed", "AQAAAAEAACcQAAAAELxSxw2cwmvqShrGWoWzKDqWcANmujREyI8McGIuOM6usD++YdgTGrTUp3i/jhcC9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37af05f0-e083-403c-9c0a-eb77fd16ae44", "AQAAAAEAACcQAAAAELJyGdbi9hYCGHnqy/6c24O0bzNfi2LeTgILCZ9K8aO13rRAyXnS4oO8L9Kkxi/GGQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
