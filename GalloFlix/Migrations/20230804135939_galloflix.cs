using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloFlix.Migrations
{
    public partial class galloflix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "86ea38aa-6985-41e0-975f-2272a4a6c187");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a6bdc5fe-98a4-4f4d-b08c-8dd8b04baa1f");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ffe9ecc-aa77-4cc5-be00-8586c9a54c63", "bde8829e-0579-4dad-a028-69be8a72351f" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2ffe9ecc-aa77-4cc5-be00-8586c9a54c63");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bde8829e-0579-4dad-a028-69be8a72351f");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9e9e1c49-1df2-49a3-acaf-aec1e83353d0", "7d4e4903-d9eb-42dc-b9e9-fefa8d3da829", "Moderador", "MODERADOR" },
                    { "d4e13d77-6bcb-42ce-9d60-a0a1bdcafee2", "7592ee44-aaab-48dc-b297-123c6093ebd9", "Administrador", "ADMINISTRADOR" },
                    { "ea7a4b3c-4319-4478-9ea7-cfefcec53610", "1a3bf15d-f692-4689-9653-a01a792841ce", "Usuário", " USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5e090f65-46c9-4a0f-9b2f-add49d975c07", 0, "79c88f7b-2e0e-4ae5-a313-e9e1d138764a", new DateTime(2005, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "admin@gmail.com", true, false, null, "Seu Nome Completo", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAELaUvnU0msgfIZcpUaGfxbjElW2c51SzCPiYWEEI6aafhT8vTtEEnKP0H6J+Xd2ZIA==", "14912345678", true, "/img/users/avatar.png", "326e4535-6941-465f-b49c-0cfa878c2915", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d4e13d77-6bcb-42ce-9d60-a0a1bdcafee2", "5e090f65-46c9-4a0f-9b2f-add49d975c07" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9e9e1c49-1df2-49a3-acaf-aec1e83353d0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ea7a4b3c-4319-4478-9ea7-cfefcec53610");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4e13d77-6bcb-42ce-9d60-a0a1bdcafee2", "5e090f65-46c9-4a0f-9b2f-add49d975c07" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d4e13d77-6bcb-42ce-9d60-a0a1bdcafee2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5e090f65-46c9-4a0f-9b2f-add49d975c07");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ffe9ecc-aa77-4cc5-be00-8586c9a54c63", "1b8a45f7-dece-4e5d-a77d-eb4aa6456dfa", "Administrador", "ADMINISTRADOR" },
                    { "86ea38aa-6985-41e0-975f-2272a4a6c187", "d8a9a321-acc5-4d7f-9739-0e79955fffff", "Moderador", "MODERADOR" },
                    { "a6bdc5fe-98a4-4f4d-b08c-8dd8b04baa1f", "87f41719-91ff-4edb-a2bd-55f11f7263b7", "Usuário", " USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bde8829e-0579-4dad-a028-69be8a72351f", 0, "2757a280-470e-4a4a-bb48-4bb0dd5e1143", new DateTime(2005, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "admin@gmail.com", true, false, null, "Seu Nome Completo", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEFGCbCXTkaUXjhDPc21Bv7EZ9/TTFK5/5fuIyXS4IoNf2Bpaq5cuafvezw9RwMHZVg==", "14912345678", true, "/img/users/avatar.png", "0883fd1e-7425-4ac5-8910-763f708c8c29", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2ffe9ecc-aa77-4cc5-be00-8586c9a54c63", "bde8829e-0579-4dad-a028-69be8a72351f" });
        }
    }
}
