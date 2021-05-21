using Microsoft.EntityFrameworkCore.Migrations;

namespace banking.Migrations
{
    public partial class deletecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromAccountNumber",
                table: "AllTransaction");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FromAccountNumber",
                table: "AllTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
