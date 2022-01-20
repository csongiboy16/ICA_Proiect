using Microsoft.EntityFrameworkCore.Migrations;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Migrations
{
    public partial class Cars4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Dealership_Cars_CarsID",
                table: "Dealership");

            migrationBuilder.DropIndex(
                name: "IX_Dealership_CarsID",
                table: "Dealership");

            migrationBuilder.DropColumn(
                name: "CarsID",
                table: "Dealership");

            migrationBuilder.DropColumn(
                name: "DealershipName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SalesName",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "PublishingDate",
                table: "Cars",
                newName: "ProdDate");

            migrationBuilder.AlterColumn<int>(
                name: "SalesID",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DealershipID",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DealershipID",
                table: "Cars",
                column: "DealershipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Dealership_DealershipID",
                table: "Cars",
                column: "DealershipID",
                principalTable: "Dealership",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Cars_Dealership_DealershipID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_DealershipID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DealershipID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ProdDate",
                table: "Cars",
                newName: "PublishingDate");

            migrationBuilder.AddColumn<int>(
                name: "CarsID",
                table: "Dealership",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalesID",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DealershipName",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalesName",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dealership_CarsID",
                table: "Dealership",
                column: "CarsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars",
                column: "SalesID",
                principalTable: "Sales",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dealership_Cars_CarsID",
                table: "Dealership",
                column: "CarsID",
                principalTable: "Cars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
