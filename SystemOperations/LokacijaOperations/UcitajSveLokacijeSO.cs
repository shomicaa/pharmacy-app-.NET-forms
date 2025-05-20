using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LokacijaOperations
{
    public class UcitajSveLokacijeSO : SystemOperationBase
    {
        public List<Lokacija> Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = repository.GetAll(new Lokacija()).OfType<Lokacija>().ToList();
        }
    }
}
