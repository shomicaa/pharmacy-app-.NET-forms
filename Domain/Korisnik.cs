using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Korisnik : IEntity
    {
        public int IdKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KontaktTelefon { get; set; }
        public DateTime DatumUclanjenja { get; set; }
        public int GodineClanstva { get; set; }
        public int IdPromoKod { get; set; }

        public string TableName => "Korisnik";

        public string WhereCondition => $"Id={IdKorisnik}";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string InsertValues => $"'{Ime}','{Prezime}', '{Email}', {KontaktTelefon}, '{DatumUclanjenja:ddMMyyyy}', {GodineClanstva}, {IdPromoKod}";

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Korisnik k = new Korisnik()
            {
                IdKorisnik = reader.GetInt32("Id"),
                Ime = reader.GetString("Ime"),
                Prezime = reader.GetString("Prezime"),
                Email = reader.GetString("Email"),
                KontaktTelefon = reader.GetString("KontaktTelefon"),
                DatumUclanjenja = reader.GetDateTime("DatumUclanjenja"),
                GodineClanstva = reader.GetInt32("GodineClanstva"),
                IdPromoKod = reader.GetInt32("IdPromoKod"),
            };

            return k;
        }
    }
}
