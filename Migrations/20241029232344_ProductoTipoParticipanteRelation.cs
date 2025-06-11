using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductoTipoParticipanteRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nIdentificador",
                table: "TipoParticipante",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "sFormato",
                table: "TipoParticipante",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "nIdTipoParticipante",
                table: "ProductoFinanciero",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductoFinanciero_nIdTipoParticipante",
                table: "ProductoFinanciero",
                column: "nIdTipoParticipante");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoFinanciero_TipoParticipante_nIdTipoParticipante",
                table: "ProductoFinanciero",
                column: "nIdTipoParticipante",
                principalTable: "TipoParticipante",
                principalColumn: "nIdTipoParticipante",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoFinanciero_TipoParticipante_nIdTipoParticipante",
                table: "ProductoFinanciero");

            migrationBuilder.DropIndex(
                name: "IX_ProductoFinanciero_nIdTipoParticipante",
                table: "ProductoFinanciero");

            migrationBuilder.DropColumn(
                name: "nIdentificador",
                table: "TipoParticipante");

            migrationBuilder.DropColumn(
                name: "sFormato",
                table: "TipoParticipante");

            migrationBuilder.DropColumn(
                name: "nIdTipoParticipante",
                table: "ProductoFinanciero");
        }
    }
}
