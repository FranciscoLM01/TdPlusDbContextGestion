using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "SeguimientoOrdenEstado",
            columns: table => new
            {
                nIdSeguimientoOrdenEstado = table.Column<int>(type: "int", nullable: false)
                    .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                nIdOrden = table.Column<int>(type: "int", nullable: false),
                nIdOrdenEstado = table.Column<int>(type: "int", nullable: false),
                nIdUsuario = table.Column<int>(type: "int", nullable: true),
                sMotivo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                dFecRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                nIdEntidad = table.Column<int>(type: "int", nullable: false),
                nIdSecuencia = table.Column<int>(type: "int", nullable: false),
                nFechaOperacion = table.Column<int>(type: "int", nullable: false),
                Key = table.Column<string>(type: "longtext", nullable: false),
                bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                dFecMovimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_SeguimientoOrdenEstado", x => x.nIdSeguimientoOrdenEstado);
                table.ForeignKey(
                    name: "fk_SeguimientoOrdenEstado_Orden",
                    column: x => x.nIdOrden,
                    principalTable: "Orden",
                    principalColumn: "nIdOrden");
                table.ForeignKey(
                    name: "fk_SeguimientoOrdenEstado_OrdenEstado",
                    column: x => x.nIdOrdenEstado,
                    principalTable: "OrdenEstado",
                    principalColumn: "nIdOrdenEstado");
                table.ForeignKey(
                    name: "fk_SeguimientoOrdenEstado_Usuario",
                    column: x => x.nIdUsuario,
                    principalTable: "Usuario",
                    principalColumn: "nIdUsuario");
            })
            .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                   name: "SeguimientoOrdenTransferenciaEstado",
                   columns: table => new
                   {
                       nIdSeguimientoOrdenTransferenciaEstado = table.Column<int>(type: "int", nullable: false)
                           .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                       nIdOrdenTransferencia = table.Column<int>(type: "int", nullable: false),
                       nIdOrdenTransferenciaEstado = table.Column<int>(type: "int", nullable: false),
                       nIdUsuario = table.Column<int>(type: "int", nullable: true, comment: "El identificar único del usuario actual que afectaría el nuevo estado o status de la orden de transferencia"),
                       sMotivo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                       dFecRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                       Key = table.Column<string>(type: "longtext", nullable: false),
                       bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                       dFecMovimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_SeguimientoOrdenTransferenciaEstado", x => x.nIdSeguimientoOrdenTransferenciaEstado);
                       table.ForeignKey(
                           name: "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferencia",
                           column: x => x.nIdOrdenTransferencia,
                           principalTable: "OrdenTransferencia",
                           principalColumn: "nIdOrdenTransferencia");
                       table.ForeignKey(
                           name: "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferenciaEstado",
                           column: x => x.nIdOrdenTransferenciaEstado,
                           principalTable: "OrdenTransferenciaEstado",
                           principalColumn: "nIdOrdenTransferenciaEstado");
                       table.ForeignKey(
                           name: "fk_SeguimientoOrdenTransferenciaEstado_Usuario",
                           column: x => x.nIdUsuario,
                           principalTable: "Usuario",
                           principalColumn: "nIdUsuario");
                   })
                   .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
           name: "OrdenMovimiento",
           columns: table => new
           {
               nIdOrdenMovimiento = table.Column<int>(type: "int", nullable: false)
                   .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
               nIdOrden = table.Column<int>(type: "int", nullable: false),
               nIdMovimiento = table.Column<int>(type: "int", nullable: false),
               dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
               dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false),
               Key = table.Column<string>(type: "longtext", nullable: false),
               bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_OrdenMovimiento", x => x.nIdOrdenMovimiento);
               table.ForeignKey(
                   name: "fk_OrdenMovimiento_Movimiento",
                   column: x => x.nIdMovimiento,
                   principalTable: "Movimiento",
                   principalColumn: "nIdMovimiento");
               table.ForeignKey(
                   name: "fk_OrdenMovimiento_Orden",
                   column: x => x.nIdOrden,
                   principalTable: "Orden",
                   principalColumn: "nIdOrden");
           },
           comment: "Esta tabla tiene el propósito de almacenar las órdenes y los movimientos correspondientes y saber las afectaciones que van realizando en el saldo del participante")
           .Annotation("MySQL:Charset", "utf8mb4");


            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferencia",
                table: "SeguimientoOrdenTransferenciaEstado",
                column: "nIdOrdenTransferencia");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferenciaEstado",
                table: "SeguimientoOrdenTransferenciaEstado",
                column: "nIdOrdenTransferenciaEstado");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenTransferenciaEstado_Usuario",
                table: "SeguimientoOrdenTransferenciaEstado",
                column: "nIdUsuario");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenEstado_Orden",
                table: "SeguimientoOrdenEstado",
                column: "nIdOrden");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenEstado_OrdenEstado",
                table: "SeguimientoOrdenEstado",
                column: "nIdOrdenEstado");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenEstado_Usuario",
                table: "SeguimientoOrdenEstado",
                column: "nIdUsuario");

            migrationBuilder.CreateIndex(
                name: "fk_OrdenMovimiento_Movimiento",
                table: "OrdenMovimiento",
                column: "nIdMovimiento");

            migrationBuilder.CreateIndex(
                name: "fk_OrdenMovimiento_Orden",
                table: "OrdenMovimiento",
                column: "nIdOrden");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
    name: "SeguimientoOrdenEstado"); 

            migrationBuilder.DropTable(
               name: "SeguimientoOrdenTransferenciaEstado");

            migrationBuilder.DropTable(
                name: "OrdenMovimiento");
        }
    }
}