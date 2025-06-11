using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDevolucionesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devoluciones",
                columns: table => new
                {
                    nIdDevolucion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    nIdTipoOperacion = table.Column<int>(type: "int", nullable: false),
                    nIdTipoMovimiento = table.Column<int>(type: "int", nullable: false),
                    nMonto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    sConcepto = table.Column<string>(type: "longtext", nullable: false),
                    nIdCausaDevolucion = table.Column<int>(type: "int", nullable: false),
                    sClaveRastreo = table.Column<string>(type: "longtext", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucion", x => x.nIdDevolucion);
                    table.ForeignKey(
                        name: "FK_Devoluciones_CausaDevolucion_nIdCausaDevolucion",
                        column: x => x.nIdCausaDevolucion,
                        principalTable: "CausaDevolucion",
                        principalColumn: "nClaveCausaDevolucion",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_Devolucion_Causadevolucion",
                table: "Devoluciones",
                column: "nIdCausaDevolucion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devoluciones");
        }
    }
}
