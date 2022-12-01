using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class setup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockPortfolios_Transactions_TransactionID",
                table: "StockPortfolios");

            migrationBuilder.DropIndex(
                name: "IX_StockPortfolios_TransactionID",
                table: "StockPortfolios");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "StockPortfolios");

            migrationBuilder.AddColumn<int>(
                name: "StockPortfolioID",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_StockPortfolioID",
                table: "Transactions",
                column: "StockPortfolioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_StockPortfolios_StockPortfolioID",
                table: "Transactions",
                column: "StockPortfolioID",
                principalTable: "StockPortfolios",
                principalColumn: "StockPortfolioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_StockPortfolios_StockPortfolioID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_StockPortfolioID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "StockPortfolioID",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "TransactionID",
                table: "StockPortfolios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockPortfolios_TransactionID",
                table: "StockPortfolios",
                column: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockPortfolios_Transactions_TransactionID",
                table: "StockPortfolios",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "TransactionID");
        }
    }
}
