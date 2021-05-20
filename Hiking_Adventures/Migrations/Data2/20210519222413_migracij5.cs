using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiking_Adventures.Migrations.Data2
{
    public partial class migracij5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumRodjenja",
                table: "PrijaveRuta");

            migrationBuilder.AddColumn<DateTime>(
                name: "Datum",
                table: "PrijaveRuta",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NaziRute",
                table: "PrijaveRuta",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datum",
                table: "PrijaveRuta");

            migrationBuilder.DropColumn(
                name: "NaziRute",
                table: "PrijaveRuta");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumRodjenja",
                table: "PrijaveRuta",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
