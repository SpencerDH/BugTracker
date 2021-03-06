using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class DateToIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e159bc20-41eb-4c15-bb72-c6339362fe56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "38b59c77-76c2-4121-8ff3-e711a95b91d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd746188-6539-4907-9458-948690e07602", "AQAAAAEAACcQAAAAEBI+rsXFXsNBz2A0LPvotx9G9ZEmftdSSrcXa5tMxUrCJvUmS4tqbbBgvQQ0N0rpZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f5f5b2d-08d8-473b-83c4-5101843b2bbb", "AQAAAAEAACcQAAAAEIx1mrAgvbp6rTsAmLvBWQEhwBNIiWFz5u3OLk4BxEnRqRbxirdtHfQBF2K9MReUqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7be6bb9c-4105-4996-9b6e-434dc2941d92", "AQAAAAEAACcQAAAAEL+ALqSSt59oH6kTnagnauSJyE1JCEx5xaK4VjUUh0ZltJiYuGUPQnQcfZVelznBhw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Issues");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "23451bd4-5be8-45f8-9864-5d2e96e0a38a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8f9fbe55-4077-4d71-98d6-f946d7b4e7d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "642166f3-2e4d-4c93-9118-b43f10ff103d", "AQAAAAEAACcQAAAAEK8XFanD9ysVRQvxSCblhDdmkZaukUWGVA15K469rMHCXpuQpGHJXzvzxG3uJKfbZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86f9e8d1-a9a2-4781-9324-d737f541a836", "AQAAAAEAACcQAAAAEOPJ+mx1ZhM9DbpmJtU02LJHzaE2so3GST+2KySC4ZdUAWhjsQ8TlifysOcycvt81Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31c8caa1-b138-4ffa-a12f-2215fd88f750", "AQAAAAEAACcQAAAAECsKeM6/EhxHIvPt5190AWvqMQDgvIeK+aBl7XA8lXqtNOL5LALokmofHE+bzfM6jQ==" });
        }
    }
}
