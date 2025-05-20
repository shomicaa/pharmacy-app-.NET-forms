using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.KorisnikOperations
{
    public class ObrisiKorisnikSO : SystemOperationBase
    {
        protected override void Execute(IEntity entity)
        {
            repository.Delete(entity);
        }
    }
}
