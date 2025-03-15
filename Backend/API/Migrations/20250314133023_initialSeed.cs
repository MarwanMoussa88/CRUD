using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class initialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { new Guid("66569d54-aa5a-45d1-8bb9-5ed060878141"), "Helioplios", "LuftBorn" },
                    { new Guid("aa329c6c-8bac-4ab7-b4a8-c78edf73ef46"), "5th Settlement", "Deloitte" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Age", "CompanyId", "Name" },
                values: new object[,]
                {
                    { new Guid("28266870-0b42-4c46-92a9-babb17905ecd"), 31, new Guid("66569d54-aa5a-45d1-8bb9-5ed060878141"), "Mohamed" },
                    { new Guid("4ebfba95-2575-473d-9287-051a15ed45fd"), 26, new Guid("aa329c6c-8bac-4ab7-b4a8-c78edf73ef46"), "Rahaf" },
                    { new Guid("b021659e-12c6-4b2c-aaa2-f73c355a6c59"), 25, new Guid("66569d54-aa5a-45d1-8bb9-5ed060878141"), "Marwan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("28266870-0b42-4c46-92a9-babb17905ecd"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("4ebfba95-2575-473d-9287-051a15ed45fd"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("b021659e-12c6-4b2c-aaa2-f73c355a6c59"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("66569d54-aa5a-45d1-8bb9-5ed060878141"));

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("aa329c6c-8bac-4ab7-b4a8-c78edf73ef46"));
        }
    }
}
