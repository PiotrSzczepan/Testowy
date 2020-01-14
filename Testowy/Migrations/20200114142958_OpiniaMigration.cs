using Microsoft.EntityFrameworkCore.Migrations;

namespace Testowy.Migrations
{
    public partial class OpiniaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "opinie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaUżytkownika = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Wiadomosc = table.Column<string>(nullable: true),
                    OczekujeOdpowiedzi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opinie", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "opinie");
        }
    }
}
