using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Lek Lek { get; set; }

        public string TableName => "StavkaRacuna";
        public object SelectValues => "*";

        public string SearchKeyword { get; set; }

        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@IdRacun"] = IdRacun,
            ["@RbStavke"] = RbStavke,
            ["@Kolicina"] = Kolicina,
            ["@ProdajnaVrednost"] = ProdajnaVrednost,
            ["@IdLek"] = IdLek
        };


        public string GetDeleteCondition() => "IdRacun = @IdRacun AND RbStavke = @RbStavke";

        public Dictionary<string, object> GetDeleteParameters() => new()
        {
            ["@IdRacun"] = IdRacun,
            ["@RbStavke"] = RbStavke
        };

        public string GetFindCondition()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetFindParameters()
        {
            throw new NotImplementedException();
        }



        public string GetSearchCondition() => "IdRacun = @kw";

        public Dictionary<string, object> GetSearchParameters() => new()
        {
            ["@kw"] = int.Parse(SearchKeyword)
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@IdRacun"] = IdRacun,
            ["@RbStavke"] = RbStavke,
            ["@Kolicina"] = Kolicina,
            ["@ProdajnaVrednost"] = ProdajnaVrednost,
            ["@IdLek"] = IdLek
        };

        public string GetUpdateQuery() =>
            "SET Kolicina = @Kolicina, ProdajnaVrednost = @ProdajnaVrednost, IdLek = @IdLek WHERE IdRacun = @IdRacun AND RbStavke = @RbStavke";

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

        public override int GetHashCode()
        {
            return HashCode.Combine(IdRacun, RbStavke, Kolicina, ProdajnaVrednost, IdLek);
        }


    }
}
