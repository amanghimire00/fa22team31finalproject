using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class currencyformated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionNum",
                table: "Disputes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionNum",
                table: "Disputes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
