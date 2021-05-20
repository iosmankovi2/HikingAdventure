using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiking_Adventures.Migrations
{
    public partial class migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "Rute",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slikica",
                table: "Rute",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tezina",
                table: "Rute",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Rute");

            migrationBuilder.DropColumn(
                name: "Slikica",
                table: "Rute");

            migrationBuilder.DropColumn(
                name: "Tezina",
                table: "Rute");
        }
    }
}
