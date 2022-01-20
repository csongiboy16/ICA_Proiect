using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Migrations
{
    public partial class Cars2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars");

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

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishingDate",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars",
                column: "SalesID",
                principalTable: "Sales",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DealershipName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PublishingDate",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "SalesID",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Sales_SalesID",
                table: "Cars",
                column: "SalesID",
                principalTable: "Sales",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
