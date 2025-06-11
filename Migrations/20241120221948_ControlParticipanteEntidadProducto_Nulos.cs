using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ControlParticipanteEntidadProducto_Nulos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "nUltimoCentro",
                table: "EntidadProducto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "nUltimaEntidad",
                table: "ControlParticipante",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nUltimaEntidad",
                table: "ControlParticipante");

            migrationBuilder.AlterColumn<int>(
                name: "nUltimoCentro",
                table: "EntidadProducto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
