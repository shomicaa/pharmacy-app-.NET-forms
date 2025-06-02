using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LekOperations
{
    public class PretraziLekSO : SystemOperationBase
    {
        public Lek Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = (Lek)repository.Find(entity);
        }
    }
}
