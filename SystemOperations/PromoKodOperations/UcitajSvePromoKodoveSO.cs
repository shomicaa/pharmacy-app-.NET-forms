using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PromoKodOperations
{
    public class UcitajSvePromoKodoveSO : SystemOperationBase
    {
        public List<PromoKod> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetAll(new PromoKod()).OfType<PromoKod>().ToList();
        }
    }
}
