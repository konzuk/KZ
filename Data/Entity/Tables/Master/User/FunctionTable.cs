using System.Collections.Generic;

namespace Entity.Tables.Master.User
{
    public class FunctionTable : TableMasterObjectBase
    {

        //Field

        //FK

        //C-FK
        public virtual ICollection<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }

        
    }
}
