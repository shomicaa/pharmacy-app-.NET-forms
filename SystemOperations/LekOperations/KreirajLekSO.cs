using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LekOperations
{
    public class KreirajLekSO : SystemOperationBase
    {
        public int Result { get; set; }

        protected override void Execute(IEntity entity)
        {
            Result = repository.Create(entity);
        }
    }
}
