using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class TransactionDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionDetail",
                columns: table => new
                {
                    TransactionDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionAmount = table.Column<int>(type: "int", nullable: false),
                    TransactionID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BankAccountID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDetail", x => x.TransactionDetailID);
                    table.ForeignKey(
                        name: "FK_TransactionDetail_Accounts_BankAccountID",
                        column: x => x.BankAccountID,
                        principalTable: "Accounts",
                        principalColumn: "BankAccountID");
                    table.ForeignKey(
                        name: "FK_TransactionDetail_Transactions_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetail_BankAccountID",
                table: "TransactionDetail",
                column: "BankAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetail_TransactionID",
                table: "TransactionDetail",
                column: "TransactionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionDetail");
        }
    }
}
