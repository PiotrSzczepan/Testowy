using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testowy.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            if (!dbContext.samochody.Any())
            {
                dbContext.AddRange(
                new Samochod {Marka = "Ford", Model = "Mustang", RokProdukcji = 1995, Przebieg = "200 000km", Pojemnosc = "2.5", RodzajPaliwa = "Benzyna", Moc = "220KW", Cena = 30000, Opis = "To jest Mustang", Miniaturka = "", Zdjecie = "", JestSamochodemTygodnia = true },
                new Samochod {Marka = "fiat", Model = "Mustang", RokProdukcji = 1995, Przebieg = "200 000km", Pojemnosc = "2.5", RodzajPaliwa = "Benzyna", Moc = "220KW", Cena = 30000, Opis = "To jest Mustang", Miniaturka = "", Zdjecie = "", JestSamochodemTygodnia = true },
                new Samochod {Marka = "opel", Model = "astra", RokProdukcji = 1995, Przebieg = "200 000km", Pojemnosc = "2.5", RodzajPaliwa = "Benzyna", Moc = "220KW", Cena = 30000, Opis = "To jest Mustang", Miniaturka = "", Zdjecie = "", JestSamochodemTygodnia = true },
                new Samochod {Marka = "Ford", Model = "Mustang", RokProdukcji = 1995, Przebieg = "200 000km", Pojemnosc = "2.5", RodzajPaliwa = "Benzyna", Moc = "220KW", Cena = 30000, Opis = "To jest Mustang", Miniaturka = "", Zdjecie = "", JestSamochodemTygodnia = true }
                );
            }
            dbContext.SaveChanges();
        }
    }
}
