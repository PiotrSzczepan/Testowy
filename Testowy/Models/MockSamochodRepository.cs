
using System.Collections.Generic;
using System.Linq;

namespace Testowy.Models
{
    public class MockSamochodRepository : ISamochodRepository
    {
        private List<Samochod> samochody;

        public MockSamochodRepository()
        {
            if(samochody == null)
            {
                ZaladujSamochody();
            }
        }

        private void ZaladujSamochody()
        {
            samochody = new List<Samochod>
            {
                new Samochod{Id=1, Marka="Ford", Model="Mustang", RokProdukcji=1995, Przebieg="200 000km", Pojemnosc="2.5", RodzajPaliwa="Benzyna", Moc="220KW", Cena=30000, Opis="To jest Mustang", Miniaturka="", Zdjecie="", JestSamochodemTygodnia=true},
                new Samochod{Id=2, Marka="Ford", Model="Mustang", RokProdukcji=1995, Przebieg="200 000km", Pojemnosc="2.5", RodzajPaliwa="Benzyna", Moc="220KW", Cena=30000, Opis="To jest Mustang", Miniaturka="", Zdjecie="", JestSamochodemTygodnia=true},
                new Samochod{Id=3, Marka="Ford", Model="Mustang", RokProdukcji=1995, Przebieg="200 000km", Pojemnosc="2.5", RodzajPaliwa="Benzyna", Moc="220KW", Cena=30000, Opis="To jest Mustang", Miniaturka="", Zdjecie="", JestSamochodemTygodnia=true},
                new Samochod{Id=4, Marka="Ford", Model="Mustang", RokProdukcji=1995, Przebieg="200 000km", Pojemnosc="2.5", RodzajPaliwa="Benzyna", Moc="220KW", Cena=30000, Opis="To jest Mustang", Miniaturka="", Zdjecie="", JestSamochodemTygodnia=true}
            };
        }

        public Samochod PobierzSamochodPoId(int samochodId)
        {
            return samochody.FirstOrDefault(s => s.Id == samochodId);
        }

        public IEnumerable<Samochod> PobierzSamochody()
        {
            return samochody;
        }
    }
}
