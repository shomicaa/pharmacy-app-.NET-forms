using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Lek
    {
        public int IdLek { get; set; }
        public string Naziv { get; set; }
        public DateTime RokTrajanja { get; set; }
        public int Kolicina { get; set; }
        public ZemljaPorekla ZemljaPorekla { get; set; }
        public double Cena { get; set; }
    }
}
