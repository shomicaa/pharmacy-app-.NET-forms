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

        public string WhereCondition => $"Id={IdLokacija}";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string InsertValues => $"'{AdresaLokacije}', '{Opstina}'";

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
