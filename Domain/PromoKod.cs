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
    public class PromoKod : IEntity
    {
        public int IdPromoKod { get; set; }
        public double IznosPopusta { get; set; }
        public DateTime DatumIsteka { get; set; }

        public string TableName => "PromoKod";
        public object SelectValues => "*";
        public string SearchKeyword { get; set; }

        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@IznosPopusta"] = IznosPopusta,
            ["@DatumIsteka"] = DatumIsteka
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@Id"] = IdPromoKod,
            ["@IznosPopusta"] = IznosPopusta,
            ["@DatumIsteka"] = DatumIsteka
        };

        public string GetUpdateQuery() =>
            "SET IznosPopusta = @IznosPopusta, DatumIsteka = @DatumIsteka WHERE Id = @Id";

        public Dictionary<string, object> GetDeleteParameters() => new() { ["@Id"] = IdPromoKod };
        public string GetDeleteCondition() => "Id = @Id";

        public string GetFindCondition() => "Id = @Id";
        public Dictionary<string, object> GetFindParameters() =>
            new() { ["@Id"] = IdPromoKod };

        public string GetSearchCondition() => "Id = @kw";
        public Dictionary<string, object> GetSearchParameters() =>
            new() { ["@kw"] = int.Parse(SearchKeyword) };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            PromoKod p = new PromoKod()
            {
                IdPromoKod = reader.GetInt32("Id"),
                IznosPopusta = reader.GetDouble("IznosPopusta"),
                DatumIsteka = reader.GetDateTime("DatumIsteka"),
            };
            return p;
        }
    }
}
