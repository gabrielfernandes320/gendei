using Microsoft.EntityFrameworkCore.Migrations;

namespace gendei.Migrations
{
    public partial class countryTableUpdatingFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneCode",
                table: "Country",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumCode",
                table: "Country",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneCode",
                table: "Country",
                type: "text",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NumCode",
                table: "Country",
                type: "text",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
