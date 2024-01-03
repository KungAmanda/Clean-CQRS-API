using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdderarManytoMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CanFly = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LikesToPlay = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Breed = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dog_Weight = table.Column<int>(type: "int", nullable: true),
                    Dog_Breed = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserAnimals",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AnimalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnimals", x => x.Key);
                    table.ForeignKey(
                        name: "FK_UserAnimals_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnimals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("035f5631-334a-4c9f-a8ee-426e9b484423"), "Mainecoon", "Cat", false, "MjauMjau", 10 },
                    { new Guid("12345678-1234-5678-1234-567812345675"), "bengal", "Cat", true, "Gustaf", 5 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("12345678-1234-5678-1234-567812345678"), "bulldog", "Dog", "TestDogForUnitTests", 20 },
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
                values: new object[] { new Guid("6b1b5f61-baf9-4ba1-82d6-7b85da722d4e"), false, "purple", "Bird", "chickennugget" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("87654321-4321-8765-4321-876543210987"), "pitbull", "Dog", "AnotherTestDogForUnitTests", 30 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[,]
                {
                    { new Guid("a0001692-b6d2-46c1-ac8f-def16c4d62b9"), true, "yellow", "Bird", "fågeljävel" },
                    { new Guid("a997e3c6-ced2-49d8-be64-9b622fe8cdbe"), true, "green", "Bird", "tweetie" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("c3adc4c7-35e1-4fa0-8c8a-d8dae029bc38"), "string", "Pandis" });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_AnimalId",
                table: "UserAnimals",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_UserId",
                table: "UserAnimals",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAnimals");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
