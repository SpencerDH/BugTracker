using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class TestingmigrationfunctionalitywithAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cc004d30-e8d6-4809-a00f-908eabd52761");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b6226b62-6299-4809-8e57-81ff03c0007a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f1d0c14-efce-4e4b-915c-85cac08678cb", "AQAAAAEAACcQAAAAEIEkZH2yFZYaDaJOa2f9776x2H8e+pQhtICv1/ymLFZ90w5rNrmOp/SRrv6J4rcAqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2106fa80-e8a3-4dbb-8327-4bad70163d69", "AQAAAAEAACcQAAAAEORZ+a8VoVU2lQ8GN2lKvHX4cXiGeFugqhPpUkJmOYElFuqQgL6m0p0PSwkK9nxoEQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 3, 0, "e8020228-6d2e-44d7-82f7-5ead44a836d0", null, false, "Spencer", "Hall", false, null, null, null, "AQAAAAEAACcQAAAAEK27OrmbEpNlAHyWA9ApuH9XIvQa9iv6PPyGO2YsLMu9i/kj27CxxBIu18gNB/k50Q==", null, false, null, false, "SpencerDH" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b9260a4e-69dd-45e9-9b8c-9f2097e449c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "584ec19c-cff5-44f2-887a-05d5e56e71d8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23fe7a53-2a49-4592-a27f-84ae2747a067", "AQAAAAEAACcQAAAAEBlFoJYtzk6fPZbc2h+VUOobkYuTa1+QpA5ppQ8MTP/VJoSzd5TGdPtG9idwBl69dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7142a107-5f49-41b6-acd7-c4074bdc67ee", "AQAAAAEAACcQAAAAEFywtIGDVQDj2EO86Iju4Umr1xlIKnVAgClpiXXiA4MrNch2qmaoTnXzhO1gegdhmA==" });
        }
    }
}
