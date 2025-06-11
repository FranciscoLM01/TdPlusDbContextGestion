using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _20241030154800_ParticipanteNuevosCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dFechaIngreso",
                table: "Participante",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Fecha en la cual se registró la entidad.");

            migrationBuilder.AddColumn<int>(
                name: "nNumeroEntidad",
                table: "Participante",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Número identificador de la entidad");

            migrationBuilder.AddColumn<string>(
                name: "sContacto",
                table: "Participante",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Contacto asociado a la entidad");

            migrationBuilder.AddColumn<string>(
                name: "sCorreo",
                table: "Participante",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Correo de contacto de la entidad");

            migrationBuilder.AddColumn<string>(
                name: "sNombre",
                table: "Participante",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Número generañ de la entidad");

            migrationBuilder.AddColumn<string>(
                name: "sTelefono",
                table: "Participante",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                comment: "Teléfono asociado a la entidad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dFechaIngreso",
                table: "Participante");

            migrationBuilder.DropColumn(
                name: "nNumeroEntidad",
                table: "Participante");

            migrationBuilder.DropColumn(
                name: "sContacto",
                table: "Participante");

            migrationBuilder.DropColumn(
                name: "sCorreo",
                table: "Participante");

            migrationBuilder.DropColumn(
                name: "sNombre",
                table: "Participante");

            migrationBuilder.DropColumn(
                name: "sTelefono",
                table: "Participante");
        }
    }
}
