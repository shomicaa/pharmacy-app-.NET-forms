using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FarmaceutOperations
{
    public class UcitajSveFarmaceuteSO : SystemOperationBase
    {
        public List<Farmaceut> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetAll(new Farmaceut()).OfType<Farmaceut>().ToList();
        }
    }
}
