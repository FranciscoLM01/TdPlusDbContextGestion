using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductoFinancieroFieldsChangedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Agregar la nueva columna
            migrationBuilder.AddColumn<int>(
                name: "nClave",
                table: "ProductoFinanciero",
                nullable: false,
                defaultValue: 0);

            // 2. Copiar los datos de sClave a nClave
            migrationBuilder.Sql("UPDATE ProductoFinanciero SET nClave = sClave");

            // 3. Eliminar la columna antigua
            migrationBuilder.DropColumn(
                name: "sClave",
                table: "ProductoFinanciero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Restaurar la columna original en caso de revertir la migración
            migrationBuilder.AddColumn<int>(
                name: "sClave",
                table: "ProductoFinanciero",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.Sql("UPDATE ProductoFinanciero SET sClave = nClave");

            migrationBuilder.DropColumn(
                name: "nClave",
                table: "ProductoFinanciero");
        }

    }
}
