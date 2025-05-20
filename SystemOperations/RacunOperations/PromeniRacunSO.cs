using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.RacunOperations
{
    public class PromeniRacunSO : SystemOperationBase
    {
        protected override void Execute(IEntity entity)
        {
            repository.Update(entity);
        }
    }
}
