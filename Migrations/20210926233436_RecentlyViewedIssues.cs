using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class RecentlyViewedIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUserViewedIssue",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueID = table.Column<int>(type: "int", nullable: true),
                    TimeViewed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserViewedIssue", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AppUserViewedIssue_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppUserViewedIssue_Issues_IssueID",
                        column: x => x.IssueID,
                        principalTable: "Issues",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AppUserViewedIssue_AppUserId",
                table: "AppUserViewedIssue",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserViewedIssue_IssueID",
                table: "AppUserViewedIssue",
                column: "IssueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserViewedIssue");

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
    }
}
