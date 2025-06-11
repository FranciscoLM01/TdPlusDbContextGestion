using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NuevaTablaRecepcionPago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nTipoCentro",
                table: "CentroCosto");

            migrationBuilder.CreateTable(
                name: "RecepcionPago",
                columns: table => new
                {
                    nIdRecepcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    nIdCuentaClabe = table.Column<int>(type: "int", nullable: false),
                    sProductoAsignado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    bRecurrente = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    sRfcCurp = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    bRecepcionActiva = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    dFechaAsignacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    dFechaLiberacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    dFechaPago = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    nIdEstatus = table.Column<int>(type: "int", nullable: false),
                    nMonto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecepcionPago", x => x.nIdRecepcion);
                    table.ForeignKey(
                        name: "fk_Recepcion_CuentaClabe",
                        column: x => x.nIdCuentaClabe,
                        principalTable: "CuentaClabe",
                        principalColumn: "nIdCuentaClabe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Recepcion_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_RecepcionPago_CuentaClabe",
                table: "RecepcionPago",
                column: "nIdCuentaClabe");

            migrationBuilder.CreateIndex(
                name: "fk_RecepcionPago_Participante",
                table: "RecepcionPago",
                column: "nIdParticipante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecepcionPago");

            migrationBuilder.AddColumn<int>(
                name: "nTipoCentro",
                table: "CentroCosto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
