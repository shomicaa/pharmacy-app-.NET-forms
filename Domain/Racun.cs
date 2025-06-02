using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Racun : IEntity, IJoinEntity
    {
        public int IdRacun { get; set; }
        public List<StavkaRacuna> Stavke { get; set; }
        public double UkupnaVrednost { get; set; }
        public double IznosPoreza { get; set; }
        public double UkupnaVrednostSaPorezom { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int IdFarmaceut { get; set; }
        public int IdKorisnik { get; set; }

        public string TableName => "Racun";
        public object SelectValues => "*";
        public string SearchKeyword { get; set; }
        public string JoinClause { get; set; } 
        public string WhereClause { get; set; }
        public Dictionary<string, object> JoinParameters { get; set; } = new();


        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@UkupnaVrednost"] = UkupnaVrednost,
            ["@IznosPoreza"] = IznosPoreza,
            ["@UkupnaVrednostSaPorezom"] = UkupnaVrednostSaPorezom,
            ["@DatumIzdavanja"] = DatumIzdavanja,
            ["@IdFarmaceut"] = IdFarmaceut,
            ["@IdKorisnik"] = IdKorisnik
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@Id"] = IdRacun,
            ["@UkupnaVrednost"] = UkupnaVrednost,
            ["@IznosPoreza"] = IznosPoreza,
            ["@UkupnaVrednostSaPorezom"] = UkupnaVrednostSaPorezom,
            ["@DatumIzdavanja"] = DatumIzdavanja,
            ["@IdFarmaceut"] = IdFarmaceut,
            ["@IdKorisnik"] = IdKorisnik
        };

        public string GetUpdateQuery() =>
            "SET UkupnaVrednost = @UkupnaVrednost, IznosPoreza = @IznosPoreza, UkupnaVrednostSaPorezom = @UkupnaVrednostSaPorezom, " +
            "DatumIzdavanja = @DatumIzdavanja, IdFarmaceut = @IdFarmaceut, IdKorisnik = @IdKorisnik WHERE Id = @Id";

        public Dictionary<string, object> GetDeleteParameters() => new() { ["@Id"] = IdRacun };
        public string GetDeleteCondition() => "Id = @Id";

        public string GetFindCondition() => "Id = @Id";
        public Dictionary<string, object> GetFindParameters() =>
            new() { ["@Id"] = IdRacun };

        public string GetSearchCondition() => "Id = @kw";
        public Dictionary<string, object> GetSearchParameters() =>
            new() { ["@kw"] = int.Parse(SearchKeyword) };


        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Racun r = new Racun()
            {
                IdRacun = reader.GetInt32("Id"),
                UkupnaVrednost = reader.GetDouble("UkupnaVrednost"),
                IznosPoreza = reader.GetDouble("IznosPoreza"),
                UkupnaVrednostSaPorezom = reader.GetDouble("UkupnaVrednostSaPorezom"),
                DatumIzdavanja = reader.GetDateTime("DatumIzdavanja"),
                IdFarmaceut = reader.GetInt32("IdFarmaceut"),
                IdKorisnik = reader.GetInt32("IdKorisnik")
            };
            return r;
        }

        public List<IEntity> ReadAll(SqlDataReader reader)
        {
            List<IEntity> racuni = new();
            while (reader.Read())
            {
                racuni.Add(ReadObjectRow(reader));
            }
            return racuni;
        }
    }
}
