using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Korisnik
    {
        public int IdKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KontaktTelefon { get; set; }
        public DateTime DatumUclanjenja { get; set; }
        public int GodineClanstva { get; set; }
        public int IdPromoKod { get; set; }
    }
}
