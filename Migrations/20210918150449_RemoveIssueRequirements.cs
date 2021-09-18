using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class RemoveIssueRequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Issues",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Issues",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Issues",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Issues",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "d60a05d1-ab90-467a-91f9-e6c57e470015");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "d571873b-ad65-484c-a4b8-d153a11ba0fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4f65223-ca7f-4a88-bfaa-19cc28bfd2f7", "AQAAAAEAACcQAAAAEMSrNTXeu/hiB0+9oPl1iHNLSyXqgjqBnseTfxZeXsvMyMM648LwKIX2tXQrp+WKvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79acc973-b0f0-42ee-9c71-c1bb57e020eb", "AQAAAAEAACcQAAAAEGb+4FjRr7QkU3Pw8PdiZYzibwuSdbUc1+yRyPnvLwTAUCgMBXWXjQbDn6b6rmfKQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22613171-6468-4d4c-a665-4de3179b923c", "AQAAAAEAACcQAAAAEHXUursDPxUlWrZxiYiPGzi2hgTEhcdJi4VeS7/mQ7hWRGUxjLoToGMeSJqh3ttOng==" });
        }
    }
}
