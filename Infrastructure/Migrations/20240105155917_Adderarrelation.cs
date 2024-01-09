using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Adderarrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("035f5631-334a-4c9f-a8ee-426e9b484423"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("279075da-d205-4564-811d-63d45b601618"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("27922ff3-31ed-4db1-ab4c-f6104c721b72"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("3d8a524b-fd75-4bf0-993f-4870c265dbf2"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("4e8efdc6-ab76-4b1d-9029-6fae9759600e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("6b1b5f61-baf9-4ba1-82d6-7b85da722d4e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("a0001692-b6d2-46c1-ac8f-def16c4d62b9"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("a997e3c6-ced2-49d8-be64-9b622fe8cdbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3adc4c7-35e1-4fa0-8c8a-d8dae029bc38"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("035f5631-334a-4c9f-a8ee-426e9b484423"), "Mainecoon", "Cat", false, "MjauMjau", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("279075da-d205-4564-811d-63d45b601618"), "golden", "Dog", "Alfred", 35 },
                    { new Guid("27922ff3-31ed-4db1-ab4c-f6104c721b72"), "labrador", "Dog", "Patrik", 35 },
                    { new Guid("3d8a524b-fd75-4bf0-993f-4870c265dbf2"), "shitzu", "Dog", "Björn", 10 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("4e8efdc6-ab76-4b1d-9029-6fae9759600e"), "skogskatt", "Cat", true, "Pandis", 5 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[,]
                {
                    { new Guid("6b1b5f61-baf9-4ba1-82d6-7b85da722d4e"), false, "purple", "Bird", "chickennugget" },
                    { new Guid("a0001692-b6d2-46c1-ac8f-def16c4d62b9"), true, "yellow", "Bird", "fågeljävel" },
                    { new Guid("a997e3c6-ced2-49d8-be64-9b622fe8cdbe"), true, "green", "Bird", "tweetie" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("c3adc4c7-35e1-4fa0-8c8a-d8dae029bc38"), "string", "Pandis" });
        }
    }
}
