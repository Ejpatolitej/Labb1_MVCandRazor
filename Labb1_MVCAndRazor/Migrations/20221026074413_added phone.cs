using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1_MVCAndRazor.Migrations
{
    public partial class addedphone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerEmail",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerPhone",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                column: "CustomerPhone",
                value: "070551112244");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "CustomerPhone",
                value: "07111222333");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "CustomerPhone",
                value: "070123123123");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerPhone",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerEmail",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
