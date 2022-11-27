using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team4_Final_Project.Migrations
{
    public partial class setup4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ExtendedPrice",
                table: "StockTransactions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "HiddenAccountNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtendedPrice",
                table: "StockTransactions");

            migrationBuilder.DropColumn(
                name: "HiddenAccountNumber",
                table: "Accounts");
        }
    }
}
