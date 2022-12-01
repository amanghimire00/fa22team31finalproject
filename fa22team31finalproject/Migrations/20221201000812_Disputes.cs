using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class Disputes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disputes_TransactionDetail_TransactionDetailID",
                table: "Disputes");

            migrationBuilder.DropIndex(
                name: "IX_Disputes_TransactionDetailID",
                table: "Disputes");

            migrationBuilder.DropColumn(
                name: "TransactionDetailID",
                table: "Disputes");

            migrationBuilder.AddColumn<int>(
                name: "DisputeID",
                table: "TransactionDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetail_DisputeID",
                table: "TransactionDetail",
                column: "DisputeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetail_Disputes_DisputeID",
                table: "TransactionDetail",
                column: "DisputeID",
                principalTable: "Disputes",
                principalColumn: "DisputeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetail_Disputes_DisputeID",
                table: "TransactionDetail");

            migrationBuilder.DropIndex(
                name: "IX_TransactionDetail_DisputeID",
                table: "TransactionDetail");

            migrationBuilder.DropColumn(
                name: "DisputeID",
                table: "TransactionDetail");

            migrationBuilder.AddColumn<int>(
                name: "TransactionDetailID",
                table: "Disputes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disputes_TransactionDetailID",
                table: "Disputes",
                column: "TransactionDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Disputes_TransactionDetail_TransactionDetailID",
                table: "Disputes",
                column: "TransactionDetailID",
                principalTable: "TransactionDetail",
                principalColumn: "TransactionDetailID");
        }
    }
}
