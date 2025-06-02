using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FarmaceutOperations
{
    public class UcitajRacuneSaZahtevomSO : SystemOperationBase
    {
        public List<Racun> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetWithCondition((IJoinEntity)entity).OfType<Racun>().ToList();
        }
    }
}
