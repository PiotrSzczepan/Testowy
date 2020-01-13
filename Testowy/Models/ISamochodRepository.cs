using System.Collections.Generic;


namespace Testowy.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzSamochody();

        Samochod PobierzSamochodPoId(int samochodId);
    }
}
