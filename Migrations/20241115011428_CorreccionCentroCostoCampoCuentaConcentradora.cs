using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionCentroCostoCampoCuentaConcentradora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_CentroCosto_CuentaConcentradora",
                table: "CuentaConcentradora");

            migrationBuilder.AlterColumn<int>(
                name: "nIdCuentaConcentradora",
                table: "CuentaConcentradora",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_CentroCosto_nIdCuentaConcentradora",
                table: "CentroCosto",
                column: "nIdCuentaConcentradora",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_CentroCosto_CuentaConcentradora",
                table: "CentroCosto",
                column: "nIdCuentaConcentradora",
                principalTable: "CuentaConcentradora",
                principalColumn: "nIdCuentaConcentradora",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_CentroCosto_CuentaConcentradora",
                table: "CentroCosto");

            migrationBuilder.DropIndex(
                name: "IX_CentroCosto_nIdCuentaConcentradora",
                table: "CentroCosto");

            migrationBuilder.AlterColumn<int>(
                name: "nIdCuentaConcentradora",
                table: "CuentaConcentradora",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "fk_CentroCosto_CuentaConcentradora",
                table: "CuentaConcentradora",
                column: "nIdCuentaConcentradora",
                principalTable: "CentroCosto",
                principalColumn: "nIdCentroCosto",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
