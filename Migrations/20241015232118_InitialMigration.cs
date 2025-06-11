using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CausaDevolucion",
                columns: table => new
                {
                    nClaveCausaDevolucion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CausaDevolucion", x => x.nClaveCausaDevolucion);
                },
                comment: "Esta tabla corresponde a las posibles causas de devolución cuando se hace un proceso de devolución de una orden")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClaveCifrado",
                columns: table => new
                {
                    nIdClaveCifrado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sIdentificador = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    sClaveSimetrica = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    sVectorInicializacion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaveCifrado", x => x.nIdClaveCifrado);
                },
                comment: "Esta tabla almacenará las claves de cfrado (clave simétrica y vector de inicialización) para el algoritmo AES 128 en modo CBC y llevar a cabo el cifrado y descifrado de los datos.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    nIdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sClave = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false),
                    sCodigoEstado = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    nIdCatPais = table.Column<long>(type: "bigint", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.nIdEstado);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GiroNegocio",
                columns: table => new
                {
                    nIdGiroNegocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiroNegocio", x => x.nIdGiroNegocio);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Institucion",
                columns: table => new
                {
                    nClaveInstitucion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sDescripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institucion", x => x.nClaveInstitucion);
                },
                comment: "Esta tabla almacenará el catalogos de los participantes o instituciones que están registrados en Banxico.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpcionMenu",
                columns: table => new
                {
                    nIdMenuOpcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    sRuta = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Esta columna corresponde a la URL o ruta relativa de la opción. Está precedida por una barra diagonal y, por convención, debe se escribirse en minusculas sin caracteres especiales ni espacios."),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionMenu", x => x.nIdMenuOpcion);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdenEstado",
                columns: table => new
                {
                    nIdOrdenEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nClave = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenEstado", x => x.nIdOrdenEstado);
                },
                comment: "Esta tabla corresponde a los posibles estatus que puede tomar una orden, por ejemplo, la orden puede estar en Cola de envío, Liquidado, Abonado, etc.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdenTransferenciaEstado",
                columns: table => new
                {
                    nIdOrdenTransferenciaEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenTransferenciaEstado", x => x.nIdOrdenTransferenciaEstado);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parametro",
                columns: table => new
                {
                    nIdParametro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sClave = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Esta columna se refiere al nombre del parámetro, tiene que ser único y no debe de tener espacios ni caracteres especiales"),
                    sModulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Esta columna se refiere a la aplicación o módulo que hace uso del parámetro o en qué aplicaciones o modulos se aplicará el parámetro"),
                    sDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Esta columna se refiere a  la descripción dónde se explique el uso del parámetro"),
                    sValor = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Esta columna se refiere al valor del parámetro"),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametro", x => x.nIdParametro);
                },
                comment: "Esta tabla se refiere a la parametrización de valores y funciones que requieran los aplicativos.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    nIdPerfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.nIdPerfil);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plaza",
                columns: table => new
                {
                    nIdPlaza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nClave = table.Column<int>(type: "int", nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plaza", x => x.nIdPlaza);
                },
                comment: "Esta tabla corresponde a los números de plaza dónde se está aperturando una cuenta de un participante directo.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoFinanciero",
                columns: table => new
                {
                    nIdProductoFinanciero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sClave = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: false, comment: "Esta columna corresponde al identificador único del producto financiero"),
                    sDescripción = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Esta columna corresponde a la descripción del producto financiero"),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Esta columna corresponde a la fecha y hora de actualización del registro.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoFinanciero", x => x.nIdProductoFinanciero);
                },
                comment: "Esta tabla corresponde al catalogo de productos financieros aplicables a los servicios de participación indirecta")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prospecto",
                columns: table => new
                {
                    nIdProspecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoPaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoMaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sTelefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    sCorreoElectronico = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sObservaciones = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prospecto", x => x.nIdProspecto);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seccion",
                columns: table => new
                {
                    nIdSeccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seccion", x => x.nIdSeccion);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SeccionDatoEstado",
                columns: table => new
                {
                    nIdSeccionDatoEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeccionDatoEstado", x => x.nIdSeccionDatoEstado);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Secuencia",
                columns: table => new
                {
                    nIdSecuencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secuencia", x => x.nIdSecuencia);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SolicitudEstado",
                columns: table => new
                {
                    nIdSolicitudEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudEstado", x => x.nIdSolicitudEstado);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoCuenta",
                columns: table => new
                {
                    nClaveTipoCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Esta columna corresponde al nombre del tipo de cuenta, por ejemplo, si el tipo de cuenta es CLABE, Número celular, entro otros."),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP", comment: "Esta columna corresponde a la fecha y hora de inserción del registro."),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Esta columna corresponde a la fecha y hora de actualización del registro.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuenta", x => x.nClaveTipoCuenta);
                },
                comment: "Esta tabla almacenará el catalógo de tipos de cuenta, por ejemplo, si el tipo de cuenta es una CLABE, tarjeta de débito o un teléfono celular.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoMovimiento",
                columns: table => new
                {
                    nIdTipoMovimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, comment: "Este campo almacena el tipo de movimiento, por ejemplo, C corrresponde  a Crédito y D a Débito."),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMovimiento", x => x.nIdTipoMovimiento);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoOperacion",
                columns: table => new
                {
                    nIdTipoOperacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Esta columna corresponde al tipo de operación, por ejemplo, si el tipo de operación es de tipo C (Crédito) corresponde  a un cargo y si es D (Débito) corresponde a un abono."),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOperacion", x => x.nIdTipoOperacion);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPago",
                columns: table => new
                {
                    nClaveTipoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPago", x => x.nClaveTipoPago);
                },
                comment: "Esta tabla almacenará los tipos de pago de Banxico, por ejemplo, Tercero a tercero, Devolución, Retorno, entre otros.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoParticipante",
                columns: table => new
                {
                    nIdTipoParticipante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "Esta columna se refiere al nombre del tipo de participante: directo o indirecto"),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoParticipante", x => x.nIdTipoParticipante);
                },
                comment: "Esta corresponde al tipo de participante, por ejemplo, directo o indirecto")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoSociedad",
                columns: table => new
                {
                    nIdTipoSociedad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sDescripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSociedad", x => x.nIdTipoSociedad);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioPermisos",
                columns: table => new
                {
                    nIdUsuarioPermisos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sNombre = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    sDetalle = table.Column<string>(type: "text", unicode: false, nullable: true),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPermisos", x => x.nIdUsuarioPermisos);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    nIdMunicipio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdEstado = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    nCodigoCiudad = table.Column<int>(type: "int", nullable: true),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.nIdMunicipio);
                    table.ForeignKey(
                        name: "fk_municipio_estado",
                        column: x => x.nIdEstado,
                        principalTable: "Estado",
                        principalColumn: "nIdEstado");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpcionMenuAccion",
                columns: table => new
                {
                    nIdOpcionMenuAccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdOpcionMenu = table.Column<int>(type: "int", nullable: false),
                    nIdAccion = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionMenuAccion", x => x.nIdOpcionMenuAccion);
                    table.ForeignKey(
                        name: "fk_OpcionMenuAccion_OpcionMenu",
                        column: x => x.nIdOpcionMenu,
                        principalTable: "OpcionMenu",
                        principalColumn: "nIdMenuOpcion");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpcionMenuJerarquica",
                columns: table => new
                {
                    nIdOpcionMenuPadre = table.Column<int>(type: "int", nullable: false),
                    nIdOpcionMenuHija = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionMenuJerarquica", x => new { x.nIdOpcionMenuPadre, x.nIdOpcionMenuHija });
                    table.ForeignKey(
                        name: "fk_OpcionMenuJerarquica_OpcionMenu",
                        column: x => x.nIdOpcionMenuPadre,
                        principalTable: "OpcionMenu",
                        principalColumn: "nIdMenuOpcion");
                    table.ForeignKey(
                        name: "fk_OpcionMenuJerarquica_OpcionMenu_0",
                        column: x => x.nIdOpcionMenuHija,
                        principalTable: "OpcionMenu",
                        principalColumn: "nIdMenuOpcion");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AutorizacionOpcionMenu",
                columns: table => new
                {
                    nIdOpcionMenu = table.Column<int>(type: "int", nullable: false),
                    nIdPerfil = table.Column<int>(type: "int", nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacionOpcionMenu", x => new { x.nIdOpcionMenu, x.nIdPerfil });
                    table.ForeignKey(
                        name: "fk_AutorizacionOpcionMenu_OpcionMenu",
                        column: x => x.nIdOpcionMenu,
                        principalTable: "OpcionMenu",
                        principalColumn: "nIdMenuOpcion");
                    table.ForeignKey(
                        name: "fk_AutorizacionOpcionMenu_Perfil",
                        column: x => x.nIdPerfil,
                        principalTable: "Perfil",
                        principalColumn: "nIdPerfil");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    nIdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sExternalId = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    sCorreoElectronico = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    nIdPerfil = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoPaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoMaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sTelefono = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    nIdTipoUsuario = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.nIdUsuario);
                    table.ForeignKey(
                        name: "fk_Usuario_Perfil",
                        column: x => x.nIdPerfil,
                        principalTable: "Perfil",
                        principalColumn: "nIdPerfil");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SeccionDato",
                columns: table => new
                {
                    nIdSeccionDato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdSeccion = table.Column<int>(type: "int", nullable: false),
                    sIdentificador = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: false, comment: "Esta columna corresponde al identificador del control, ya sea, un campo de texto, una lista desplegable. Con el proposito de identificar de que control viene la data o información."),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeccionDato", x => x.nIdSeccionDato);
                    table.ForeignKey(
                        name: "fk_SeccionDato_Seccion",
                        column: x => x.nIdSeccion,
                        principalTable: "Seccion",
                        principalColumn: "nIdSeccion");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdProspecto = table.Column<int>(type: "int", nullable: false),
                    nIdSolicitudEstado = table.Column<int>(type: "int", nullable: false),
                    bValidacionComercialCumplimiento = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sObservaciones = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    dFechaAprobacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.nIdSolicitud);
                    table.ForeignKey(
                        name: "fk_SolicitudN_ProspectoN",
                        column: x => x.nIdProspecto,
                        principalTable: "Prospecto",
                        principalColumn: "nIdProspecto");
                    table.ForeignKey(
                        name: "fk_SolicitudN_SolicitudEstado",
                        column: x => x.nIdSolicitudEstado,
                        principalTable: "SolicitudEstado",
                        principalColumn: "nIdSolicitudEstado");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CuentaConcentradora",
                columns: table => new
                {
                    nIdCuentaConcentradora = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nClaveTipoCuenta = table.Column<int>(type: "int", nullable: false),
                    nSaldo = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    sAlias = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, comment: "Esta columna corresponde al identificador (alias) de una cuenta concentradora. Por ejemplo: cuantacontradoraclienteindirecto1 Producto"),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaConcentradora", x => x.nIdCuentaConcentradora);
                    table.ForeignKey(
                        name: "fk_CuentaConcentradora_TipoCuenta",
                        column: x => x.nClaveTipoCuenta,
                        principalTable: "TipoCuenta",
                        principalColumn: "nClaveTipoCuenta");
                },
                comment: "Esta tabla tiene el propósito de almacenar las cuentas de los participantes indirectos y las cuentas de los clientes de los participantes indirectos.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Participante",
                columns: table => new
                {
                    nIdParticipante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdCuentaConcentradora = table.Column<int>(type: "int", nullable: false),
                    nIdTipoParticipante = table.Column<int>(type: "int", nullable: false, comment: "Esta columna corresponde al tipo de participante, ya sea directo o indirecto"),
                    sRFC = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    sRazonSocial = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participante", x => x.nIdParticipante);
                    table.ForeignKey(
                        name: "fk_Participante_TipoParticipante",
                        column: x => x.nIdTipoParticipante,
                        principalTable: "TipoParticipante",
                        principalColumn: "nIdTipoParticipante");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpcionMenuUsuarioPermisos",
                columns: table => new
                {
                    nIdMenuOpcion = table.Column<int>(type: "int", nullable: false),
                    nIdUsuarioPermisos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionMenuUsuarioPermisos", x => new { x.nIdMenuOpcion, x.nIdUsuarioPermisos });
                    table.ForeignKey(
                        name: "FK_6ADY",
                        column: x => x.nIdMenuOpcion,
                        principalTable: "OpcionMenu",
                        principalColumn: "nIdMenuOpcion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_6V5L",
                        column: x => x.nIdUsuarioPermisos,
                        principalTable: "UsuarioPermisos",
                        principalColumn: "nIdUsuarioPermisos",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Colonia",
                columns: table => new
                {
                    nIdColonia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdMunicipio = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    sNombreEstado = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    sNombreMunicipio = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    sTipoAsentamiento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sTipoZona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    nCodigoPostal = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colonia", x => x.nIdColonia);
                    table.ForeignKey(
                        name: "fk_colonia_municipio",
                        column: x => x.nIdMunicipio,
                        principalTable: "Municipio",
                        principalColumn: "nIdMunicipio");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OpcionMenuAccionUsuarioPermisos",
                columns: table => new
                {
                    nIdOpcionMenuAccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdUsuarioPermisos = table.Column<int>(type: "int", nullable: false),
                    OpcionMenuAccionnIdOpcionMenuAccion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionMenuAccionUsuarioPermisos", x => x.nIdOpcionMenuAccion);
                    table.ForeignKey(
                        name: "FK_OpcionMenuAccionUsuarioPermisos_OpcionMenuAccion_OpcionMenuA~",
                        column: x => x.OpcionMenuAccionnIdOpcionMenuAccion,
                        principalTable: "OpcionMenuAccion",
                        principalColumn: "nIdOpcionMenuAccion");
                    table.ForeignKey(
                        name: "FK_OpcionMenuAccionUsuarioPermisos_UsuarioPermisos_nIdUsuarioPe~",
                        column: x => x.nIdUsuarioPermisos,
                        principalTable: "UsuarioPermisos",
                        principalColumn: "nIdUsuarioPermisos",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioPermisoAccion",
                columns: table => new
                {
                    nIdUsuario = table.Column<int>(type: "int", nullable: false),
                    nIdPerfil = table.Column<int>(type: "int", nullable: false),
                    nIdOpcionMenuAccion = table.Column<int>(type: "int", nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPermisoAccion", x => new { x.nIdOpcionMenuAccion, x.nIdPerfil, x.nIdUsuario });
                    table.ForeignKey(
                        name: "fk_UsuarioPermisoAccion_OpcionMenuAccion",
                        column: x => x.nIdOpcionMenuAccion,
                        principalTable: "OpcionMenuAccion",
                        principalColumn: "nIdOpcionMenuAccion");
                    table.ForeignKey(
                        name: "fk_UsuarioPermisoAccion_Perfil",
                        column: x => x.nIdPerfil,
                        principalTable: "Perfil",
                        principalColumn: "nIdPerfil");
                    table.ForeignKey(
                        name: "fk_UsuarioPermisoAccion_Usuario",
                        column: x => x.nIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "nIdUsuario");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProspectoDato",
                columns: table => new
                {
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    nIdSeccionDato = table.Column<int>(type: "int", nullable: false),
                    nIdSeccionDatoEstado = table.Column<int>(type: "int", nullable: false),
                    sDato = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectoDato", x => new { x.nIdSolicitud, x.nIdSeccionDato, x.nIdSeccionDatoEstado });
                    table.ForeignKey(
                        name: "fk_ProspectoDatoN_SeccionDato",
                        column: x => x.nIdSeccionDato,
                        principalTable: "SeccionDato",
                        principalColumn: "nIdSeccionDato");
                    table.ForeignKey(
                        name: "fk_ProspectoDatoN_SeccionDatoEstado",
                        column: x => x.nIdSeccionDatoEstado,
                        principalTable: "SeccionDatoEstado",
                        principalColumn: "nIdSeccionDatoEstado");
                    table.ForeignKey(
                        name: "fk_ProspectoDatoN_SolicitudN",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProspectoDocumento",
                columns: table => new
                {
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    nIdSeccionDato = table.Column<int>(type: "int", nullable: false),
                    nIdSeccionDatoEstado = table.Column<int>(type: "int", nullable: false),
                    sDato = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Esta columna corresponde al valor o data del documento"),
                    sKey = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Path = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectoDocumento", x => new { x.nIdSolicitud, x.nIdSeccionDato, x.nIdSeccionDatoEstado });
                    table.ForeignKey(
                        name: "fk_ProspectoDocumentoN_SeccionDato",
                        column: x => x.nIdSeccionDato,
                        principalTable: "SeccionDato",
                        principalColumn: "nIdSeccionDato");
                    table.ForeignKey(
                        name: "fk_ProspectoDocumentoN_SeccionDatoEstado",
                        column: x => x.nIdSeccionDatoEstado,
                        principalTable: "SeccionDatoEstado",
                        principalColumn: "nIdSeccionDatoEstado");
                    table.ForeignKey(
                        name: "fk_ProspectoDocumentoN_SolicitudN",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProspectoPerfiles",
                columns: table => new
                {
                    sCorreoElectronico = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    nIdPerfil = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoPaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoMaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    dFechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    sTelefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectoPerfiles", x => x.sCorreoElectronico);
                    table.ForeignKey(
                        name: "fk_ProspectoPerfiles_Perfil",
                        column: x => x.nIdPerfil,
                        principalTable: "Perfil",
                        principalColumn: "nIdPerfil");
                    table.ForeignKey(
                        name: "fk_ProspectoPerfiles_SolicitudN",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProspectoResponsableCuenta",
                columns: table => new
                {
                    sCorreoElectronico = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoPaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoMaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sTelefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    sExtension = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectoResponsableCuenta", x => x.sCorreoElectronico);
                    table.ForeignKey(
                        name: "fk_ProspectoPerfiles_SolicitudN_2",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProspectoResponsableJuridicoCumplimiento",
                columns: table => new
                {
                    sCorreoElectronico = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoPaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoMaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sTelefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    sExtension = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectoResponsableJuridicoCumplimiento", x => x.sCorreoElectronico);
                    table.ForeignKey(
                        name: "fk_ProspectoPerfiles_SolicitudN_3",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProspectoResponsableOperativo",
                columns: table => new
                {
                    sCorreoElectronico = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoPaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoMaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sTelefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    sExtension = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectoResponsableOperativo", x => x.sCorreoElectronico);
                    table.ForeignKey(
                        name: "fk_ProspectoPerfiles_SolicitudN_0",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProspectoResponsableSistema",
                columns: table => new
                {
                    sCorreoElectronico = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    bAccesoApi = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoMaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sApellidoPaterno = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    sTelefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    sExtension = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectoResponsableSistema", x => x.sCorreoElectronico);
                    table.ForeignKey(
                        name: "fk_ProspectoPerfiles_SolicitudN_1",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SolicitudConfidencialidad",
                columns: table => new
                {
                    nIdSeccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    sDescripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudConfidencialidad", x => x.nIdSeccion);
                    table.ForeignKey(
                        name: "fk_SolicitudConfidencialidad_Solicitud",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SolicitudSeccion",
                columns: table => new
                {
                    nIdSolicitud = table.Column<int>(type: "int", nullable: false),
                    nIdSeccion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudSeccion", x => new { x.nIdSolicitud, x.nIdSeccion });
                    table.ForeignKey(
                        name: "fk_SolicitudSeccion_Seccion",
                        column: x => x.nIdSeccion,
                        principalTable: "Seccion",
                        principalColumn: "nIdSeccion");
                    table.ForeignKey(
                        name: "fk_SolicitudSeccion_SolicitudN",
                        column: x => x.nIdSolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "nIdSolicitud");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    nIdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    nIdCuentaConcentradora = table.Column<int>(type: "int", nullable: false),
                    nClaveCuenta = table.Column<int>(type: "int", nullable: false, comment: "Esta columna corresponde al identificador único del centro de costos o cliente indirecto"),
                    sNombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.nIdCliente);
                    table.ForeignKey(
                        name: "fk_Cliente_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movimiento",
                columns: table => new
                {
                    nIdMovimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    nIdTipoOperacion = table.Column<int>(type: "int", nullable: false),
                    nIdTipoMovimiento = table.Column<int>(type: "int", nullable: false),
                    nSaldoInicial = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Esta columna corresponde al saldo antes de aplicar el movimiento"),
                    nMonto = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    nSaldoFinal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Esta columna corresponde al saldo que queda disponible tomando en cuenta el último saldo disponible menos la diferencia del monto (en este caso, ya sea, un cargo o un abono)."),
                    sConcepto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimiento", x => x.nIdMovimiento);
                    table.ForeignKey(
                        name: "fk_MovimientoEstadoCuenta_TipoMovimiento",
                        column: x => x.nIdTipoMovimiento,
                        principalTable: "TipoMovimiento",
                        principalColumn: "nIdTipoMovimiento");
                    table.ForeignKey(
                        name: "fk_MovimientoEstadoCuenta_TipoOperacion",
                        column: x => x.nIdTipoOperacion,
                        principalTable: "TipoOperacion",
                        principalColumn: "nIdTipoOperacion");
                    table.ForeignKey(
                        name: "fk_Movimiento_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NotificacionWebhook",
                columns: table => new
                {
                    nIdNotificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdParticipante = table.Column<int>(type: "int", nullable: true),
                    nDescripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificacionWebhook", x => x.nIdNotificacion);
                    table.ForeignKey(
                        name: "fk_NotificacionWebhook_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ordenante",
                columns: table => new
                {
                    nIdOrdenante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false, comment: "Esta columna corresponde al ID único cuando se agregue un participante directo y un participante indirecto"),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenante", x => x.nIdOrdenante);
                    table.ForeignKey(
                        name: "fk_Ordenante_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante");
                },
                comment: "Esta tabla almacena los ordenantes para las ordenes.")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ParticipanteCuentaConcentradora",
                columns: table => new
                {
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    nIdCuentaConcentradora = table.Column<int>(type: "int", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipanteCuentaConcentradora", x => new { x.nIdParticipante, x.nIdCuentaConcentradora, x.bActivo });
                    table.ForeignKey(
                        name: "fk_PaInCuentaConcentradora_CuentaConcentradora",
                        column: x => x.nIdCuentaConcentradora,
                        principalTable: "CuentaConcentradora",
                        principalColumn: "nIdCuentaConcentradora");
                    table.ForeignKey(
                        name: "fk_ParticipanteCuentaConcentradora_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ParticipanteInicioSaldoOperacion",
                columns: table => new
                {
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    dFechaOperacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    nSaldoInicio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Esta columna hace referencia al saldo inicial del participante conforme cambia la fecha de operación"),
                    dFecRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipanteInicioSaldoOperacion", x => new { x.nIdParticipante, x.dFechaOperacion });
                    table.ForeignKey(
                        name: "fk_ParticipanteInicioSaldoOperacion_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante");
                },
                comment: "Esta es la tabla que almacena el saldo del participante en función del cambio de la fecha de operación del SPEI")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SaldoReserva",
                columns: table => new
                {
                    nIdSaldoReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdParticipante = table.Column<int>(type: "int", nullable: true),
                    nSaldoActual = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    nSaldoReservado = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Esta columna corresponde a la suma de los montos de las ordenes"),
                    nTotalTransferido = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Esta columna corresponde al monto total de las ordenes que ya se han liquidado"),
                    nSaldoReservadoDevolver = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Esta columna es calculada haciendo una resta o diferencia con la colummna nSaldoReservado y nTotalTransferido (nSaldoReservado - nTotalTransferido)"),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaldoReserva", x => x.nIdSaldoReserva);
                    table.ForeignKey(
                        name: "fk_SaldoReserva_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    nIdDireccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdEstado = table.Column<int>(type: "int", nullable: false),
                    nIdMunicipio = table.Column<int>(type: "int", nullable: false),
                    nIdColonia = table.Column<int>(type: "int", nullable: false),
                    sCalle = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    sNumeroExterior = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    sNumeroInterior = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    nCodigoPostal = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.nIdDireccion);
                    table.ForeignKey(
                        name: "fk_direccion_colonia",
                        column: x => x.nIdColonia,
                        principalTable: "Colonia",
                        principalColumn: "nIdColonia");
                    table.ForeignKey(
                        name: "fk_direccion_estado",
                        column: x => x.nIdEstado,
                        principalTable: "Estado",
                        principalColumn: "nIdEstado");
                    table.ForeignKey(
                        name: "fk_direccion_municipio",
                        column: x => x.nIdMunicipio,
                        principalTable: "Municipio",
                        principalColumn: "nIdMunicipio");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BeneficiarioCliente",
                columns: table => new
                {
                    nIdBeneficiarioCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdCliente = table.Column<int>(type: "int", nullable: false),
                    nTipoCuenta = table.Column<int>(type: "int", nullable: false),
                    nClaveInstitucion = table.Column<int>(type: "int", nullable: false),
                    sNombre = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    sCuenta = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiarioCliente", x => x.nIdBeneficiarioCliente);
                    table.ForeignKey(
                        name: "fk_BeneficiarioClienteIndirecto_ClienteIndirecto",
                        column: x => x.nIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "nIdCliente");
                    table.ForeignKey(
                        name: "fk_BeneficiarioCliente_Institucion",
                        column: x => x.nClaveInstitucion,
                        principalTable: "Institucion",
                        principalColumn: "nClaveInstitucion");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClienteCuentaConcentradora",
                columns: table => new
                {
                    nIdCliente = table.Column<int>(type: "int", nullable: false),
                    nIdCuentaConcentradora = table.Column<int>(type: "int", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteCuentaConcentradora", x => new { x.nIdCliente, x.nIdCuentaConcentradora, x.bActivo });
                    table.ForeignKey(
                        name: "fk_ClienteIndiCuentaConcentradora_ClienteIndi",
                        column: x => x.nIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "nIdCliente");
                    table.ForeignKey(
                        name: "fk_ClienteIndiCuentaConcentradora_CuentaConcentradora",
                        column: x => x.nIdCuentaConcentradora,
                        principalTable: "CuentaConcentradora",
                        principalColumn: "nIdCuentaConcentradora");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CuentaCliente",
                columns: table => new
                {
                    nIdCliente = table.Column<int>(type: "int", nullable: false),
                    nClaveTipoCuenta = table.Column<int>(type: "int", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    sCuenta = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    sBanco = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaCliente", x => new { x.nIdCliente, x.nClaveTipoCuenta });
                    table.ForeignKey(
                        name: "fk_CuentaClienteIndirecto_TipoCuenta",
                        column: x => x.nClaveTipoCuenta,
                        principalTable: "TipoCuenta",
                        principalColumn: "nClaveTipoCuenta");
                    table.ForeignKey(
                        name: "fk_CuentaCliente_Cliente",
                        column: x => x.nIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "nIdCliente");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdenTransferencia",
                columns: table => new
                {
                    nIdOrdenTransferencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdOrdenante = table.Column<int>(type: "int", nullable: false, comment: "Esta columna se refiere al ordenante de la orden de transferencia, es importante señalar que un ordenante puede ser un participante directo o un participante indirecto"),
                    nClaveTipoPago = table.Column<int>(type: "int", nullable: false),
                    nNumeroEntidad = table.Column<int>(type: "int", nullable: false, comment: "Esta columna corrresponde al identificador único que se le asigna a un participante indirecto"),
                    nClavePeticion = table.Column<int>(type: "int", nullable: false, comment: "Corresponde a la clave de petición del request a MEAPI. Por ejemplo, si el objetivo es registrar un pago se hace una petición con número 19."),
                    sClaveCifrado = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, comment: "Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes. día, hora, minutos, segundos y milisegundos."),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenTransferencia", x => x.nIdOrdenTransferencia);
                    table.ForeignKey(
                        name: "fk_OrdenTransferencia_Ordenante",
                        column: x => x.nIdOrdenante,
                        principalTable: "Ordenante",
                        principalColumn: "nIdOrdenante");
                    table.ForeignKey(
                        name: "fk_OrdenTransferencia_TipoPago",
                        column: x => x.nClaveTipoPago,
                        principalTable: "TipoPago",
                        principalColumn: "nClaveTipoPago");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Beneficiario",
                columns: table => new
                {
                    nIdBeneficiario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdParticipante = table.Column<int>(type: "int", nullable: false),
                    nTipoContribuyente = table.Column<sbyte>(type: "tinyint", nullable: false, comment: "Las personas físicas se representan con un 2 y las personas morales con un 1"),
                    sNombre = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    sRFCCURP = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: false, comment: "Según el manual de integración de Banxico, a partir del 10 de abril del 2024, el RFC o CURP será obligatorio."),
                    sCorreo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    sTelefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    nIdDireccion = table.Column<int>(type: "int", nullable: true),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiario", x => x.nIdBeneficiario);
                    table.ForeignKey(
                        name: "fk_Beneficiario_Direccion",
                        column: x => x.nIdDireccion,
                        principalTable: "Direccion",
                        principalColumn: "nIdDireccion");
                    table.ForeignKey(
                        name: "fk_Beneficiario_Participante",
                        column: x => x.nIdParticipante,
                        principalTable: "Participante",
                        principalColumn: "nIdParticipante");
                },
                comment: "Esta tabla tiene el propósito de almacenar la información del beneficiario del otro participante directo al que se le enviará la órden de transferencia")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SeguimientoOrdenTransferenciaEstado",
                columns: table => new
                {
                    nIdOrdenTransferencia = table.Column<int>(type: "int", nullable: false),
                    nIdOrdenTransferenciaEstado = table.Column<int>(type: "int", nullable: false),
                    nIdUsuario = table.Column<int>(type: "int", nullable: false, comment: "El identificar único del usuario actual que afectaría el nuevo estado o status de la orden de transferencia"),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    sMotivo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguimientoOrdenTransferenciaEstado", x => new { x.nIdOrdenTransferencia, x.nIdOrdenTransferenciaEstado, x.nIdUsuario, x.dFecRegistro });
                    table.ForeignKey(
                        name: "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferencia",
                        column: x => x.nIdOrdenTransferencia,
                        principalTable: "OrdenTransferencia",
                        principalColumn: "nIdOrdenTransferencia");
                    table.ForeignKey(
                        name: "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferenciaEstado",
                        column: x => x.nIdOrdenTransferenciaEstado,
                        principalTable: "OrdenTransferenciaEstado",
                        principalColumn: "nIdOrdenTransferenciaEstado");
                    table.ForeignKey(
                        name: "fk_SeguimientoOrdenTransferenciaEstado_Usuario",
                        column: x => x.nIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "nIdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BeneficiarioCuenta",
                columns: table => new
                {
                    nIdBeneficiario = table.Column<int>(type: "int", nullable: false),
                    nClaveTipoCuenta = table.Column<int>(type: "int", nullable: false),
                    sCuenta = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, comment: "Corresponde al número de cuenta (CLABE)"),
                    nClaveInstitucion = table.Column<int>(type: "int", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    sBanco = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, comment: "Nombre del banco"),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiarioCuenta", x => new { x.nIdBeneficiario, x.nClaveTipoCuenta, x.sCuenta });
                    table.ForeignKey(
                        name: "fk_BeneficiarioCuenta_Institucion",
                        column: x => x.nClaveInstitucion,
                        principalTable: "Institucion",
                        principalColumn: "nClaveInstitucion");
                    table.ForeignKey(
                        name: "fk_BeneficiarioCuenta_TipoCuenta",
                        column: x => x.nClaveTipoCuenta,
                        principalTable: "TipoCuenta",
                        principalColumn: "nClaveTipoCuenta");
                    table.ForeignKey(
                        name: "fk_beneficiariocuenta_beneficiario",
                        column: x => x.nIdBeneficiario,
                        principalTable: "Beneficiario",
                        principalColumn: "nIdBeneficiario");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    nIdOrden = table.Column<int>(type: "int", nullable: false, comment: "Esta columna corresponde a la llave primaria de la tabla. Esta columna es auto incrementable.")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nIdBeneficiario = table.Column<int>(type: "int", nullable: false),
                    nIdOrdenTransferencia = table.Column<int>(type: "int", nullable: false),
                    nMonto = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Esta columna corresponde al monto de la órden de transferencia."),
                    nIVA = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Esta columna corresponde al importe del IVA correspondientes al pago."),
                    nNumeroSecuencia = table.Column<int>(type: "int", nullable: false, comment: "Esta columna corresponde a un número de secuencia (1, 2, 3, 4, n) que se le asigna a una orden para que sea capaz de actualizarse el status de una orden. Es una columna que tiene el propósito de ser apoyo."),
                    sConceptoPago = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, comment: "Esta columna corresponde al motivo concepto de pago por el que se está haciendo la orden de transferencia, es decir, el motivo por el que el ordenante hace el pago al beneficiario"),
                    sReferenciaNumerica = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false, comment: "Esta columna corresponse al dato numerico que sirve al ordenante para identificar el pago. Cabe mencionar, que si en caso el pago tenga como tipo de cuenta beneficiario un número de línea de telefonía móvil esta columna es opcional."),
                    sReferenciaCobranza = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    sClaveRastreo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    bCargaMasiva = table.Column<sbyte>(type: "tinyint", nullable: false, comment: "Esta columna identifica si la orden se creó a través de una carga masiva"),
                    dFechaOperacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    bActivo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.nIdOrden);
                    table.ForeignKey(
                        name: "fk_Orden_Beneficiario",
                        column: x => x.nIdBeneficiario,
                        principalTable: "Beneficiario",
                        principalColumn: "nIdBeneficiario");
                    table.ForeignKey(
                        name: "fk_orden_ordentransferencia",
                        column: x => x.nIdOrdenTransferencia,
                        principalTable: "OrdenTransferencia",
                        principalColumn: "nIdOrdenTransferencia");
                },
                comment: "Esta tabla tiene el propósito de almacenar las órdenes que se enviarán a Banco de México")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdenMovimiento",
                columns: table => new
                {
                    nIdOrden = table.Column<int>(type: "int", nullable: false),
                    nIdMovimiento = table.Column<int>(type: "int", nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    dFecMovimiento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenMovimiento", x => new { x.nIdOrden, x.nIdMovimiento });
                    table.ForeignKey(
                        name: "fk_OrdenMovimiento_Movimiento",
                        column: x => x.nIdMovimiento,
                        principalTable: "Movimiento",
                        principalColumn: "nIdMovimiento");
                    table.ForeignKey(
                        name: "fk_OrdenMovimiento_Orden",
                        column: x => x.nIdOrden,
                        principalTable: "Orden",
                        principalColumn: "nIdOrden");
                },
                comment: "Esta tabla tiene el propósito de almacenar las órdenes y los movimientos correspondientes y saber las afectaciones que van realizando en el saldo del participante")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SeguimientoOrdenEstado",
                columns: table => new
                {
                    nIdOrden = table.Column<int>(type: "int", nullable: false),
                    nIdOrdenEstado = table.Column<int>(type: "int", nullable: false),
                    nIdUsuario = table.Column<int>(type: "int", nullable: false),
                    dFecRegistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    sMotivo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguimientoOrdenEstado", x => new { x.nIdOrden, x.nIdOrdenEstado, x.nIdUsuario, x.dFecRegistro });
                    table.ForeignKey(
                        name: "fk_SeguimientoOrdenEstado_Orden",
                        column: x => x.nIdOrden,
                        principalTable: "Orden",
                        principalColumn: "nIdOrden");
                    table.ForeignKey(
                        name: "fk_SeguimientoOrdenEstado_OrdenEstado",
                        column: x => x.nIdOrdenEstado,
                        principalTable: "OrdenEstado",
                        principalColumn: "nIdOrdenEstado");
                    table.ForeignKey(
                        name: "fk_SeguimientoOrdenEstado_Usuario",
                        column: x => x.nIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "nIdUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_AutorizacionOpcionMenu_OpcionMenu",
                table: "AutorizacionOpcionMenu",
                column: "nIdOpcionMenu");

            migrationBuilder.CreateIndex(
                name: "fk_AutorizacionOpcionMenu_Perfil",
                table: "AutorizacionOpcionMenu",
                column: "nIdPerfil");

            migrationBuilder.CreateIndex(
                name: "fk_Beneficiario_Direccion",
                table: "Beneficiario",
                column: "nIdDireccion");

            migrationBuilder.CreateIndex(
                name: "fk_Beneficiario_Participante",
                table: "Beneficiario",
                column: "nIdParticipante");

            migrationBuilder.CreateIndex(
                name: "fk_BeneficiarioCliente_Institucion",
                table: "BeneficiarioCliente",
                column: "nClaveInstitucion");

            migrationBuilder.CreateIndex(
                name: "fk_BeneficiarioClienteIndirecto_ClienteIndirecto",
                table: "BeneficiarioCliente",
                column: "nIdCliente");

            migrationBuilder.CreateIndex(
                name: "unq_BeneficiarioClienteIndirecto",
                table: "BeneficiarioCliente",
                columns: new[] { "nTipoCuenta", "sCuenta" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_BeneficiarioCuenta_Institucion",
                table: "BeneficiarioCuenta",
                column: "nClaveInstitucion");

            migrationBuilder.CreateIndex(
                name: "fk_BeneficiarioCuenta_TipoCuenta",
                table: "BeneficiarioCuenta",
                column: "nClaveTipoCuenta");

            migrationBuilder.CreateIndex(
                name: "unq_BeneficiarioCuenta",
                table: "BeneficiarioCuenta",
                columns: new[] { "nIdBeneficiario", "nClaveTipoCuenta", "sCuenta" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unq_CausaDevolucion",
                table: "CausaDevolucion",
                column: "nClaveCausaDevolucion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_Cliente_Participante",
                table: "Cliente",
                column: "nIdParticipante");

            migrationBuilder.CreateIndex(
                name: "unq_ClienteParticipanteIndirecto_nIdCuenta",
                table: "Cliente",
                column: "nIdCuentaConcentradora",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_ClienteIndiCuentaConcentradora_CuentaConcentradora",
                table: "ClienteCuentaConcentradora",
                column: "nIdCuentaConcentradora");

            migrationBuilder.CreateIndex(
                name: "unq_ClienteIndiCuentaConcentradora",
                table: "ClienteCuentaConcentradora",
                columns: new[] { "nIdCliente", "nIdCuentaConcentradora", "bActivo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_colonia_municipio",
                table: "Colonia",
                column: "nIdMunicipio");

            migrationBuilder.CreateIndex(
                name: "fk_CuentaClienteIndirecto_TipoCuenta",
                table: "CuentaCliente",
                column: "nClaveTipoCuenta");

            migrationBuilder.CreateIndex(
                name: "unq_CuentaClienteIndirecto",
                table: "CuentaCliente",
                columns: new[] { "nIdCliente", "nClaveTipoCuenta" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_CuentaConcentradora_TipoCuenta",
                table: "CuentaConcentradora",
                column: "nClaveTipoCuenta");

            migrationBuilder.CreateIndex(
                name: "fk_direccion_colonia",
                table: "Direccion",
                column: "nIdColonia");

            migrationBuilder.CreateIndex(
                name: "fk_direccion_estado",
                table: "Direccion",
                column: "nIdEstado");

            migrationBuilder.CreateIndex(
                name: "fk_direccion_municipio",
                table: "Direccion",
                column: "nIdMunicipio");

            migrationBuilder.CreateIndex(
                name: "unq_Institucion",
                table: "Institucion",
                column: "nClaveInstitucion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_Movimiento_Participante",
                table: "Movimiento",
                column: "nIdParticipante");

            migrationBuilder.CreateIndex(
                name: "fk_MovimientoEstadoCuenta_TipoMovimiento",
                table: "Movimiento",
                column: "nIdTipoMovimiento");

            migrationBuilder.CreateIndex(
                name: "fk_MovimientoEstadoCuenta_TipoOperacion",
                table: "Movimiento",
                column: "nIdTipoOperacion");

            migrationBuilder.CreateIndex(
                name: "fk_municipio_estado",
                table: "Municipio",
                column: "nIdEstado");

            migrationBuilder.CreateIndex(
                name: "fk_NotificacionWebhook_Participante",
                table: "NotificacionWebhook",
                column: "nIdParticipante");

            migrationBuilder.CreateIndex(
                name: "unq_OpcionMenuAccion",
                table: "OpcionMenuAccion",
                columns: new[] { "nIdOpcionMenu", "nIdAccion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpcionMenuAccionUsuarioPermisos_nIdUsuarioPermisos",
                table: "OpcionMenuAccionUsuarioPermisos",
                column: "nIdUsuarioPermisos");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionMenuAccionUsuarioPermisos_OpcionMenuAccionnIdOpcionMen~",
                table: "OpcionMenuAccionUsuarioPermisos",
                column: "OpcionMenuAccionnIdOpcionMenuAccion");

            migrationBuilder.CreateIndex(
                name: "fk_OpcionMenuJerarquica_OpcionMenu",
                table: "OpcionMenuJerarquica",
                column: "nIdOpcionMenuPadre");

            migrationBuilder.CreateIndex(
                name: "fk_OpcionMenuJerarquica_OpcionMenu_0",
                table: "OpcionMenuJerarquica",
                column: "nIdOpcionMenuHija");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionMenuUsuarioPermisos_nIdUsuarioPermisos",
                table: "OpcionMenuUsuarioPermisos",
                column: "nIdUsuarioPermisos");

            migrationBuilder.CreateIndex(
                name: "fk_Orden_Beneficiario",
                table: "Orden",
                column: "nIdBeneficiario");

            migrationBuilder.CreateIndex(
                name: "fk_orden_ordentransferencia",
                table: "Orden",
                column: "nIdOrdenTransferencia");

            migrationBuilder.CreateIndex(
                name: "fk_Ordenante_Participante",
                table: "Ordenante",
                column: "nIdParticipante");

            migrationBuilder.CreateIndex(
                name: "fk_OrdenMovimiento_Movimiento",
                table: "OrdenMovimiento",
                column: "nIdMovimiento");

            migrationBuilder.CreateIndex(
                name: "fk_OrdenMovimiento_Orden",
                table: "OrdenMovimiento",
                column: "nIdOrden");

            migrationBuilder.CreateIndex(
                name: "fk_OrdenTransferencia_Ordenante",
                table: "OrdenTransferencia",
                column: "nIdOrdenante");

            migrationBuilder.CreateIndex(
                name: "unq_OrdenTransferencia_nClaveTipoPago",
                table: "OrdenTransferencia",
                column: "nClaveTipoPago");

            migrationBuilder.CreateIndex(
                name: "unq_Parametro",
                table: "Parametro",
                column: "sClave",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_Participante_TipoParticipante",
                table: "Participante",
                column: "nIdTipoParticipante");

            migrationBuilder.CreateIndex(
                name: "unq_ParticipanteDirecto_nIdCuenta_0",
                table: "Participante",
                column: "nIdCuentaConcentradora",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_PaInCuentaConcentradora_CuentaConcentradora",
                table: "ParticipanteCuentaConcentradora",
                column: "nIdCuentaConcentradora");

            migrationBuilder.CreateIndex(
                name: "unq_PaInCuentaConcentradora",
                table: "ParticipanteCuentaConcentradora",
                columns: new[] { "nIdParticipante", "nIdCuentaConcentradora", "bActivo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_ParticipanteInicioSaldoOperacion_Participante",
                table: "ParticipanteInicioSaldoOperacion",
                column: "nIdParticipante");

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoDatoN_SeccionDato",
                table: "ProspectoDato",
                column: "nIdSeccionDato");

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoDatoN_SeccionDatoEstado",
                table: "ProspectoDato",
                column: "nIdSeccionDatoEstado");

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoDatoN_SolicitudN",
                table: "ProspectoDato",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoDocumentoN_SeccionDato",
                table: "ProspectoDocumento",
                column: "nIdSeccionDato");

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoDocumentoN_SeccionDatoEstado",
                table: "ProspectoDocumento",
                column: "nIdSeccionDatoEstado");

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoDocumentoN_SolicitudN",
                table: "ProspectoDocumento",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoPerfiles_Perfil",
                table: "ProspectoPerfiles",
                column: "nIdPerfil");

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoPerfiles_SolicitudN",
                table: "ProspectoPerfiles",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "unq_ProspectoPerfiles",
                table: "ProspectoPerfiles",
                column: "sCorreoElectronico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoPerfiles_SolicitudN_2",
                table: "ProspectoResponsableCuenta",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "unq_ProspectoPerfiles_2",
                table: "ProspectoResponsableCuenta",
                column: "sCorreoElectronico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoPerfiles_SolicitudN_3",
                table: "ProspectoResponsableJuridicoCumplimiento",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "unq_ProspectoPerfiles_3",
                table: "ProspectoResponsableJuridicoCumplimiento",
                column: "sCorreoElectronico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoPerfiles_SolicitudN_0",
                table: "ProspectoResponsableOperativo",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "unq_ProspectoPerfiles_0",
                table: "ProspectoResponsableOperativo",
                column: "sCorreoElectronico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_ProspectoPerfiles_SolicitudN_1",
                table: "ProspectoResponsableSistema",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "unq_ProspectoPerfiles_1",
                table: "ProspectoResponsableSistema",
                column: "sCorreoElectronico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_SaldoReserva_Participante",
                table: "SaldoReserva",
                column: "nIdParticipante");

            migrationBuilder.CreateIndex(
                name: "fk_SeccionDato_Seccion",
                table: "SeccionDato",
                column: "nIdSeccion");

            migrationBuilder.CreateIndex(
                name: "unq_SeccionDato_sIdentificador",
                table: "SeccionDato",
                column: "sIdentificador",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenEstado_Orden",
                table: "SeguimientoOrdenEstado",
                column: "nIdOrden");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenEstado_OrdenEstado",
                table: "SeguimientoOrdenEstado",
                column: "nIdOrdenEstado");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenEstado_Usuario",
                table: "SeguimientoOrdenEstado",
                column: "nIdUsuario");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferencia",
                table: "SeguimientoOrdenTransferenciaEstado",
                column: "nIdOrdenTransferencia");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferenciaEstado",
                table: "SeguimientoOrdenTransferenciaEstado",
                column: "nIdOrdenTransferenciaEstado");

            migrationBuilder.CreateIndex(
                name: "fk_SeguimientoOrdenTransferenciaEstado_Usuario",
                table: "SeguimientoOrdenTransferenciaEstado",
                column: "nIdUsuario");

            migrationBuilder.CreateIndex(
                name: "fk_SolicitudN_ProspectoN",
                table: "Solicitud",
                column: "nIdProspecto");

            migrationBuilder.CreateIndex(
                name: "fk_SolicitudN_SolicitudEstado",
                table: "Solicitud",
                column: "nIdSolicitudEstado");

            migrationBuilder.CreateIndex(
                name: "fk_SolicitudConfidencialidad_Solicitud",
                table: "SolicitudConfidencialidad",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "fk_SolicitudSeccion_Seccion",
                table: "SolicitudSeccion",
                column: "nIdSeccion");

            migrationBuilder.CreateIndex(
                name: "fk_SolicitudSeccion_SolicitudN",
                table: "SolicitudSeccion",
                column: "nIdSolicitud");

            migrationBuilder.CreateIndex(
                name: "unq_TipoCuenta",
                table: "TipoCuenta",
                column: "nClaveTipoCuenta",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unq_TipoPago",
                table: "TipoPago",
                column: "nClaveTipoPago",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_Usuario_Perfil",
                table: "Usuario",
                column: "nIdPerfil");

            migrationBuilder.CreateIndex(
                name: "fk_UsuarioPermisoAccion_OpcionMenuAccion",
                table: "UsuarioPermisoAccion",
                column: "nIdOpcionMenuAccion");

            migrationBuilder.CreateIndex(
                name: "fk_UsuarioPermisoAccion_Perfil",
                table: "UsuarioPermisoAccion",
                column: "nIdPerfil");

            migrationBuilder.CreateIndex(
                name: "fk_UsuarioPermisoAccion_Usuario",
                table: "UsuarioPermisoAccion",
                column: "nIdUsuario");

            migrationBuilder.CreateIndex(
                name: "sNombre",
                table: "UsuarioPermisos",
                column: "sNombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorizacionOpcionMenu");

            migrationBuilder.DropTable(
                name: "BeneficiarioCliente");

            migrationBuilder.DropTable(
                name: "BeneficiarioCuenta");

            migrationBuilder.DropTable(
                name: "CausaDevolucion");

            migrationBuilder.DropTable(
                name: "ClaveCifrado");

            migrationBuilder.DropTable(
                name: "ClienteCuentaConcentradora");

            migrationBuilder.DropTable(
                name: "CuentaCliente");

            migrationBuilder.DropTable(
                name: "GiroNegocio");

            migrationBuilder.DropTable(
                name: "NotificacionWebhook");

            migrationBuilder.DropTable(
                name: "OpcionMenuAccionUsuarioPermisos");

            migrationBuilder.DropTable(
                name: "OpcionMenuJerarquica");

            migrationBuilder.DropTable(
                name: "OpcionMenuUsuarioPermisos");

            migrationBuilder.DropTable(
                name: "OrdenMovimiento");

            migrationBuilder.DropTable(
                name: "Parametro");

            migrationBuilder.DropTable(
                name: "ParticipanteCuentaConcentradora");

            migrationBuilder.DropTable(
                name: "ParticipanteInicioSaldoOperacion");

            migrationBuilder.DropTable(
                name: "Plaza");

            migrationBuilder.DropTable(
                name: "ProductoFinanciero");

            migrationBuilder.DropTable(
                name: "ProspectoDato");

            migrationBuilder.DropTable(
                name: "ProspectoDocumento");

            migrationBuilder.DropTable(
                name: "ProspectoPerfiles");

            migrationBuilder.DropTable(
                name: "ProspectoResponsableCuenta");

            migrationBuilder.DropTable(
                name: "ProspectoResponsableJuridicoCumplimiento");

            migrationBuilder.DropTable(
                name: "ProspectoResponsableOperativo");

            migrationBuilder.DropTable(
                name: "ProspectoResponsableSistema");

            migrationBuilder.DropTable(
                name: "SaldoReserva");

            migrationBuilder.DropTable(
                name: "Secuencia");

            migrationBuilder.DropTable(
                name: "SeguimientoOrdenEstado");

            migrationBuilder.DropTable(
                name: "SeguimientoOrdenTransferenciaEstado");

            migrationBuilder.DropTable(
                name: "SolicitudConfidencialidad");

            migrationBuilder.DropTable(
                name: "SolicitudSeccion");

            migrationBuilder.DropTable(
                name: "TipoSociedad");

            migrationBuilder.DropTable(
                name: "UsuarioPermisoAccion");

            migrationBuilder.DropTable(
                name: "Institucion");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "UsuarioPermisos");

            migrationBuilder.DropTable(
                name: "Movimiento");

            migrationBuilder.DropTable(
                name: "CuentaConcentradora");

            migrationBuilder.DropTable(
                name: "SeccionDato");

            migrationBuilder.DropTable(
                name: "SeccionDatoEstado");

            migrationBuilder.DropTable(
                name: "Orden");

            migrationBuilder.DropTable(
                name: "OrdenEstado");

            migrationBuilder.DropTable(
                name: "OrdenTransferenciaEstado");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "OpcionMenuAccion");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "TipoMovimiento");

            migrationBuilder.DropTable(
                name: "TipoOperacion");

            migrationBuilder.DropTable(
                name: "TipoCuenta");

            migrationBuilder.DropTable(
                name: "Seccion");

            migrationBuilder.DropTable(
                name: "Beneficiario");

            migrationBuilder.DropTable(
                name: "OrdenTransferencia");

            migrationBuilder.DropTable(
                name: "Prospecto");

            migrationBuilder.DropTable(
                name: "SolicitudEstado");

            migrationBuilder.DropTable(
                name: "OpcionMenu");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "Ordenante");

            migrationBuilder.DropTable(
                name: "TipoPago");

            migrationBuilder.DropTable(
                name: "Colonia");

            migrationBuilder.DropTable(
                name: "Participante");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "TipoParticipante");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
