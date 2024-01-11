using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test420 : Migration
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
                    AnimalId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnimalId1 = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId1 = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnimals", x => x.Key);
                    table.ForeignKey(
                        name: "FK_UserAnimals_Animals_AnimalId1",
                        column: x => x.AnimalId1,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnimals_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("12345678-1234-5678-1234-567812345675"), "bengal", "Cat", true, "Gustaf", 5 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("12345678-1234-5678-1234-567812345678"), "bulldog", "Dog", "TestDogForUnitTests", 20 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("2de0ccf1-8f2e-4352-bbd1-ce8f817b4bc1"), "Mainecoon", "Cat", false, "MjauMjau", 10 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[,]
                {
                    { new Guid("5e6ba330-a313-430d-bdab-bd63f8cc89b0"), true, "green", "Bird", "tweetie" },
                    { new Guid("63f78a4c-120a-4ec5-b57e-88075a7af69b"), false, "purple", "Bird", "chickennugget" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("80f96112-c483-4b29-9244-19cfa8a765d8"), "shitzu", "Dog", "Björn", 10 },
                    { new Guid("87654321-4321-8765-4321-876543210987"), "pitbull", "Dog", "AnotherTestDogForUnitTests", 30 },
                    { new Guid("87967866-6b92-4316-b621-61d704fdd015"), "labrador", "Dog", "Patrik", 35 },
                    { new Guid("c83f284c-1378-4b56-8ab2-cd962d471ea8"), "golden", "Dog", "Alfred", 35 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("c8ae2e2e-a79e-40ad-ba62-813945083487"), "skogskatt", "Cat", true, "Pandis", 5 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("d242f283-b994-4213-bbab-4ba90f8b55cf"), true, "yellow", "Bird", "fågeljävel" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("6d498262-ffef-4bac-a3db-df8e328de5d5"), "string", "Pandis" });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_AnimalId1",
                table: "UserAnimals",
                column: "AnimalId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_UserId1",
                table: "UserAnimals",
                column: "UserId1");
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
