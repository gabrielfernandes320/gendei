using Microsoft.EntityFrameworkCore.Migrations;

namespace gendei.Migrations
{
    public partial class countryTableAddingFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Iso",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Iso3",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NiceName",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumCode",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneCode",
                table: "Country",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iso",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Iso3",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "NiceName",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "NumCode",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "PhoneCode",
                table: "Country");
        }
    }
}
