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
    public class Lek : IEntity, IJoinEntity
    {
        public int IdLek { get; set; }
        public string Naziv { get; set; }
        public DateTime RokTrajanja { get; set; }
        public int Kolicina { get; set; }
        public ZemljaPorekla ZemljaPorekla { get; set; }
        public double Cena { get; set; }

        public string TableName => "Lek";
        public object SelectValues => "*";
        public string SearchKeyword { get; set; }

        public string TableAlias => "l";

        public string JoinClause {get;set;}

        public string WhereClause { get; set; }

        public Dictionary<string, object> JoinParameters { get; set; }

        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@Naziv"] = Naziv,
            ["@RokTrajanja"] = RokTrajanja,
            ["@Kolicina"] = Kolicina,
            ["@ZemljaPorekla"] = (int)ZemljaPorekla,
            ["@Cena"] = Cena
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@Id"] = IdLek,
            ["@Naziv"] = Naziv,
            ["@RokTrajanja"] = RokTrajanja,
            ["@Kolicina"] = Kolicina,
            ["@ZemljaPorekla"] = (int)ZemljaPorekla,
            ["@Cena"] = Cena
        };

        public string GetUpdateQuery() =>
            "SET Naziv = @Naziv, RokTrajanja = @RokTrajanja, Kolicina = @Kolicina, ZemljaPorekla = @ZemljaPorekla, Cena = @Cena " +
            "WHERE Id = @Id";

        public Dictionary<string, object> GetDeleteParameters() => new() { ["@Id"] = IdLek };
        public string GetDeleteCondition() => "Id = @Id";

        public string GetFindCondition() => "Id = @Id";
        public Dictionary<string, object> GetFindParameters() =>
            new() { ["@Id"] = IdLek };

        public string GetSearchCondition() => "Naziv LIKE @kw";
        public Dictionary<string, object> GetSearchParameters() =>
            new() { ["@kw"] = SearchKeyword + "%" };


        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Lek l = new Lek()
            {
                IdLek = reader.GetInt32("Id"),
                Naziv = reader.GetString("Naziv"),
                RokTrajanja = reader.GetDateTime("RokTrajanja"),
                Kolicina = reader.GetInt32("Kolicina"),
                ZemljaPorekla = (ZemljaPorekla)reader.GetInt32("ZemljaPorekla"),
                Cena = reader.GetDouble("Cena"),
            };
            return l;
        }

        public List<IEntity> ReadAll(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
