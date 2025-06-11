using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CuentaConcentradoraAlias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sAlias",
                table: "CuentaConcentradora",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Esta columna corresponde al identificador (alias) de una cuenta concentradora. Por ejemplo: cuantacontradoraclienteindirecto1 Producto",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldComment: "Esta columna corresponde al identificador (alias) de una cuenta concentradora. Por ejemplo: cuantacontradoraclienteindirecto1 Producto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sAlias",
                table: "CuentaConcentradora",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Esta columna corresponde al identificador (alias) de una cuenta concentradora. Por ejemplo: cuantacontradoraclienteindirecto1 Producto",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldComment: "Esta columna corresponde al identificador (alias) de una cuenta concentradora. Por ejemplo: cuantacontradoraclienteindirecto1 Producto");
        }
    }
}
