using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDevolucionesFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nFechaOperacion",
                table: "SeguimientoOrdenEstado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nIdEntidad",
                table: "SeguimientoOrdenEstado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nIdSecuencia",
                table: "SeguimientoOrdenEstado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "sClaveCifrado",
                table: "OrdenTransferencia",
                type: "varchar(20)",
                maxLength: 15,
                nullable: false,
                comment: "Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes. día, hora, minutos, segundos y milisegundos.",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldComment: "Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes. día, hora, minutos, segundos y milisegundos.");

            migrationBuilder.AddColumn<int>(
                name: "nFechaOperacion",
                table: "OrdenTransferencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nIdEntidad",
                table: "OrdenTransferencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nIdSecuencia",
                table: "OrdenTransferencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nFechaOperacion",
                table: "Orden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nIdEntidad",
                table: "Orden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nIdSecuencia",
                table: "Orden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "dFechaAplicacion",
                table: "Devoluciones",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "dTiempoDeRespuesta",
                table: "Devoluciones",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "sEstatus",
                table: "Devoluciones",
                type: "longtext",
                nullable: false);

            migrationBuilder.CreateTable(
                name: "RecepcionPagoHistorico",
                columns: table => new
                {
                    nIdRecepcionPagoHistorico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdRecepcionPago = table.Column<int>(type: "int", nullable: true),
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
                        onDelete: ReferentialAction.SetNull);
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

            migrationBuilder.DropColumn(
                name: "nFechaOperacion",
                table: "SeguimientoOrdenEstado");

            migrationBuilder.DropColumn(
                name: "nIdEntidad",
                table: "SeguimientoOrdenEstado");

            migrationBuilder.DropColumn(
                name: "nIdSecuencia",
                table: "SeguimientoOrdenEstado");

            migrationBuilder.DropColumn(
                name: "nFechaOperacion",
                table: "OrdenTransferencia");

            migrationBuilder.DropColumn(
                name: "nIdEntidad",
                table: "OrdenTransferencia");

            migrationBuilder.DropColumn(
                name: "nIdSecuencia",
                table: "OrdenTransferencia");

            migrationBuilder.DropColumn(
                name: "nFechaOperacion",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "nIdEntidad",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "nIdSecuencia",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "dFechaAplicacion",
                table: "Devoluciones");

            migrationBuilder.DropColumn(
                name: "dTiempoDeRespuesta",
                table: "Devoluciones");

            migrationBuilder.DropColumn(
                name: "sEstatus",
                table: "Devoluciones");

            migrationBuilder.AlterColumn<string>(
                name: "sClaveCifrado",
                table: "OrdenTransferencia",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes. día, hora, minutos, segundos y milisegundos.",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 15,
                oldComment: "Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes. día, hora, minutos, segundos y milisegundos.");
        }
    }
}
