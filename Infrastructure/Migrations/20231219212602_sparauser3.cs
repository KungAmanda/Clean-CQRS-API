using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sparauser3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
