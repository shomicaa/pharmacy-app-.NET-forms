using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.RacunOperations
{
    public class UcitajSveRacuneSO : SystemOperationBase
    {
        public List<Racun> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetAll(new Racun()).OfType<Racun>().ToList();
        }
    }
}
