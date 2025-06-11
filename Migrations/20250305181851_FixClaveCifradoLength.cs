using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixClaveCifradoLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                oldComment: "Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes. día, hora, minutos, segundos y milisegundos."
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                oldComment: "Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes. día, hora, minutos, segundos y milisegundos."
            );
        }
    }
}
