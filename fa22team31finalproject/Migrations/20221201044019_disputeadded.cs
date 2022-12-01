using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fa22team31finalproject.Migrations
{
    public partial class disputeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Disputes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disputes_AppUserId",
                table: "Disputes",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disputes_AspNetUsers_AppUserId",
                table: "Disputes",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disputes_AspNetUsers_AppUserId",
                table: "Disputes");

            migrationBuilder.DropIndex(
                name: "IX_Disputes_AppUserId",
                table: "Disputes");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Disputes");
        }
    }
}
