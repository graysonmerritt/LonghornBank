using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team4_Final_Project.Migrations
{
    public partial class Setup1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockPortsfolios_AspNetUsers_AppUserForeignKey",
                table: "StockPortsfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_StockTransactions_StockPortsfolios_StockPortfolioID",
                table: "StockTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockPortsfolios",
                table: "StockPortsfolios");

            migrationBuilder.RenameTable(
                name: "StockPortsfolios",
                newName: "StockPortfolios");

            migrationBuilder.RenameIndex(
                name: "IX_StockPortsfolios_AppUserForeignKey",
                table: "StockPortfolios",
                newName: "IX_StockPortfolios_AppUserForeignKey");

            migrationBuilder.AddColumn<bool>(
                name: "Balanced",
                table: "StockPortfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockPortfolios",
                table: "StockPortfolios",
                column: "StockPortfolioID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockPortfolios_AspNetUsers_AppUserForeignKey",
                table: "StockPortfolios",
                column: "AppUserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockTransactions_StockPortfolios_StockPortfolioID",
                table: "StockTransactions",
                column: "StockPortfolioID",
                principalTable: "StockPortfolios",
                principalColumn: "StockPortfolioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockPortfolios_AspNetUsers_AppUserForeignKey",
                table: "StockPortfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_StockTransactions_StockPortfolios_StockPortfolioID",
                table: "StockTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockPortfolios",
                table: "StockPortfolios");

            migrationBuilder.DropColumn(
                name: "Balanced",
                table: "StockPortfolios");

            migrationBuilder.RenameTable(
                name: "StockPortfolios",
                newName: "StockPortsfolios");

            migrationBuilder.RenameIndex(
                name: "IX_StockPortfolios_AppUserForeignKey",
                table: "StockPortsfolios",
                newName: "IX_StockPortsfolios_AppUserForeignKey");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockPortsfolios",
                table: "StockPortsfolios",
                column: "StockPortfolioID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockPortsfolios_AspNetUsers_AppUserForeignKey",
                table: "StockPortsfolios",
                column: "AppUserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockTransactions_StockPortsfolios_StockPortfolioID",
                table: "StockTransactions",
                column: "StockPortfolioID",
                principalTable: "StockPortsfolios",
                principalColumn: "StockPortfolioID");
        }
    }
}
