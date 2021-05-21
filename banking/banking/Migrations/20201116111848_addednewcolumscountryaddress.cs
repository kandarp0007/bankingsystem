using Microsoft.EntityFrameworkCore.Migrations;

namespace banking.Migrations
{
    public partial class addednewcolumscountryaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contry",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostCode",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "Contry",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Account");
        }
    }
}
