using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FarmaceutOperations
{
    public class UcitajSpecificFarmaceuteSO : SystemOperationBase
    {
        public List<Farmaceut> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetSpecific(entity).OfType<Farmaceut>().ToList();
        }
    }
}
