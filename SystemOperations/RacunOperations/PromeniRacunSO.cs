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
            List<StavkaRacuna> oldStavke = repository.GetSpecific(new StavkaRacuna { SearchKeyword = racun.IdRacun.ToString() }).Cast<StavkaRacuna>().ToList();


            foreach(var oldStavka in oldStavke)
            {
                repository.Delete(oldStavka);
            }
            
            foreach(var newStavka in racun.Stavke)
            {
                repository.Save(newStavka);
            }

            repository.Update(racun);

        }
    }
}
