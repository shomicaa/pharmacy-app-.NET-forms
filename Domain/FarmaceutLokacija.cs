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

        public string TableName => "FarmaceutLokacija";
        public object SelectValues => "*";

        public string SearchKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Dictionary<string, object> GetInsertParameters() => new()
        {
            ["@IdFarmaceut"] = IdFarmaceut,
            ["@IdLokacija"] = IdLokacija,
            ["@DatumIzdavanjaDozvole"] = DatumIzdavanjaDozvole
        };

        public Dictionary<string, object> GetUpdateParameters() => new()
        {
            ["@IdFarmaceut"] = IdFarmaceut,
            ["@IdLokacija"] = IdLokacija,
            ["@DatumIzdavanjaDozvole"] = DatumIzdavanjaDozvole
        };

        public string GetUpdateQuery() =>
            "SET DatumIzdavanjaDozvole = @DatumIzdavanjaDozvole WHERE IdFarmaceut = @IdFarmaceut AND IdLokacija = @IdLokacija";

        public Dictionary<string, object> GetDeleteParameters() => new()
        {
            ["@IdFarmaceut"] = IdFarmaceut,
            ["@IdLokacija"] = IdLokacija
        };

        public string GetDeleteCondition() => "IdFarmaceut = @IdFarmaceut AND IdLokacija = @IdLokacija";

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

        public string GetSearchCondition()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetSearchParameters()
        {
            throw new NotImplementedException();
        }

        public string GetFindCondition()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> GetFindParameters()
        {
            throw new NotImplementedException();
        }
    }
}
