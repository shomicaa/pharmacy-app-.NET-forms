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
        public double IznosPopusta { get; set; } = 0;
        public DateTime DatumNastanka { get; set; } = DateTime.Today;

        public string TableName => "PromoKod";
        public object SelectValues => "*";
        public string SearchKeyword { get; set; }

        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@IznosPopusta"] = IznosPopusta,
            ["@DatumNastanka"] = DatumNastanka
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@Id"] = IdPromoKod,
            ["@IznosPopusta"] = IznosPopusta,
            ["@DatumNastanka"] = DatumNastanka
        };

        public string GetUpdateQuery() =>
            "SET IznosPopusta = @IznosPopusta, DatumNastanka = @DatumNastanka WHERE Id = @Id";

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
                DatumNastanka = reader.GetDateTime("DatumNastanka"),
            };
            return p;
        }
    }
}
