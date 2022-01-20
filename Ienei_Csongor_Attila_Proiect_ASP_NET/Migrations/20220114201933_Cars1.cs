using Microsoft.EntityFrameworkCore.Migrations;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Migrations
{
    public partial class Cars1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Style",
                table: "Cars",
                newName: "SalesName");

            migrationBuilder.AlterColumn<int>(
                name: "SalesID",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars",
                column: "SalesID",
                principalTable: "Sales",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "SalesName",
                table: "Cars",
                newName: "Style");

            migrationBuilder.AlterColumn<int>(
                name: "SalesID",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars",
                column: "SalesID",
                principalTable: "Sales",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
