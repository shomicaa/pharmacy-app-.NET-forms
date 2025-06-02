using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FarmaceutOperations
{
    public class UcitajFarmaceuteSaZahtevomSO : SystemOperationBase
    {
        public List<Farmaceut> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetWithCondition((IJoinEntity)entity).OfType<Farmaceut>().ToList();
        }
    }
}
