using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FarmaceutOperations
{
    public class PrijaviFarmaceutSO : SystemOperationBase
    {
        public Farmaceut Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Farmaceut trenutniFarmaceut = (Farmaceut)entity;

            foreach (Farmaceut farmaceut in repository.GetAll(new Farmaceut()))
            {
                if (farmaceut.KorisnickoIme == trenutniFarmaceut.KorisnickoIme && farmaceut.Lozinka == trenutniFarmaceut.Lozinka)
                {
                    Result = trenutniFarmaceut;
                }
            }
        }
    }
}
