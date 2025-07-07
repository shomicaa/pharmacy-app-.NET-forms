using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.RacunOperations
{
    public class PromeniRacunSO : SystemOperationBase
    {
        protected override void Execute(IEntity entity)
        {
            Racun racun = entity as Racun;
            if (racun.Stavke == null)
            {
                repository.Update(entity);
            }
            else
            {
                foreach(var stavka in racun.Stavke)
                {
                    repository.Save(stavka);
                }
                repository.Update(entity);
            }
            
        }
    }
}
