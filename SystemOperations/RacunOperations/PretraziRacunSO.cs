using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.RacunOperations
{
    public class PretraziRacunSO : SystemOperationBase
    {
        public Racun Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = (Racun)repository.Find(entity);
        }
    }
}
