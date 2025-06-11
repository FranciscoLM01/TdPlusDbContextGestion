using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _20241031175330_CambiaCamponUltimaEntidadEnControlParticipante_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nUltimaEntidad",
                table: "ControlParticipante");

            migrationBuilder.AddColumn<string>(
                name: "sUltimaEntidad",
                table: "ControlParticipante",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sUltimaEntidad",
                table: "ControlParticipante");

            migrationBuilder.AddColumn<int>(
                name: "nUltimaEntidad",
                table: "ControlParticipante",
                type: "int",
                nullable: true);
        }
    }
}
