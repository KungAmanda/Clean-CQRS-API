using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adderatfleraa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("43654464-76d7-409b-a984-b0b5db9fae68"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("5f3a598b-486d-421a-9a7d-c9cbb3ef3e3e"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("ff2d97f2-7160-4af8-8027-6d45a77fd798"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("0eafac88-43d8-485e-ac8e-e5e6dcf00a37"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("aa0f2c6c-de30-4ee6-afc7-4b74b84bcc3e"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("183fcd34-4b62-4710-b7e6-95018c082709"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("485f4e5a-d3b2-4a55-8e60-9bbeabe03278"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c3210efb-3b21-4258-beba-aea8563de39c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc2b0674-9860-4b1e-9198-2e551f38f899"));

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Dogs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Cats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Cats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Birds",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Color", "Name" },
                values: new object[,]
                {
                    { new Guid("5255b546-1a8d-41cd-9cd6-6fb352c7b60c"), false, "purple", "chickennugget" },
                    { new Guid("7f53de2d-b89c-4db8-9043-faea28be5d6c"), true, "green", "tweetie" },
                    { new Guid("d819c89f-3451-4377-bfeb-a7b11ce9ec78"), true, "yellow", "fågeljävel" }
                });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345675"),
                columns: new[] { "Breed", "Weight" },
                values: new object[] { "bengal", 5 });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("bb6abe46-746e-45a7-99ba-9b8d29865ac1"), "Mainecoon", false, "MjauMjau", 10 },
                    { new Guid("d084a2cf-fd65-4448-a4ae-295bb13f3ce2"), "skogskatt", true, "Pandis", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("12345678-1234-5678-1234-567812345678"),
                columns: new[] { "Breed", "Weight" },
                values: new object[] { "bulldog", 20 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("87654321-4321-8765-4321-876543210987"),
                columns: new[] { "Breed", "Weight" },
                values: new object[] { "pitbull", 30 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("027c5aed-ba2c-4b4a-9a00-cc03e805f802"), "golden", "Alfred", 35 },
                    { new Guid("0e3ce154-c54b-41e4-bde6-5a41fb62492c"), "shitzu", "Björn", 10 },
                    { new Guid("ec7e2984-e160-49e3-98b6-f294cfe219b7"), "labrador", "Patrik", 35 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("9ea493d9-2756-436d-8de0-cd70a4afec5b"), "string", "Pandis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("5255b546-1a8d-41cd-9cd6-6fb352c7b60c"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("7f53de2d-b89c-4db8-9043-faea28be5d6c"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("d819c89f-3451-4377-bfeb-a7b11ce9ec78"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("bb6abe46-746e-45a7-99ba-9b8d29865ac1"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d084a2cf-fd65-4448-a4ae-295bb13f3ce2"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("027c5aed-ba2c-4b4a-9a00-cc03e805f802"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("0e3ce154-c54b-41e4-bde6-5a41fb62492c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("ec7e2984-e160-49e3-98b6-f294cfe219b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ea493d9-2756-436d-8de0-cd70a4afec5b"));

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Birds");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name" },
                values: new object[,]
                {
                    { new Guid("43654464-76d7-409b-a984-b0b5db9fae68"), true, "fågeljävel" },
                    { new Guid("5f3a598b-486d-421a-9a7d-c9cbb3ef3e3e"), false, "chickennugget" },
                    { new Guid("ff2d97f2-7160-4af8-8027-6d45a77fd798"), true, "tweetie" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("0eafac88-43d8-485e-ac8e-e5e6dcf00a37"), false, "MjauMjau" },
                    { new Guid("aa0f2c6c-de30-4ee6-afc7-4b74b84bcc3e"), true, "Pandis" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("183fcd34-4b62-4710-b7e6-95018c082709"), "Patrik" },
                    { new Guid("485f4e5a-d3b2-4a55-8e60-9bbeabe03278"), "Alfred" },
                    { new Guid("c3210efb-3b21-4258-beba-aea8563de39c"), "Björn" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("fc2b0674-9860-4b1e-9198-2e551f38f899"), "string", "Pandis" });
        }
    }
}
