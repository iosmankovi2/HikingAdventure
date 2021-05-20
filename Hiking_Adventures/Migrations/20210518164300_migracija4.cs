using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiking_Adventures.Migrations
{
    public partial class migracija4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slikica",
                table: "Rute");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slikica",
                table: "Rute",
                type: "text",
                nullable: true);
        }
    }
}
