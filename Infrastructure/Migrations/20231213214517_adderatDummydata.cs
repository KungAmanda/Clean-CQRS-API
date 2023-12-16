using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adderatDummydata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("c70bb362-7917-41c9-9a2a-e50ac25d4854"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d48e0f4a-d2b6-4a1c-8aea-1955a23231fc"));

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name" },
                values: new object[,]
                {
                    { new Guid("462a712f-1588-4320-b56a-64fcb480454a"), false, "TobiasNugget" },
                    { new Guid("60a7829b-ba8a-42d3-8690-493abb35a77f"), true, "TwitterGod" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("161deaf0-cb2b-498c-bfa4-a635e2ec1427"), true, "Garfield" },
                    { new Guid("905c0d35-2e4d-4d80-b2c6-aa73249aae77"), false, "HorseCatDude" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("3074923a-6aeb-45ad-9f06-72ba1455e9fd"), "string", "Pandis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3074923a-6aeb-45ad-9f06-72ba1455e9fd"));

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
                    { new Guid("c70bb362-7917-41c9-9a2a-e50ac25d4854"), false, "HorseCatDude" },
                    { new Guid("d48e0f4a-d2b6-4a1c-8aea-1955a23231fc"), true, "Garfield" }
                });
        }
    }
}
