using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class jagGlum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name" },
                values: new object[,]
                {
                    { new Guid("8d347716-86d4-4606-90b0-35047fbde10c"), false, "TobiasNugget" },
                    { new Guid("ed752d39-dc93-4d18-ad46-517e76cd1f97"), true, "TwitterGod" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("12345678-1234-5678-1234-567812345675"), true, "AmandatheUglyCat" },
                    { new Guid("c70bb362-7917-41c9-9a2a-e50ac25d4854"), false, "HorseCatDude" },
                    { new Guid("d48e0f4a-d2b6-4a1c-8aea-1955a23231fc"), true, "Garfield" }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("8d347716-86d4-4606-90b0-35047fbde10c"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("ed752d39-dc93-4d18-ad46-517e76cd1f97"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345675"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("c70bb362-7917-41c9-9a2a-e50ac25d4854"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d48e0f4a-d2b6-4a1c-8aea-1955a23231fc"));

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
        }
    }
}
