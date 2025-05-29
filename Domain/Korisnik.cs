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
        public object SelectValues => "*";
        public string SearchKeyword { get; set; }

        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@Ime"] = Ime,
            ["@Prezime"] = Prezime,
            ["@Email"] = Email,
            ["@KontaktTelefon"] = KontaktTelefon,
            ["@DatumUclanjenja"] = DatumUclanjenja,
            ["@GodineClanstva"] = GodineClanstva,
            ["@IdPromoKod"] = IdPromoKod
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@Id"] = IdKorisnik,
            ["@Ime"] = Ime,
            ["@Prezime"] = Prezime,
            ["@Email"] = Email,
            ["@KontaktTelefon"] = KontaktTelefon,
            ["@DatumUclanjenja"] = DatumUclanjenja,
            ["@GodineClanstva"] = GodineClanstva,
            ["@IdPromoKod"] = IdPromoKod
        };

        public string GetUpdateQuery() =>
            "SET Ime = @Ime, Prezime = @Prezime, Email = @Email, KontaktTelefon = @KontaktTelefon, " +
            "DatumUclanjenja = @DatumUclanjenja, GodineClanstva = @GodineClanstva, IdPromoKod = @IdPromoKod " +
            "WHERE Id = @Id";

        public Dictionary<string, object> GetDeleteParameters() => new() { ["@Id"] = IdKorisnik };
        public string GetDeleteCondition() => "Id = @Id";

        public string GetSearchCondition() =>
            "Ime LIKE @kw OR Prezime LIKE @kw";

        public Dictionary<string, object> GetSearchParameters() =>
            new() { ["@kw"] = SearchKeyword + "%" };

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
