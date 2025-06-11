using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioWebhookParticipant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nIdParticipante",
                table: "UsuarioWebhook",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioWebhook_nIdCentroCostos",
                table: "UsuarioWebhook",
                column: "nIdCentroCostos");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioWebhook_nIdParticipante",
                table: "UsuarioWebhook",
                column: "nIdParticipante");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioWebhook_CentroCosto_nIdCentroCostos",
                table: "UsuarioWebhook",
                column: "nIdCentroCostos",
                principalTable: "CentroCosto",
                principalColumn: "nIdCentroCosto");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioWebhook_Participante_nIdParticipante",
                table: "UsuarioWebhook",
                column: "nIdParticipante",
                principalTable: "Participante",
                principalColumn: "nIdParticipante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioWebhook_CentroCosto_nIdCentroCostos",
                table: "UsuarioWebhook");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioWebhook_Participante_nIdParticipante",
                table: "UsuarioWebhook");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioWebhook_nIdCentroCostos",
                table: "UsuarioWebhook");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioWebhook_nIdParticipante",
                table: "UsuarioWebhook");

            migrationBuilder.DropColumn(
                name: "nIdParticipante",
                table: "UsuarioWebhook");
        }
    }
}
