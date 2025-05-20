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

        public string WhereCondition => $"IdRacun={IdRacun} AND RbStavke={RbStavke}";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string InsertValues => $"{IdRacun}, {RbStavke}, {Kolicina}, {ProdajnaVrednost}, {IdLek}";

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
