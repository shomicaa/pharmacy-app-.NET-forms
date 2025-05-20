using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Racun
    {
        public int IdRacun { get; set; }
        public List<StavkaRacuna> Stavke { get; set; }
        public double UkupnaVrednost { get; set; }
        public double IznosPoreza { get; set; }
        public double UkupnaVrednostSaPorezom { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int IdFarmaceut { get; set; }
        public int IdKorisnik { get; set; }
    }
}
