using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5436), new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5454), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5458), new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5459), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5771), new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5771), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5774), new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5774), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5915), new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5916), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5918), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5919), new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5920), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5922), new DateTime(2024, 11, 24, 20, 9, 29, 97, DateTimeKind.Local).AddTicks(5922), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
