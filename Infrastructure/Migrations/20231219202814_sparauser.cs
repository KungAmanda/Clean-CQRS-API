using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sparauser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("19b1da8d-3fb0-445b-9685-843a858cefa8"), true, "fågeljävel" },
                    { new Guid("20a70e4e-a49b-4f22-b92a-4490dffb6698"), false, "chickennugget" },
                    { new Guid("bb44532a-fbce-42f5-a3d8-37dc9429b44d"), true, "tweetie" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("1ea2d651-6633-4e70-a3e0-7539981bbae3"), false, "MjauMjau" },
                    { new Guid("2a36d00d-d4df-401e-932f-afb6de35f23e"), true, "Pandis" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0fc54d36-10f2-4854-b391-0f22a3920ffe"), "Patrik" },
                    { new Guid("4fd24afe-3f61-4034-a925-80cd74fff7ee"), "Alfred" },
                    { new Guid("9f605058-55d9-4bc3-a558-664de99809a9"), "Björn" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("7454ab83-401f-45b2-b7e4-dd27193b2958"), "string", "Pandis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("19b1da8d-3fb0-445b-9685-843a858cefa8"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("20a70e4e-a49b-4f22-b92a-4490dffb6698"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("bb44532a-fbce-42f5-a3d8-37dc9429b44d"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("1ea2d651-6633-4e70-a3e0-7539981bbae3"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("2a36d00d-d4df-401e-932f-afb6de35f23e"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("0fc54d36-10f2-4854-b391-0f22a3920ffe"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("4fd24afe-3f61-4034-a925-80cd74fff7ee"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("9f605058-55d9-4bc3-a558-664de99809a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7454ab83-401f-45b2-b7e4-dd27193b2958"));

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
    }
}
