using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HOPPASDETFUNKARNU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("462a712f-1588-4320-b56a-64fcb480454a"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("60a7829b-ba8a-42d3-8690-493abb35a77f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("161deaf0-cb2b-498c-bfa4-a635e2ec1427"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("905c0d35-2e4d-4d80-b2c6-aa73249aae77"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345671"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345672"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345673"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345674"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3074923a-6aeb-45ad-9f06-72ba1455e9fd"));

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name" },
                values: new object[,]
                {
                    { new Guid("0616a91d-857d-47ac-8911-aa1cfd26e80f"), false, "chickennugget" },
                    { new Guid("ca887a73-2ead-4f39-b836-6595a2bc87c0"), true, "tweetie" }
                });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345675"),
                column: "Name",
                value: "Gustaf");

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("bc868a87-c183-4ae6-9c86-8a47be1e1ffc"), false, "MjauMjau" },
                    { new Guid("d42f7e62-930e-4b1f-ae0b-e146bc5c4c43"), true, "Pandis" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00c6f5a5-52ef-4455-97ec-c304fd893b3c"), "Björn" },
                    { new Guid("12345678-1234-5678-1234-567812345678"), "TestDogForUnitTests" },
                    { new Guid("5f3818d8-be75-4bce-ae1e-c16f4840fd1a"), "Alfred" },
                    { new Guid("87654321-4321-8765-4321-876543210987"), "AnotherTestDogForUnitTests" },
                    { new Guid("e4592215-86ce-4d61-aafc-dd63d26db022"), "Patrik" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("e8c6e399-bc5e-444e-b5f0-5bb126a01360"), "string", "Pandis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("0616a91d-857d-47ac-8911-aa1cfd26e80f"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("ca887a73-2ead-4f39-b836-6595a2bc87c0"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("bc868a87-c183-4ae6-9c86-8a47be1e1ffc"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d42f7e62-930e-4b1f-ae0b-e146bc5c4c43"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("00c6f5a5-52ef-4455-97ec-c304fd893b3c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345678"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("5f3818d8-be75-4bce-ae1e-c16f4840fd1a"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("87654321-4321-8765-4321-876543210987"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("e4592215-86ce-4d61-aafc-dd63d26db022"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8c6e399-bc5e-444e-b5f0-5bb126a01360"));

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name" },
                values: new object[,]
                {
                    { new Guid("462a712f-1588-4320-b56a-64fcb480454a"), false, "TobiasNugget" },
                    { new Guid("60a7829b-ba8a-42d3-8690-493abb35a77f"), true, "TwitterGod" }
                });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345675"),
                column: "Name",
                value: "AmandatheUglyCat");

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("161deaf0-cb2b-498c-bfa4-a635e2ec1427"), true, "Garfield" },
                    { new Guid("905c0d35-2e4d-4d80-b2c6-aa73249aae77"), false, "HorseCatDude" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12345678-1234-5678-1234-567812345671"), "TestDogForUnitTests1" },
                    { new Guid("12345678-1234-5678-1234-567812345672"), "TestDogForUnitTests2" },
                    { new Guid("12345678-1234-5678-1234-567812345673"), "TestDogForUnitTests3" },
                    { new Guid("12345678-1234-5678-1234-567812345674"), "TestDogForUnitTests4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("3074923a-6aeb-45ad-9f06-72ba1455e9fd"), "string", "Pandis" });
        }
    }
}
