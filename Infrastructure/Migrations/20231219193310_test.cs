using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("5f289850-2677-4700-af27-6445fd759e20"), false, "chickennugget" },
                    { new Guid("8eed2d62-1206-4a5a-ac8f-a3ffeba69884"), true, "tweetie" },
                    { new Guid("eab8181c-bf8d-496c-9e2b-ba787e5c6295"), true, "fågeljävel" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("3eb5a139-68ff-413c-a197-dd8ba7c56dfe"), false, "MjauMjau" },
                    { new Guid("8f16ebcd-003c-4b77-84bd-dc2248dc31c0"), true, "Pandis" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("528fdd12-592a-4557-a3be-6f6123ea13f1"), "Patrik" },
                    { new Guid("5c1ecb60-ad34-4838-973c-f85cc67e56c4"), "Alfred" },
                    { new Guid("eb89e165-ad9a-4798-bc38-66c2ef817606"), "Björn" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("515ea634-a3ee-4996-86bb-aacdbceae5b9"), "string", "Pandis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("5f289850-2677-4700-af27-6445fd759e20"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("8eed2d62-1206-4a5a-ac8f-a3ffeba69884"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("eab8181c-bf8d-496c-9e2b-ba787e5c6295"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("3eb5a139-68ff-413c-a197-dd8ba7c56dfe"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("8f16ebcd-003c-4b77-84bd-dc2248dc31c0"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("528fdd12-592a-4557-a3be-6f6123ea13f1"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("5c1ecb60-ad34-4838-973c-f85cc67e56c4"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("eb89e165-ad9a-4798-bc38-66c2ef817606"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("515ea634-a3ee-4996-86bb-aacdbceae5b9"));

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
    }
}
