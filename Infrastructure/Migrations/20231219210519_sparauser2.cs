using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sparauser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("169a4fa3-a4dd-44b9-a15b-1f7230ee6277"), true, "fågeljävel" },
                    { new Guid("46fc28e4-0f5d-4c7e-85ba-2d6476ec5e2e"), true, "tweetie" },
                    { new Guid("8726fb15-e710-416d-87b4-0dfadeb2af09"), false, "chickennugget" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("bcc042c7-2399-4c64-a7cf-85bac01cc557"), true, "Pandis" },
                    { new Guid("d579125b-f251-45be-b2c8-c9a56dcc8d2a"), false, "MjauMjau" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6dc2032c-b0b1-4559-bd68-b514c64d6f35"), "Alfred" },
                    { new Guid("c01522c1-431f-4f57-a0d4-8be74cda7424"), "Patrik" },
                    { new Guid("f5d8e4fd-ffe9-4f0b-afa6-e5ee7845a584"), "Björn" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("29e0eb66-8a07-4768-b181-528ee48367d6"), "string", "Pandis" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("169a4fa3-a4dd-44b9-a15b-1f7230ee6277"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("46fc28e4-0f5d-4c7e-85ba-2d6476ec5e2e"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("8726fb15-e710-416d-87b4-0dfadeb2af09"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("bcc042c7-2399-4c64-a7cf-85bac01cc557"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d579125b-f251-45be-b2c8-c9a56dcc8d2a"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("6dc2032c-b0b1-4559-bd68-b514c64d6f35"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c01522c1-431f-4f57-a0d4-8be74cda7424"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("f5d8e4fd-ffe9-4f0b-afa6-e5ee7845a584"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29e0eb66-8a07-4768-b181-528ee48367d6"));

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
    }
}
