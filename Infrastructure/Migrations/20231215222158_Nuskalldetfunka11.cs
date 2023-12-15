using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Nuskalldetfunka11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("0616a91d-857d-47ac-8911-aa1cfd26e80f"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("ca887a73-2ead-4f39-b836-6595a2bc87c0"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("bc868a87-c183-4ae6-9c86-8a47be1e1ffc"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d42f7e62-930e-4b1f-ae0b-e146bc5c4c43"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("00c6f5a5-52ef-4455-97ec-c304fd893b3c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("5f3818d8-be75-4bce-ae1e-c16f4840fd1a"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("e4592215-86ce-4d61-aafc-dd63d26db022"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8c6e399-bc5e-444e-b5f0-5bb126a01360"));

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name" },
                values: new object[,]
                {
                    { new Guid("9a03f3eb-266a-4b05-bdd5-1b8157f23908"), true, "tweetie" },
                    { new Guid("e64ef920-e1f7-4ac0-8124-e759514e3f67"), false, "chickennugget" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("7955d2f6-3e3e-4cbb-8b77-bbfc6db9e8ea"), true, "Pandis" },
                    { new Guid("c3bf6e4c-e135-4c57-a928-d26c33733076"), false, "MjauMjau" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("88487084-f445-4904-9d21-e0df905fdb21"), "Alfred" },
                    { new Guid("ae2db5f4-90a2-4caf-8589-f13e6ed42fa1"), "Patrik" },
                    { new Guid("d8705753-dcb7-48e0-83d5-322855d93134"), "Björn" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("99760a78-dc4a-4738-ba51-057a46ae362b"), "string", "Pandis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("9a03f3eb-266a-4b05-bdd5-1b8157f23908"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("e64ef920-e1f7-4ac0-8124-e759514e3f67"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("7955d2f6-3e3e-4cbb-8b77-bbfc6db9e8ea"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("c3bf6e4c-e135-4c57-a928-d26c33733076"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("88487084-f445-4904-9d21-e0df905fdb21"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("ae2db5f4-90a2-4caf-8589-f13e6ed42fa1"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("d8705753-dcb7-48e0-83d5-322855d93134"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99760a78-dc4a-4738-ba51-057a46ae362b"));

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "CanFly", "Name" },
                values: new object[,]
                {
                    { new Guid("0616a91d-857d-47ac-8911-aa1cfd26e80f"), false, "chickennugget" },
                    { new Guid("ca887a73-2ead-4f39-b836-6595a2bc87c0"), true, "tweetie" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("bc868a87-c183-4ae6-9c86-8a47be1e1ffc"), false, "MjauMjau" },
                    { new Guid("d42f7e62-930e-4b1f-ae0b-e146bc5c4c43"), true, "Pandis" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00c6f5a5-52ef-4455-97ec-c304fd893b3c"), "Björn" },
                    { new Guid("5f3818d8-be75-4bce-ae1e-c16f4840fd1a"), "Alfred" },
                    { new Guid("e4592215-86ce-4d61-aafc-dd63d26db022"), "Patrik" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("e8c6e399-bc5e-444e-b5f0-5bb126a01360"), "string", "Pandis" });
        }
    }
}
