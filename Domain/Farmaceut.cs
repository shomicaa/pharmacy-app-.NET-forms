using Microsoft.Data.SqlClient;
using System.Data;

namespace Domain
{
    [Serializable]
    public class Farmaceut : IEntity, IJoinEntity
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
        public object SelectValues => "*";
        public string SearchKeyword { get; set; }
        public string JoinClause { get; set; }
        public string WhereClause { get; set; }
        public Dictionary<string, object> JoinParameters { get; set; } = new();

        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@Ime"] = Ime,
            ["@Prezime"] = Prezime,
            ["@Email"] = Email,
            ["@KontaktTelefon"] = KontaktTelefon,
            ["@DatumZaposlenja"] = DatumZaposlenja,
            ["@KorisnickoIme"] = KorisnickoIme,
            ["@Lozinka"] = Lozinka
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@Id"] = IdFarmaceut,
            ["@Ime"] = Ime,
            ["@Prezime"] = Prezime,
            ["@Email"] = Email,
            ["@KontaktTelefon"] = KontaktTelefon,
            ["@DatumZaposlenja"] = DatumZaposlenja,
            ["@KorisnickoIme"] = KorisnickoIme,
            ["@Lozinka"] = Lozinka
        };

        public string GetUpdateQuery() =>
            "SET Ime = @Ime, Prezime = @Prezime, Email = @Email, KontaktTelefon = @KontaktTelefon, " +
            "DatumZaposlenja = @DatumZaposlenja, KorisnickoIme = @KorisnickoIme, Lozinka = @Lozinka " +
            "WHERE Id = @Id";

        public Dictionary<string, object> GetDeleteParameters() => new() { ["@Id"] = IdFarmaceut };
        public string GetDeleteCondition() => "Id = @Id";

        public string GetFindCondition() => "Id = @Id";
        public Dictionary<string, object> GetFindParameters() =>
            new() { ["@Id"] = IdFarmaceut };

        public string GetSearchCondition() =>
            "Ime + ' ' + Prezime LIKE @kw";
        public Dictionary<string, object> GetSearchParameters() =>
            new() { ["@kw"] = SearchKeyword + "%" };

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

        public List<IEntity> ReadAll(SqlDataReader reader)
        {
            List<IEntity> farmaceuti = new();
            while (reader.Read())
            {
                farmaceuti.Add(ReadObjectRow(reader));
            }
            return farmaceuti;
        }
    }
}
