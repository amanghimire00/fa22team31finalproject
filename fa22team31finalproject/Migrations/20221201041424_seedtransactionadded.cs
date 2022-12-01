using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class seedtransactionadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FromAccount",
                table: "Transactions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ToAccount",
                table: "Transactions",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromAccount",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ToAccount",
                table: "Transactions");
        }
    }
}
