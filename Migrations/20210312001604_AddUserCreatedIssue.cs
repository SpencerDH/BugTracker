using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddUserCreatedIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserCreated",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8914a210-ad77-413b-8492-322178573efb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "9401a945-3179-48f8-8ba8-786234bc80f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bee96551-12ba-4340-8f52-2e47625ee784", "AQAAAAEAACcQAAAAEEEyXA25qJvLnaUUXyAg9L7DYYfzadG+jwk56wG4F4l+vXB13+5n0Dt/XiwsHGil+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cd2d95f-de08-40ef-94e9-ba8f1413a5b8", "AQAAAAEAACcQAAAAEJOQbs9GUou4O/J2aV1xcn/Qs8052NjgDKRA55xLMX0FHVU3Q0a9TDFPSsfWMwbNwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42757d16-20e1-4ac3-8f83-5b9e069c9a58", "AQAAAAEAACcQAAAAEKsyPK3cw4qcJQ+gDcZQ7K3NbdqYlP9b97l2cP/Awdd+ymtq4sTs+mfPj03KcwsWyw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCreated",
                table: "Issues");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "3c36bb75-c150-41db-823f-7fdd92a495fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "80545179-cd20-40e6-9399-0b60b7007d46");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f75184b-0f87-45d4-bb4a-cd1d1cb13ddb", "AQAAAAEAACcQAAAAEEl73zqqdt7ECbEapjHudZQrlsCru0Uhyi7kL9QoQ4sTZ1r/FsRXe+UvO+hYAT1zmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b468e90-d1e5-475a-aea4-ba14deca7d41", "AQAAAAEAACcQAAAAEGtwiwZutYaoC7/fK3Jw8FLltTyC7deU8408zW2HQLtqZfUPY3Mod49JKupjxdsJ3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d829091-05a8-4a1f-8830-a4e5d414c839", "AQAAAAEAACcQAAAAEGvFeZ2YqFJyMPbfo/pn2dSEe+vIAAsl8KBTWJGIlQZkZeGQiN9brfw93d9l4rrZnA==" });
        }
    }
}
