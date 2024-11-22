using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
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
                    { 1, "System", new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3358), new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3371), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3374), new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3374), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3600), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3603), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3691), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3694), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3696), new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3696), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 11, 22, 9, 35, 9, 832, DateTimeKind.Local).AddTicks(3698), "C-HR", "System" }
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
