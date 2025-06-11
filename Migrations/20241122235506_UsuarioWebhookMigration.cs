using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioWebhookMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioWebhook",
                columns: table => new
                {
                    nIdUsuarioWebhook = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(type: "longtext", nullable: false),
                    Auth = table.Column<string>(type: "longtext", nullable: false),
                    nIdCreadoPor = table.Column<int>(type: "int", nullable: false),
                    nIdCentroCostos = table.Column<int>(type: "int", nullable: true),
                    nIdActualizadoPor = table.Column<int>(type: "int", nullable: true),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioWebhook", x => x.nIdUsuarioWebhook);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioWebhook");
        }
    }
}
