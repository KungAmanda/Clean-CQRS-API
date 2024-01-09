using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Adderarrelation3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("59a32514-a8d5-4ce5-bcf7-1dbd9c1f6977"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("59d1cb97-0800-47b2-82fd-7ae2a41e5f3d"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("604c0308-f0f3-4cf6-8720-2086adc8d508"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("a06b9023-d241-4a3b-bac3-f60de27f920e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("bb949627-8668-4422-a769-e68337d76648"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("d57be61a-4492-4a65-bba1-81a4be581f73"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("ed0ed9d7-1c1c-4acc-9ed9-23ddf233f5d3"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("ff40194e-6f08-4a89-b25a-19263eaa8e53"));

            migrationBuilder.DeleteData(
                table: "UserAnimals",
                keyColumn: "Key",
                keyValue: new Guid("a7911894-6cea-4848-8cd5-bd74e83b569f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a77c05d0-00b4-4580-88f7-f6d425ebebe4"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("59a32514-a8d5-4ce5-bcf7-1dbd9c1f6977"), false, "purple", "Bird", "chickennugget" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("59d1cb97-0800-47b2-82fd-7ae2a41e5f3d"), "golden", "Dog", "Alfred", 35 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("604c0308-f0f3-4cf6-8720-2086adc8d508"), "Mainecoon", "Cat", false, "MjauMjau", 10 },
                    { new Guid("a06b9023-d241-4a3b-bac3-f60de27f920e"), "skogskatt", "Cat", true, "Pandis", 5 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("bb949627-8668-4422-a769-e68337d76648"), "shitzu", "Dog", "Björn", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("d57be61a-4492-4a65-bba1-81a4be581f73"), true, "yellow", "Bird", "fågeljävel" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("ed0ed9d7-1c1c-4acc-9ed9-23ddf233f5d3"), "labrador", "Dog", "Patrik", 35 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("ff40194e-6f08-4a89-b25a-19263eaa8e53"), true, "green", "Bird", "tweetie" });

            migrationBuilder.InsertData(
                table: "UserAnimals",
                columns: new[] { "Key", "AnimalId", "UserId" },
                values: new object[] { new Guid("a7911894-6cea-4848-8cd5-bd74e83b569f"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("a77c05d0-00b4-4580-88f7-f6d425ebebe4"), "string", "Pandis" });
        }
    }
}
