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
    public class FarmaceutLokacija : IEntity
    {
        public int IdFarmaceut { get; set; }
        public int IdLokacija { get; set; }
        public DateTime DatumIzdavanjaDozvole { get; set; }

        public string TableName => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public object SelectValues => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            FarmaceutLokacija f = new FarmaceutLokacija()
            {
                IdFarmaceut = reader.GetInt32("IdFarmaceut"),
                IdLokacija = reader.GetInt32("IdLokacija"),
                DatumIzdavanjaDozvole = reader.GetDateTime("DatumIzdavanjaDozvole")
            };

            return f;
        }
    }
}
