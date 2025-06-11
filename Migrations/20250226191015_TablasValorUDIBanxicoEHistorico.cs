using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TablasValorUDIBanxicoEHistorico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricoValorUDIBanxico",
                columns: table => new
                {
                    IdHistorico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    dFecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    nValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoValorUDIBanxico", x => x.IdHistorico);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ValorUDIBanxico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    dFecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    nValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValorUDIBanxico", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoValorUDIBanxico_dFecha",
                table: "HistoricoValorUDIBanxico",
                column: "dFecha",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ValorUDIBanxico_dFecha",
                table: "ValorUDIBanxico",
                column: "dFecha",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoValorUDIBanxico");

            migrationBuilder.DropTable(
                name: "ValorUDIBanxico");
        }
    }
}
