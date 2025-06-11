using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IdentificarOrden : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
