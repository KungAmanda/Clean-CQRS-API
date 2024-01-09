using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Adderarrelation5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("30770188-a308-4429-a4c7-3d0781d9be7f"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("5e2950f0-c1ab-417e-bc1a-d114587a1ed9"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("63b389df-a8b8-4346-9296-ec3f1f9865dc"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("9983513c-11ae-4e43-a546-9e1f4e2f9cfa"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("bd03c736-4504-42cf-9ed1-442b2b16b5aa"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("d7617bbd-4c7a-443e-8f72-ccffb584de9d"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("d874ba08-5d9c-4c08-b132-b77c9b03cf78"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("e3847aaf-300f-4704-9d7e-16d95623869e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c01409a-8dee-4b68-81e5-0af2cc9e8b5f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("30770188-a308-4429-a4c7-3d0781d9be7f"), "skogskatt", "Cat", true, "Pandis", 5 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("5e2950f0-c1ab-417e-bc1a-d114587a1ed9"), true, "green", "Bird", "tweetie" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("63b389df-a8b8-4346-9296-ec3f1f9865dc"), "golden", "Dog", "Alfred", 35 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("9983513c-11ae-4e43-a546-9e1f4e2f9cfa"), "Mainecoon", "Cat", false, "MjauMjau", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("bd03c736-4504-42cf-9ed1-442b2b16b5aa"), "labrador", "Dog", "Patrik", 35 },
                    { new Guid("d7617bbd-4c7a-443e-8f72-ccffb584de9d"), "shitzu", "Dog", "Björn", 10 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[,]
                {
                    { new Guid("d874ba08-5d9c-4c08-b132-b77c9b03cf78"), true, "yellow", "Bird", "fågeljävel" },
                    { new Guid("e3847aaf-300f-4704-9d7e-16d95623869e"), false, "purple", "Bird", "chickennugget" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("1c01409a-8dee-4b68-81e5-0af2cc9e8b5f"), "string", "Pandis" });
        }
    }
}
