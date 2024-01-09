using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Adderarrelation6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("0b7119b6-c88d-43eb-8579-156a88aba8dd"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("270ba35d-625e-493f-b8bf-5294fb3f79f5"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("299c35ba-b372-4aa5-a67f-ba669be8e2f4"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("3749bbc1-d1eb-4699-b190-a3a636801bc0"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("80849a0b-8ca5-434b-a5b2-e650fad8915d"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("94923889-8911-4412-96f1-bf9b57003c6a"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("a467aeac-b20f-4477-b072-dcba9a35865c"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("b7af795f-7f64-46ae-8f15-eb2dcd4e8ba8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0ff2e07-1fec-46af-b3e2-c9dfb6b29fa7"));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("1d6a6676-2526-4464-8ece-1f42d0ef0ed9"), "skogskatt", "Cat", true, "Pandis", 5 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("2cbe9c89-d45e-4d1b-a954-c6f3eb40da51"), true, "green", "Bird", "tweetie" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("2fb60523-71a3-4b50-bfcd-efaa4ccbb0a5"), "labrador", "Dog", "Patrik", 35 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("393f6c91-5496-4618-a847-a530d449c574"), false, "purple", "Bird", "chickennugget" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("3d19844b-8200-40a1-aed6-25fd68d7eed6"), "Mainecoon", "Cat", false, "MjauMjau", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("7d4f3521-1656-4b35-89a7-86c0f8f6bd64"), true, "yellow", "Bird", "fågeljävel" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("9577bf8d-108a-443d-ab04-ea89aaaac682"), "golden", "Dog", "Alfred", 35 },
                    { new Guid("f1259214-fdd4-4848-8a20-a2ea0553b6a5"), "shitzu", "Dog", "Björn", 10 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("b8d53ff5-06e7-4e5b-97c4-30fb4a16f330"), "string", "Pandis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("1d6a6676-2526-4464-8ece-1f42d0ef0ed9"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("2cbe9c89-d45e-4d1b-a954-c6f3eb40da51"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("2fb60523-71a3-4b50-bfcd-efaa4ccbb0a5"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("393f6c91-5496-4618-a847-a530d449c574"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("3d19844b-8200-40a1-aed6-25fd68d7eed6"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("7d4f3521-1656-4b35-89a7-86c0f8f6bd64"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("9577bf8d-108a-443d-ab04-ea89aaaac682"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("f1259214-fdd4-4848-8a20-a2ea0553b6a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8d53ff5-06e7-4e5b-97c4-30fb4a16f330"));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("0b7119b6-c88d-43eb-8579-156a88aba8dd"), "Mainecoon", "Cat", false, "MjauMjau", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("270ba35d-625e-493f-b8bf-5294fb3f79f5"), "shitzu", "Dog", "Björn", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("299c35ba-b372-4aa5-a67f-ba669be8e2f4"), "skogskatt", "Cat", true, "Pandis", 5 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[,]
                {
                    { new Guid("3749bbc1-d1eb-4699-b190-a3a636801bc0"), false, "purple", "Bird", "chickennugget" },
                    { new Guid("80849a0b-8ca5-434b-a5b2-e650fad8915d"), true, "yellow", "Bird", "fågeljävel" },
                    { new Guid("94923889-8911-4412-96f1-bf9b57003c6a"), true, "green", "Bird", "tweetie" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("a467aeac-b20f-4477-b072-dcba9a35865c"), "labrador", "Dog", "Patrik", 35 },
                    { new Guid("b7af795f-7f64-46ae-8f15-eb2dcd4e8ba8"), "golden", "Dog", "Alfred", 35 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("b0ff2e07-1fec-46af-b3e2-c9dfb6b29fa7"), "string", "Pandis" });
        }
    }
}
