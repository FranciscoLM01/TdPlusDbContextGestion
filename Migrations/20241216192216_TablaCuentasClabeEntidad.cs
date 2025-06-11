using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TablaCuentasClabeEntidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuentaClabeEntidad",
                columns: table => new
                {
                    nIdEntidad = table.Column<int>(type: "int", nullable: false),
                    nIdCuentaClabe = table.Column<int>(type: "int", nullable: false),
                    nIdCuentaConcentradora = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaClabeEntidad", x => new { x.nIdEntidad, x.nIdCuentaClabe, x.nIdCuentaConcentradora });
                    table.ForeignKey(
                        name: "fk_CuentaClabeEntidad_CuentaClabe",
                        column: x => x.nIdCuentaClabe,
                        principalTable: "CuentaClabe",
                        principalColumn: "nIdCuentaClabe",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_CuentaClabeEntidad_CuentaConcentradora",
                        column: x => x.nIdCuentaConcentradora,
                        principalTable: "CuentaConcentradora",
                        principalColumn: "nIdCuentaConcentradora",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_CuentaClabeEntidad_Entidad",
                        column: x => x.nIdEntidad,
                        principalTable: "Entidad",
                        principalColumn: "nIdEntidad",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_CuentaClabeEntidad_CuentaClabe",
                table: "CuentaClabeEntidad",
                column: "nIdCuentaClabe");

            migrationBuilder.CreateIndex(
                name: "fk_CuentaClabeEntidad_CuentaConcentradora",
                table: "CuentaClabeEntidad",
                column: "nIdCuentaConcentradora");

            migrationBuilder.CreateIndex(
                name: "fk_CuentaClabeEntidad_Entidad",
                table: "CuentaClabeEntidad",
                column: "nIdEntidad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentaClabeEntidad");
        }
    }
}
