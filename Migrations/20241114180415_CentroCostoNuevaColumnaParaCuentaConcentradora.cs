using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CentroCostoNuevaColumnaParaCuentaConcentradora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "nIdCuentaConcentradora",
                table: "CuentaConcentradora",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "nIdCuentaConcentradora",
                table: "CentroCosto",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_CentroCosto_CuentaConcentradora",
                table: "CuentaConcentradora",
                column: "nIdCuentaConcentradora",
                principalTable: "CentroCosto",
                principalColumn: "nIdCentroCosto",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_CentroCosto_CuentaConcentradora",
                table: "CuentaConcentradora");

            migrationBuilder.DropColumn(
                name: "nIdCuentaConcentradora",
                table: "CentroCosto");

            migrationBuilder.AlterColumn<int>(
                name: "nIdCuentaConcentradora",
                table: "CuentaConcentradora",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);
        }
    }
}
