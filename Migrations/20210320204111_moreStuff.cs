using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class moreStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "IssueComment",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_IssueComment_AppUserId",
                table: "IssueComment",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_IssueComment_AspNetUsers_AppUserId",
                table: "IssueComment",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IssueComment_AspNetUsers_AppUserId",
                table: "IssueComment");

            migrationBuilder.DropIndex(
                name: "IX_IssueComment_AppUserId",
                table: "IssueComment");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "IssueComment");

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
    }
}
