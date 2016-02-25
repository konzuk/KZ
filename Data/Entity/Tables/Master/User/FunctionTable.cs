using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Tables.Master.User
{
    public class FunctionTable : TableMasterObjectBase
    {

        //Field

        //FK

        //C-FK
        public virtual ICollection<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }

        
    }
}
