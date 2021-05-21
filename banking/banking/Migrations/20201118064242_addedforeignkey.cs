using Microsoft.EntityFrameworkCore.Migrations;

namespace banking.Migrations
{
    public partial class addedforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "AllTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AllTransaction_AccountId",
                table: "AllTransaction",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllTransaction_Account_AccountId",
                table: "AllTransaction",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllTransaction_Account_AccountId",
                table: "AllTransaction");

            migrationBuilder.DropIndex(
                name: "IX_AllTransaction_AccountId",
                table: "AllTransaction");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "AllTransaction");
        }
    }
}
