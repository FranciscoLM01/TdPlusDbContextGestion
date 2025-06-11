using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranSPEiApiModGes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductoFinancieroFieldsChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sDescripción",
                table: "ProductoFinanciero",
                type: "longtext",
                nullable: false,
                comment: "Esta columna corresponde a la descripción del producto financiero",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldComment: "Esta columna corresponde a la descripción del producto financiero");

            migrationBuilder.AlterColumn<int>(
                name: "sClave",
                table: "ProductoFinanciero",
                type: "int",
                nullable: false,
                comment: "Esta columna corresponde al identificador único del producto financiero",
                oldClrType: typeof(string),
                oldType: "char(2)",
                oldFixedLength: true,
                oldMaxLength: 2,
                oldComment: "Esta columna corresponde al identificador único del producto financiero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sDescripción",
                table: "ProductoFinanciero",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Esta columna corresponde a la descripción del producto financiero",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldComment: "Esta columna corresponde a la descripción del producto financiero");

            migrationBuilder.AlterColumn<string>(
                name: "sClave",
                table: "ProductoFinanciero",
                type: "char(2)",
                fixedLength: true,
                maxLength: 2,
                nullable: false,
                comment: "Esta columna corresponde al identificador único del producto financiero",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Esta columna corresponde al identificador único del producto financiero");
        }
    }
}
