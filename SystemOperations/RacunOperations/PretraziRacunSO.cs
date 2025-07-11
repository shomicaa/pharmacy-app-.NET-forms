using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.RacunOperations
{
    public class PretraziRacunSO : SystemOperationBase
    {
        public Racun Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Racun racun = (Racun)repository.Find(entity);
            List<StavkaRacuna> stavke = repository.GetAll(new StavkaRacuna()).Cast<StavkaRacuna>().ToList();

            BindingList<StavkaRacuna> stavkeFiltered = new BindingList<StavkaRacuna>();
            foreach (var stavka in stavke)
            {
                if(stavka.IdRacun == racun.IdRacun)
                {
                    stavkeFiltered.Add(stavka);
                }
            }
            racun.Stavke = stavkeFiltered;

            Result = racun;
        }
    }
}
