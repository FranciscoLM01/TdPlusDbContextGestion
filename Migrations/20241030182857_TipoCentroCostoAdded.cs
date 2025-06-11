using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TipoCentroCostoAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nIdTipoCentroCosto",
                table: "CentroCosto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoCentroCosto",
                columns: table => new
                {
                    nIdTipoCentroCosto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    sDescripcion = table.Column<string>(type: "longtext", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCentroCosto", x => x.nIdTipoCentroCosto);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CentroCosto_nIdTipoCentroCosto",
                table: "CentroCosto",
                column: "nIdTipoCentroCosto");

            migrationBuilder.AddForeignKey(
                name: "FK_CentroCosto_TipoCentroCosto_nIdTipoCentroCosto",
                table: "CentroCosto",
                column: "nIdTipoCentroCosto",
                principalTable: "TipoCentroCosto",
                principalColumn: "nIdTipoCentroCosto",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CentroCosto_TipoCentroCosto_nIdTipoCentroCosto",
                table: "CentroCosto");

            migrationBuilder.DropTable(
                name: "TipoCentroCosto");

            migrationBuilder.DropIndex(
                name: "IX_CentroCosto_nIdTipoCentroCosto",
                table: "CentroCosto");

            migrationBuilder.DropColumn(
                name: "nIdTipoCentroCosto",
                table: "CentroCosto");
        }
    }
}
