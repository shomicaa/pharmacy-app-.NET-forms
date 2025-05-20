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
        string WhereCondition { get; }
        object SelectValues { get; }
        string UpdateValues { get; }
        public string InsertValues { get; }
    }
}
