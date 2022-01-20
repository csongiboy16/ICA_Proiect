using Microsoft.EntityFrameworkCore.Migrations;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Migrations
{
    public partial class Cars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Make",
                table: "Cars",
                newName: "Style");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Style",
                table: "Cars",
                newName: "Make");

            migrationBuilder.AddColumn<decimal>(
                name: "Year",
                table: "Cars",
                type: "decimal(6, 4)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
