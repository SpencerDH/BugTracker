using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class FixingUserIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e7592c7b-315c-49e6-82f7-b89f8480d179");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c21f0227-19f7-461c-9b4a-956107258eb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd9eeb2e-af41-438a-bc70-56afd1e6c94d", "AQAAAAEAACcQAAAAEFhxMfsS1KtxsOf8TA4rca7qPkAf2VfrPRpN6rYnfYgIPgX9v6PaiQLowLd2uUAVuA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c61a43fe-ae32-48ad-88b3-b7dbb04364c5", "AQAAAAEAACcQAAAAEDyRl+kq+bRRXRE2l8epi+RCQKqkAhevNWeiI/BC8WCn98KbDZ27+wUeUcQECTRMtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "907b8df1-dd27-4540-9d2a-f4bcb4123c16", "AQAAAAEAACcQAAAAEHSBt3TzXN5VRY7PtWIJNJktE6/RaO7H59fZ1/wDS9xgZtv9bo8CRctiF0r4ndwnsw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "59de5427-4b6b-421b-aa93-4d3636b526ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4d4ae16e-2050-4ded-852b-3333a68eb51f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5cb5349-8336-4dec-86e9-89e15eca11e3", "AQAAAAEAACcQAAAAECPJxQXggKj8GjGoATU84TyoY0Dn/ThReUAbD9ba2SCnNFBSeKAcBF+LpKSQblyi5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ec2a310-0b09-4b52-9047-6871eb4bf9c5", "AQAAAAEAACcQAAAAEN9l1HJYAUEcs19mCHyiczQr0jZJAYnasC7HvUv0UurTNsIa6HjSE1oK+LbusfMIyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbba527a-8c5b-4311-8605-e6a82e37dbf0", "AQAAAAEAACcQAAAAEE6bmMMticjlcJu3gedUX+NOm3tVEjW1rzXiOVMbjoBJbJ5Of9AeXqcCyEFtyXVEdg==" });
        }
    }
}
