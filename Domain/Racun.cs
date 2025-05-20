using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Racun : IEntity
    {
        public int IdRacun { get; set; }
        public List<StavkaRacuna> Stavke { get; set; }
        public double UkupnaVrednost { get; set; }
        public double IznosPoreza { get; set; }
        public double UkupnaVrednostSaPorezom { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int IdFarmaceut { get; set; }
        public int IdKorisnik { get; set; }

        public string TableName => "Racun";

        public string WhereCondition => $"Id={IdRacun}";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string InsertValues => $"{UkupnaVrednost}, {IznosPoreza}, {UkupnaVrednostSaPorezom}, '{DatumIzdavanja:ddMMyyyy}', {IdFarmaceut}, {IdKorisnik}";

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Racun r = new Racun()
            {
                IdRacun = reader.GetInt32("Id"),
                UkupnaVrednost = reader.GetDouble("UkupnaVrednost"),
                IznosPoreza = reader.GetDouble("IznosPoreza"),
                UkupnaVrednostSaPorezom = reader.GetDouble("UkupnaVrednostSaPorezom"),
                DatumIzdavanja = reader.GetDateTime("DatumIzdavanja"),
                IdFarmaceut = reader.GetInt32("IdFarmaceut"),
                IdKorisnik = reader.GetInt32("IdKorisnik")
            };
            return r;
        }
    }
}
