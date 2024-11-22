using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "19ec09e9-cadf-4cc4-bb87-27dc7dda560e", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPJb3Pac51QVkPMw1kK2FHTEmhkThQFfGCVfdmD3an1/BEDs04ZAJABwc73idQOn5w==", null, false, "2ab4dca2-0e35-4593-b01e-5affc3a14f67", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(5853), new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6097), new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6100), new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6202), new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6204), new DateTime(2024, 11, 22, 10, 25, 53, 779, DateTimeKind.Local).AddTicks(6205) });

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
                values: new object[] { new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6031), new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6048), new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6472), new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6685), new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 11, 22, 10, 12, 30, 810, DateTimeKind.Local).AddTicks(6696) });
        }
    }
}
