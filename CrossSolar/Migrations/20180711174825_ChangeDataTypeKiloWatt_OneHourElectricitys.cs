using Microsoft.EntityFrameworkCore.Migrations;

namespace CrossSolar.Migrations
{
    public partial class ChangeDataTypeKiloWatt_OneHourElectricitys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Serial",
                table: "Panels",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "PanelId",
                table: "OneHourElectricitys",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "KiloWatt",
                table: "OneHourElectricitys",
                nullable: false,
                oldClrType: typeof(long));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Serial",
                table: "Panels",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "PanelId",
                table: "OneHourElectricitys",
                nullable: true,//
                oldClrType: typeof(string),
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<long>(
                name: "KiloWatt",
                table: "OneHourElectricitys",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
