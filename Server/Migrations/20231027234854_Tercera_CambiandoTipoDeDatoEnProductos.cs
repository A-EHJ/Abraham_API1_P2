using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abraham_API1_P2.Server.Migrations
{
    /// <inheritdoc />
    public partial class Tercera_CambiandoTipoDeDatoEnProductos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_Productos_ProductoId",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_EntradasDetalle_Productos_ProductoId",
                table: "EntradasDetalle");

            migrationBuilder.DropIndex(
                name: "IX_EntradasDetalle_ProductoId",
                table: "EntradasDetalle");

            migrationBuilder.DropIndex(
                name: "IX_Entrada_ProductoId",
                table: "Entrada");

            migrationBuilder.AlterColumn<double>(
                name: "Existensia",
                table: "Productos",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Existensia",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Existensia",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Existensia",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Existensia",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "Existensia",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "Existensia",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "Existensia",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Existensia",
                value: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Existensia",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Existensia",
                value: 500L);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Existensia",
                value: 500L);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Existensia",
                value: 500L);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Existensia",
                value: 500L);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "Existensia",
                value: 500L);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "Existensia",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "Existensia",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Existensia",
                value: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_EntradasDetalle_ProductoId",
                table: "EntradasDetalle",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_ProductoId",
                table: "Entrada",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_Productos_ProductoId",
                table: "Entrada",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntradasDetalle_Productos_ProductoId",
                table: "EntradasDetalle",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
