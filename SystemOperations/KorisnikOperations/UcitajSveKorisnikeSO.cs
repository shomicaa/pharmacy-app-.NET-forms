using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.KorisnikOperations
{
    public class UcitajSveKorisnikeSO : SystemOperationBase
    {
        public List<Korisnik> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetAll(new Korisnik()).OfType<Korisnik>().ToList();
        }
    }
}
