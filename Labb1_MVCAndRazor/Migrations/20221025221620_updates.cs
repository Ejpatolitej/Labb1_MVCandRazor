using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1_MVCAndRazor.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanID", "BookID", "CustomerID" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoanID",
                keyValue: 1);
        }
    }
}
