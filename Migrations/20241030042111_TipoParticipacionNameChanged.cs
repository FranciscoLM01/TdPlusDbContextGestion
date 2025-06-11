using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TipoParticipacionNameChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoFinanciero_TipoParticipante_nIdTipoParticipante",
                table: "ProductoFinanciero");

            migrationBuilder.RenameTable(
                name: "TipoParticipante",
                newName: "TipoParticipacion");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoFinanciero_TipoParticipacion_nIdTipoParticipante",
                table: "ProductoFinanciero",
                column: "nIdTipoParticipante",
                principalTable: "TipoParticipacion",
                principalColumn: "nIdTipoParticipante",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoFinanciero_TipoParticipacion_nIdTipoParticipante",
                table: "ProductoFinanciero");

            migrationBuilder.RenameTable(
                name: "TipoParticipacion",
                newName: "TipoParticipante");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoFinanciero_TipoParticipante_nIdTipoParticipante",
                table: "ProductoFinanciero",
                column: "nIdTipoParticipante",
                principalTable: "TipoParticipante",
                principalColumn: "nIdTipoParticipante",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
