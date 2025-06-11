using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TipoCuentaEntidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nIdTipoCuentaEntidad",
                table: "CuentaClabeEntidad",
                type: "int",
                nullable: true,
                defaultValue: 0
                );

            migrationBuilder.CreateTable(
                name: "TipoCuentaEntidad",
                columns: table => new
                {
                    nIdTipoCuentaEntidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Esta columna corresponde al nombre del tipo de cuenta entidad."),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuentaEntidad", x => x.nIdTipoCuentaEntidad);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_CuentaClabeEntidad_TipoCuentaEntidad",
                table: "CuentaClabeEntidad",
                column: "nIdTipoCuentaEntidad");

            migrationBuilder.CreateIndex(
                name: "unq_TipoCuenta1",
                table: "TipoCuentaEntidad",
                column: "nIdTipoCuentaEntidad",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_CuentaClabeEntidad_TipoCuentaEntidad",
                table: "CuentaClabeEntidad",
                column: "nIdTipoCuentaEntidad",
                principalTable: "TipoCuentaEntidad",
                principalColumn: "nIdTipoCuentaEntidad",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_CuentaClabeEntidad_TipoCuentaEntidad",
                table: "CuentaClabeEntidad");

            migrationBuilder.DropTable(
                name: "TipoCuentaEntidad");

            migrationBuilder.DropIndex(
                name: "fk_CuentaClabeEntidad_TipoCuentaEntidad",
                table: "CuentaClabeEntidad");

            migrationBuilder.DropColumn(
                name: "nIdTipoCuentaEntidad",
                table: "CuentaClabeEntidad");
        }
    }
}
