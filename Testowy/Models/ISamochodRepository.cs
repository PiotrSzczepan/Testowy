using System.Collections.Generic;


namespace Testowy.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzSamochody();

        Samochod PobierzSamochodPoId(int samochodId);


        void DodajSamochod(Samochod samochod);
        void EdytujSamochod(Samochod samochod);
        void UsunSamochod(Samochod samochod);
    }
}
