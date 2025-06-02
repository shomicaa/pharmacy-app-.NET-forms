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

        // for regular insert operations
        Dictionary<string, object> GetInsertParameters();

        // for regular update operations
        Dictionary<string, object> GetUpdateParameters();
        string GetUpdateQuery();

        // for regular delete operations
        Dictionary<string, object> GetDeleteParameters(); 
        string GetDeleteCondition();

        // for find operations (based on id) -> returns a single object
        string GetFindCondition();
        Dictionary<string, object> GetFindParameters();

        // for complex get operations -> returns a list of objects
        string GetSearchCondition();
        Dictionary<string, object> GetSearchParameters();

        // used to read an object row
        IEntity ReadObjectRow(SqlDataReader reader);
    }
}
