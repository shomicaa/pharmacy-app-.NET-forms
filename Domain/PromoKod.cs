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

        public string WhereCondition => $"Id={IdPromoKod}";

        public object SelectValues => "*";

        public string UpdateValues => $"IznosPopusta = {IznosPopusta}, DatumIsteka = '{DatumIsteka:ddMMyyyy}'";

        public string InsertValues => $"{IznosPopusta}, '{DatumIsteka:ddMMyyyy}'";

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
