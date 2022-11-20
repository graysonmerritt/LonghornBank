using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team4_Final_Project.Migrations
{
    public partial class setup7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HiddenAccountNumber",
                table: "StockPortfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "StockPortfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HiddenAccountNumber",
                table: "StockPortfolios");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "StockPortfolios");
        }
    }
}
