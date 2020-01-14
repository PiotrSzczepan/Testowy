using Microsoft.EntityFrameworkCore.Migrations;

namespace Testowy.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "samochody",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    RokProdukcji = table.Column<int>(nullable: false),
                    Przebieg = table.Column<string>(nullable: true),
                    Pojemnosc = table.Column<string>(nullable: true),
                    RodzajPaliwa = table.Column<string>(nullable: true),
                    Moc = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Cena = table.Column<decimal>(nullable: false),
                    Zdjecie = table.Column<string>(nullable: true),
                    Miniaturka = table.Column<string>(nullable: true),
                    JestSamochodemTygodnia = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_samochody", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "samochody");
        }
    }
}
