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
    public class StavkaRacuna : IEntity
    {
        public int IdRacun { get; set; }
        public int RbStavke { get; set; }
        public int Kolicina { get; set; }
        public double ProdajnaVrednost{ get; set; }
        public int IdLek { get; set; }

        public string TableName => "StavkaRacuna";
        public object SelectValues => "*";

        public string SearchKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetDeleteCondition()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetDeleteParameters()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetInsertParameters()
        {
            throw new NotImplementedException();
        }

        public string GetSearchCondition()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetSearchParameters()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetUpdateParameters()
        {
            throw new NotImplementedException();
        }

        public string GetUpdateQuery()
        {
            throw new NotImplementedException();
        }

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            StavkaRacuna sr = new StavkaRacuna()
            {
                IdRacun = reader.GetInt32("IdRacun"),
                RbStavke = reader.GetInt32("RbStavke"),
                Kolicina = reader.GetInt32("Kolicina"),
                ProdajnaVrednost = reader.GetDouble("ProdajnaVrednost"),
                IdLek = reader.GetInt32("IdLek")
            };
            return sr;
        }
    }
}
