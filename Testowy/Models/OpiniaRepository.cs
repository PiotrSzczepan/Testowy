using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testowy.Models
{
    public class OpiniaRepository : IOpiniaRepository
    {
        private readonly AppDbContext appDbContext;

        public OpiniaRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void DodajOpinie(Opinia opinia)
        {
            appDbContext.opinie.Add(opinia);
            appDbContext.SaveChanges();
        }
    }
}
