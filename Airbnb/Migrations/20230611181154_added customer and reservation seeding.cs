using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airbnb.Migrations
{
    /// <inheritdoc />
    public partial class addedcustomerandreservationseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "MrBean@gmail.com", "Mr", "Bean" },
                    { 2, "NapoleonBonaparte@gmail.com", "Napoleon", "Bonaparte" },
                    { 3, "AliG@gmail.com", "Ali", "G" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 0f, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 0f, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 0f, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
