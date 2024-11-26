using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement1.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "68ac6387-a0f3-4f37-972a-dd0769cb24ef", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEA9JMn6XJmaI0fkUqJii4EjT0YaFlLfRFeYBW7zjadyFPekQpHNxdXFqQ1hbsWUxEA==", null, false, "c93f6ddd-2ce5-407f-a5d0-0ba8a88fc688", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(6896), new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7441), new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 11, 25, 22, 8, 42, 183, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(834), new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1149), new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1152), new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1293), new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1295), new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1297), new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 11, 24, 20, 31, 28, 182, DateTimeKind.Local).AddTicks(1299) });
        }
    }
}
