using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class BankAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Accounts_AccountID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "AspNetUsers",
                newName: "AccountBankAccountID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_AccountID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_AccountBankAccountID");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Accounts",
                newName: "BankAccountID");

            migrationBuilder.AlterColumn<long>(
                name: "AccountNumber",
                table: "Accounts",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Accounts_AccountBankAccountID",
                table: "AspNetUsers",
                column: "AccountBankAccountID",
                principalTable: "Accounts",
                principalColumn: "BankAccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Accounts_AccountBankAccountID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AccountBankAccountID",
                table: "AspNetUsers",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_AccountBankAccountID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_AccountID");

            migrationBuilder.RenameColumn(
                name: "BankAccountID",
                table: "Accounts",
                newName: "AccountID");

            migrationBuilder.AlterColumn<int>(
                name: "AccountNumber",
                table: "Accounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Accounts_AccountID",
                table: "AspNetUsers",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "AccountID");
        }
    }
}
