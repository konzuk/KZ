using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class FunctionTable : TableMasterObjectBase
    {
       

        public virtual Collection<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }

        
    }
}
