using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LekOperations
{
    public class UcitajSveLekoveSO : SystemOperationBase
    {
        public List<Lek> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetAll(new Lek()).OfType<Lek>().ToList();
        }
    }
}
