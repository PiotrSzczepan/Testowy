using Microsoft.EntityFrameworkCore.Migrations;

namespace Testowy.Migrations
{
    public partial class nowyprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "JestWCentrali",
                table: "samochody",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JestWCentrali",
                table: "samochody");
        }
    }
}
