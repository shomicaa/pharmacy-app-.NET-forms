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
    public class Lek : IEntity
    {
        public int IdLek { get; set; }
        public string Naziv { get; set; }
        public DateTime RokTrajanja { get; set; }
        public int Kolicina { get; set; }
        public ZemljaPorekla ZemljaPorekla { get; set; }
        public double Cena { get; set; }

        public string TableName => "Lek";

        public string WhereCondition => $"Id={IdLek}";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string InsertValues => $"'{Naziv}', '{RokTrajanja:ddMMyyyy}', {Kolicina}, {(int)ZemljaPorekla}, {Cena}";

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Lek l = new Lek()
            {
                IdLek = reader.GetInt32("Id"),
                Naziv = reader.GetString("Naziv"),
                RokTrajanja = reader.GetDateTime("RokTrajanja"),
                Kolicina = reader.GetInt32("Kolicina"),
                ZemljaPorekla = (ZemljaPorekla)reader.GetInt32("ZemljaPorekla"),
                Cena = reader.GetInt32("Cena"),
            };
            return l;
        }
    }
}
