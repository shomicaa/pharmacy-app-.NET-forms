using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntity
    {
        public string TableName { get; }
        object SelectValues { get; }
        string SearchKeyword { get; set; }

        Dictionary<string, object> GetInsertParameters();

        Dictionary<string, object> GetUpdateParameters();
        string GetUpdateQuery();

        Dictionary<string, object> GetDeleteParameters(); 
        string GetDeleteCondition();

        string GetSearchCondition();
        Dictionary<string, object> GetSearchParameters();

        IEntity ReadObjectRow(SqlDataReader reader);
    }
}
