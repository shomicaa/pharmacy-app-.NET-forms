using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IJoinEntity
    {
        public string TableName { get; }
        public string TableAlias { get; }
        object SelectValues { get; }
        string JoinClause { get; }
        string WhereClause { get; }
        Dictionary<string, object> JoinParameters { get; set; }

        List<IEntity> ReadAll(SqlDataReader reader);
        IEntity ReadObjectRow(SqlDataReader reader);
    }
}
