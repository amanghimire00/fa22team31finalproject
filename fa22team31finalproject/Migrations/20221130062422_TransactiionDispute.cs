using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class TransactiionDispute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionDetailID",
                table: "Disputes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionID",
                table: "Disputes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disputes_TransactionDetailID",
                table: "Disputes",
                column: "TransactionDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Disputes_TransactionID",
                table: "Disputes",
                column: "TransactionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Disputes_TransactionDetail_TransactionDetailID",
                table: "Disputes",
                column: "TransactionDetailID",
                principalTable: "TransactionDetail",
                principalColumn: "TransactionDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Disputes_Transactions_TransactionID",
                table: "Disputes",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "TransactionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disputes_TransactionDetail_TransactionDetailID",
                table: "Disputes");

            migrationBuilder.DropForeignKey(
                name: "FK_Disputes_Transactions_TransactionID",
                table: "Disputes");

            migrationBuilder.DropIndex(
                name: "IX_Disputes_TransactionDetailID",
                table: "Disputes");

            migrationBuilder.DropIndex(
                name: "IX_Disputes_TransactionID",
                table: "Disputes");

            migrationBuilder.DropColumn(
                name: "TransactionDetailID",
                table: "Disputes");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Disputes");
        }
    }
}
