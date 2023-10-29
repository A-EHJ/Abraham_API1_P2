using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abraham_API1_P2.Server.Migrations
{
    /// <inheritdoc />
    public partial class Cuarta_ArreglandoFaltaOrtografica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Existensia",
                table: "Productos",
                newName: "Existencia");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Descripción",
                value: "Mixto MPP 0.2L lb");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Existencia",
                table: "Productos",
                newName: "Existensia");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Descripción",
                value: "Mixto MPp 0.2L lb");
        }
    }
}
