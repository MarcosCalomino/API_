using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la ciudad", new DateTime(2023, 9, 30, 19, 58, 28, 747, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 9, 30, 19, 58, 28, 747, DateTimeKind.Local).AddTicks(2536), "", 50, "Ciudad Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa", new DateTime(2023, 9, 30, 19, 58, 28, 747, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 9, 30, 19, 58, 28, 747, DateTimeKind.Local).AddTicks(2556), "", 150, "Villa Premiun gold", 10, 3200.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
