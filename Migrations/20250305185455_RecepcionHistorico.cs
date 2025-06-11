using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RecepcionHistorico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecepcionPagoHistorico",
                columns: table => new
                {
                    nIdRecepcionPagoHistorico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdRecepcionPago = table.Column<int>(type: "int", nullable: false),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    nIdCuentaClabe = table.Column<int>(type: "int", nullable: false),
                    sCuentaClabe = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: true),
                    sProductoAsignado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    sRfcCurp = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    nMonto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecepcionPagoHistorico", x => x.nIdRecepcionPagoHistorico);
                    table.ForeignKey(
                        name: "fk_RecepcionHistorico_RecepcionPago",
                        column: x => x.nIdRecepcionPago,
                        principalTable: "RecepcionPago",
                        principalColumn: "nIdRecepcion",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_RecepcionPagoHistorico_RecepcionPago",
                table: "RecepcionPagoHistorico",
                column: "nIdRecepcionPago");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecepcionPagoHistorico");
        }
    }
}
