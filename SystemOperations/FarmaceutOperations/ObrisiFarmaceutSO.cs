using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FarmaceutOperations
{
    public class ObrisiFarmaceutSO : SystemOperationBase
    {
        protected override void Execute(IEntity entity)
        {
            repository.Delete(entity);
        }
    }
}
