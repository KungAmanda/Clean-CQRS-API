using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Adderarrelation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("106fcb81-c21a-46d8-addc-5a7fa9959c71"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("2e67cbfb-3a0b-4710-89d0-58c92311ac97"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("36c45b13-aa1a-4b23-a69b-0505c7c9cc1e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("5aedb338-5bd1-4865-846c-c722ea3fccba"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("6611d731-e402-4404-9192-31c67255b62f"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("7a133860-c8f7-4f61-b909-21c9589c5793"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("8f98b7fd-67c2-417d-8d45-69cec5c89d5e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("c17e2355-29db-4370-8060-284723f6f240"));

            migrationBuilder.DeleteData(
                table: "UserAnimals",
                keyColumn: "Key",
                keyValue: new Guid("ac8dda57-4931-4abe-adf5-b813a4ba477f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ecce5b98-a674-45e8-a865-d4db4be65240"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("106fcb81-c21a-46d8-addc-5a7fa9959c71"), "skogskatt", "Cat", true, "Pandis", 5 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("2e67cbfb-3a0b-4710-89d0-58c92311ac97"), false, "purple", "Bird", "chickennugget" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("36c45b13-aa1a-4b23-a69b-0505c7c9cc1e"), "golden", "Dog", "Alfred", 35 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("5aedb338-5bd1-4865-846c-c722ea3fccba"), true, "green", "Bird", "tweetie" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("6611d731-e402-4404-9192-31c67255b62f"), "labrador", "Dog", "Patrik", 35 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("7a133860-c8f7-4f61-b909-21c9589c5793"), true, "yellow", "Bird", "fågeljävel" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("8f98b7fd-67c2-417d-8d45-69cec5c89d5e"), "Mainecoon", "Cat", false, "MjauMjau", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("c17e2355-29db-4370-8060-284723f6f240"), "shitzu", "Dog", "Björn", 10 });

            migrationBuilder.InsertData(
                table: "UserAnimals",
                columns: new[] { "Key", "AnimalId", "UserId" },
                values: new object[] { new Guid("ac8dda57-4931-4abe-adf5-b813a4ba477f"), new Guid("035f5631-334a-4c9f-a8ee-426e9b484423"), new Guid("c3adc4c7-35e1-4fa0-8c8a-d8dae029bc38") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("ecce5b98-a674-45e8-a865-d4db4be65240"), "string", "Pandis" });
        }
    }
}
