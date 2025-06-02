using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FarmaceutOperations
{
    public class UcitajSpecificKorisnikeSO : SystemOperationBase
    {
        public List<Korisnik> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetSpecific(entity).OfType<Korisnik>().ToList();
        }
    }
}
