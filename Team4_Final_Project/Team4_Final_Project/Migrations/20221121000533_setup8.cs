using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team4_Final_Project.Migrations
{
    public partial class setup8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "StockPortfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "StockPortfolios");
        }
    }
}
