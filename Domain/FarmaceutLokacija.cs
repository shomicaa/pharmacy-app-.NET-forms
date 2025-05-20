using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FarmaceutLokacija
    {
        public int IdFarmaceut { get; set; }
        public int IdLokacija { get; set; }
        public DateTime DatumIzdavanjaDozvole { get; set; }
    }
}
