using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PromoKodOperations
{
    public class PretraziPromoKodSO : SystemOperationBase
    {
        public List<PromoKod> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetSpecific(entity).OfType<PromoKod>().ToList();
        }
    }
}
