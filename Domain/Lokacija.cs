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
    public class Lokacija : IEntity
    {
        public int IdLokacija { get; set; }
        public string AdresaLokacije { get; set; }
        public string Opstina { get; set; }

        public string TableName => "Lokacija";
        public object SelectValues => "*";
        public string SearchKeyword { get; set; }

        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@AdresaLokacije"] = AdresaLokacije,
            ["@Opstina"] = Opstina
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@Id"] = IdLokacija,
            ["@AdresaLokacije"] = AdresaLokacije,
            ["@Opstina"] = Opstina
        };

        public string GetUpdateQuery() =>
            "SET AdresaLokacije = @AdresaLokacije, Opstina = @Opstina WHERE Id = @Id";

        public Dictionary<string, object> GetDeleteParameters() => new() { ["@Id"] = IdLokacija };
        public string GetDeleteCondition() => "Id = @Id";

        public string GetSearchCondition() => "Id = @kw";
        public Dictionary<string, object> GetSearchParameters() =>
            new() { ["@kw"] = int.Parse(SearchKeyword) };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Lokacija l = new Lokacija()
            {
                IdLokacija = reader.GetInt32("Id"),
                AdresaLokacije = reader.GetString("AdresaLokacije"),
                Opstina = reader.GetString("Opstina"),
            };
            return l;
        }
    }
}
