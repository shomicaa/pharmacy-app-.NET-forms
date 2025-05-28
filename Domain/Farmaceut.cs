using Microsoft.Data.SqlClient;
using System.Data;

namespace Domain
{
    [Serializable]
    public class Farmaceut : IEntity
    {
        public int IdFarmaceut { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KontaktTelefon { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string TableName => "Farmaceut";

        public string WhereCondition => $"Id={IdFarmaceut}";

        public object SelectValues => "*";

        public string UpdateValues => $"Ime = '{Ime}', Prezime = '{Prezime}', Email = '{Email}', KontaktTelefon = '{KontaktTelefon}', DatumZaposlenja = '{DatumZaposlenja:ddMMyyyy}', KorisnickoIme ='{KorisnickoIme}', Lozinka = '{Lozinka}'";

        public string InsertValues => $"'{Ime}','{Prezime}', '{Email}', '{KontaktTelefon}', '{DatumZaposlenja:ddMMyyyy}', '{KorisnickoIme}', '{Lozinka}'";

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Farmaceut f = new Farmaceut() {
                IdFarmaceut = reader.GetInt32("Id"),
                Ime = reader.GetString("Ime"),
                Prezime = reader.GetString("Prezime"),
                Email = reader.GetString("Email"),
                KontaktTelefon = reader.GetString("KontaktTelefon"),
                DatumZaposlenja = reader.GetDateTime("DatumZaposlenja"),
                KorisnickoIme = reader.GetString("KorisnickoIme"),
                Lozinka = reader.GetString("Lozinka"),
            };
            
            return f;
        }
    }
}
