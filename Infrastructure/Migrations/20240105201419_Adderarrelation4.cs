using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Adderarrelation4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("1a264460-7735-4973-8915-0f4143541aba"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("242dea6b-bbc3-4f48-8019-6a70f907e84b"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("4f80b646-35d6-4d90-8ac8-a701bb4b35b5"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("55fc0902-dd9c-4fec-bdff-655ae055a587"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("97fd2ad8-e688-4fb6-85a5-9d7c321cf92b"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("b4b3c8e2-6d7d-471b-b013-5bed30df1c10"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("bfff674e-d194-4594-b85f-b319e8e8d7f4"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("f6825346-1cbe-471b-934b-f8eef435f26c"));

            migrationBuilder.DeleteData(
                table: "UserAnimals",
                keyColumn: "Key",
                keyValue: new Guid("3ad1e2a9-976b-495f-a5e8-84f5d7960298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("854a1d87-43f5-438a-8f7f-1940485d3ba8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("1a264460-7735-4973-8915-0f4143541aba"), "skogskatt", "Cat", true, "Pandis", 5 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("242dea6b-bbc3-4f48-8019-6a70f907e84b"), "labrador", "Dog", "Patrik", 35 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[,]
                {
                    { new Guid("4f80b646-35d6-4d90-8ac8-a701bb4b35b5"), true, "green", "Bird", "tweetie" },
                    { new Guid("55fc0902-dd9c-4fec-bdff-655ae055a587"), false, "purple", "Bird", "chickennugget" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("97fd2ad8-e688-4fb6-85a5-9d7c321cf92b"), "shitzu", "Dog", "Björn", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("b4b3c8e2-6d7d-471b-b013-5bed30df1c10"), true, "yellow", "Bird", "fågeljävel" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("bfff674e-d194-4594-b85f-b319e8e8d7f4"), "Mainecoon", "Cat", false, "MjauMjau", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("f6825346-1cbe-471b-934b-f8eef435f26c"), "golden", "Dog", "Alfred", 35 });

            migrationBuilder.InsertData(
                table: "UserAnimals",
                columns: new[] { "Key", "AnimalId", "UserId" },
                values: new object[] { new Guid("3ad1e2a9-976b-495f-a5e8-84f5d7960298"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("854a1d87-43f5-438a-8f7f-1940485d3ba8"), "string", "Pandis" });
        }
    }
}
