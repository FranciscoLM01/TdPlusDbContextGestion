using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TablesCentroCostoAndMoreAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControlParticipante",
                columns: table => new
                {
                    nIdControlParticipante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdTipoParticipante = table.Column<int>(type: "int", nullable: false),
                    nClaveSpei = table.Column<int>(type: "int", nullable: false),
                    nConstante = table.Column<int>(type: "int", nullable: false),
                    nLimiteConstante = table.Column<int>(type: "int", nullable: false),
                    nUltimaEntidad = table.Column<int>(type: "int", nullable: false),
                    nLongitudEntidad = table.Column<int>(type: "int", nullable: false),
                    nLimiteEntidad = table.Column<int>(type: "int", nullable: false),
                    nLongitudCentro = table.Column<int>(type: "int", nullable: false),
                    nLongitudIdentificadorCuenta = table.Column<int>(type: "int", nullable: false),
                    nLongitudVerificador = table.Column<int>(type: "int", nullable: false),
                    bAgotado = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlParticipante", x => x.nIdControlParticipante);
                    table.ForeignKey(
                        name: "fk_ControlParticipante_TipoParticipante",
                        column: x => x.nIdTipoParticipante,
                        principalTable: "TipoParticipante",
                        principalColumn: "nIdTipoParticipante",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Entidad",
                columns: table => new
                {
                    nIdEntidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdControlParticipante = table.Column<int>(type: "int", nullable: false),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    Alias = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Esta columna corresponde al Alias de la entidad"),
                    nConstante = table.Column<int>(type: "int", nullable: false),
                    nEntidad = table.Column<int>(type: "int", nullable: false),
                    sEntidad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    bPrincipal = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidad", x => x.nIdEntidad);
                    table.ForeignKey(
                        name: "fk_Entidad_ControlParticipante",
                        column: x => x.nIdControlParticipante,
                        principalTable: "ControlParticipante",
                        principalColumn: "nIdControlParticipante",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Entidad_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EntidadProducto",
                columns: table => new
                {
                    nIdEntidadProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdEntidad = table.Column<int>(type: "int", nullable: false),
                    nIdProductoFinanciero = table.Column<int>(type: "int", nullable: false),
                    nUltimoCentro = table.Column<int>(type: "int", nullable: false),
                    nLimiteCentroCosto = table.Column<int>(type: "int", nullable: false),
                    sCadenaBaseEntidad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadProducto", x => x.nIdEntidadProducto);
                    table.ForeignKey(
                        name: "fk_EntidadProducto_Entidad",
                        column: x => x.nIdEntidad,
                        principalTable: "Entidad",
                        principalColumn: "nIdEntidad",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CentroCosto",
                columns: table => new
                {
                    nIdCentroCosto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdEntidadProducto = table.Column<int>(type: "int", nullable: false),
                    nTipoCentro = table.Column<int>(type: "int", nullable: false),
                    Alias = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    nCentro = table.Column<int>(type: "int", nullable: false),
                    sCentro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    nUltimoIdentificadorCta = table.Column<int>(type: "int", nullable: false),
                    nLimiteIdentificadorCta = table.Column<int>(type: "int", nullable: false),
                    sCadenaBaseCentro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    bPrincipal = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroCosto", x => x.nIdCentroCosto);
                    table.ForeignKey(
                        name: "fk_CentroCosto_EntidadProducto",
                        column: x => x.nIdEntidadProducto,
                        principalTable: "EntidadProducto",
                        principalColumn: "nIdEntidadProducto",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CuentaClabe",
                columns: table => new
                {
                    nIdCuentaClabe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdCentroCosto = table.Column<int>(type: "int", nullable: false),
                    nIdentificadorCta = table.Column<int>(type: "int", nullable: false),
                    sIdentificadorCta = table.Column<string>(type: "longtext", nullable: false),
                    sCadenaBaseCta = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    nDigitoVerificador = table.Column<int>(type: "int", nullable: false),
                    sCuentaClabe = table.Column<string>(type: "longtext", nullable: false),
                    bReutilizar = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    nIdStatus = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaClabe", x => x.nIdCuentaClabe);
                    table.ForeignKey(
                        name: "fk_CuentaClabe_CentroCosto",
                        column: x => x.nIdCentroCosto,
                        principalTable: "CentroCosto",
                        principalColumn: "nIdCentroCosto",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_CentroCosto_EntidadProducto",
                table: "CentroCosto",
                column: "nIdEntidadProducto");

            migrationBuilder.CreateIndex(
                name: "fk_ControlParticipante_TipoParticipante",
                table: "ControlParticipante",
                column: "nIdTipoParticipante");

            migrationBuilder.CreateIndex(
                name: "fk_CuentaClabe_CentroCosto",
                table: "CuentaClabe",
                column: "nIdCentroCosto");

            migrationBuilder.CreateIndex(
                name: "fk_Entidad_ControlParticipante",
                table: "Entidad",
                column: "nIdControlParticipante");

            migrationBuilder.CreateIndex(
                name: "fk_Entidad_Participante",
                table: "Entidad",
                column: "nIdParticipante");

            migrationBuilder.CreateIndex(
                name: "fk_EntidadProducto_Entidad",
                table: "EntidadProducto",
                column: "nIdEntidad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentaClabe");

            migrationBuilder.DropTable(
                name: "CentroCosto");

            migrationBuilder.DropTable(
                name: "EntidadProducto");

            migrationBuilder.DropTable(
                name: "Entidad");

            migrationBuilder.DropTable(
                name: "ControlParticipante");
        }
    }
}
