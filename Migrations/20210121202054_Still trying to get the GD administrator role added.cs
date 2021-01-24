using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class StilltryingtogettheGDadministratorroleadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 4, "536d2f65-aa36-4bd8-8be7-6df6e9417351", "Administrator", null },
                    { 5, "8a2014a2-1ee5-451d-b97c-8921ea6bd92f", "StandardUser", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53c196eb-2eda-49ee-8ec4-458bd155ee40", "AQAAAAEAACcQAAAAEPr1KDwGtJN+mBM507zuJ6l9QqH4L4IWreNKq0nD0JDRHVZebjXB28/KFkR/L+eZxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "529565f4-7c1d-4bde-84eb-2ed0dcfcebea", "AQAAAAEAACcQAAAAEG02sOyyp1ny7xW9yJ2SpooMXvGvvr242NoUSqaIf3B2OzptWSzo9T73pioM05fNYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f980609-ab3f-4980-ba2a-9a2ac381e821", "AQAAAAEAACcQAAAAEI98JQr4iFT7wSZwqVBxFkH6MiqPJZYPxBEop7tWNuGTqNp3H9v6WW0tA3MoWQTGwQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "8555f798-1256-48a9-8406-136562cc3ce8", "Administrator", null },
                    { 2, "6433c19f-a2a2-43d8-9de8-33c0f06f50ad", "StandardUser", null },
                    { 3, "4ca50453-aba3-473d-b071-2bdff907b6d3", "Beat the shit out of you", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25ded6fd-af86-4a70-9aa6-78a17fdfa2a1", "AQAAAAEAACcQAAAAEJk1Kg6CjFShqIX5Lqe3La5ylAaAPf7ODmuJKBeytuNzuDhdZGliQ/H8UkiaGIt1QA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bc4984b-7c7d-41af-bf4b-9836302a861e", "AQAAAAEAACcQAAAAEIw8YTsdsjQBxcFLle0ptACZ6Qtv9L9/9GG3pWBwwnmkmOA5t2yD6/zM/HQKf97qLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ddafb1f-2373-40b7-8d06-3408256aba70", "AQAAAAEAACcQAAAAEKrh98lAp4+TobZxYrg7hShycMJbjg8cpcynwhBXFKXpD+Z6QVZRdt8lASMLj7LgUQ==" });
        }
    }
}
