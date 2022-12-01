using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class setup1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockTicker",
                table: "StockTransactions");

            migrationBuilder.RenameColumn(
                name: "StickPurchaseDate",
                table: "StockTransactions",
                newName: "StockPurchaseDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockPurchaseDate",
                table: "StockTransactions",
                newName: "StickPurchaseDate");

            migrationBuilder.AddColumn<string>(
                name: "StockTicker",
                table: "StockTransactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
