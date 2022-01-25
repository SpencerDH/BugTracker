using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ce06fa4e-693d-47c8-87c4-e0f5312f8324");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "66bc8e90-4d31-4290-bb76-c8889a3042d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebe985f2-24a7-4f30-b5b5-bf7f27216ee0", "AQAAAAEAACcQAAAAEIEw3Q4gebLetaDffwqnpgt8kdyUUM/CAQkAZKUIUZGZQBUKtaZ4V2AUdJaQjUZfCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d222c164-2a0e-4350-9c60-90e9e6769f31", "AQAAAAEAACcQAAAAEIB55SoDLKAVa04pVqVd3RX5hDMRu0ixyiLLfiKc+ZEwKQv51w1OUM3hqaKIiaflKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9edd2f96-3f2a-4be2-a82d-6051164ba096", "AQAAAAEAACcQAAAAEIk+Sal7QMDDy0JpyPP8v6W/wVRLQ42BNoDqNs2WzkVNpZv/MTC1s+NI8IL+T0u0vw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
