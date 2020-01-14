using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testowy.Models
{
    public class SamochodRepository : ISamochodRepository
    {
        private readonly AppDbContext _appDbContext;

        public SamochodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Samochod PobierzSamochodPoId(int samochodId)
        {
            return _appDbContext.samochody.FirstOrDefault(s => s.Id == samochodId);
        }

        public IEnumerable<Samochod> PobierzSamochody()
        {
            return _appDbContext.samochody;
        }
    }
}
