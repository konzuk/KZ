using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Tables.Master.User
{
    public class ApplicationTable : TableMasterObjectBase
    {
        
        //Field

        //FK

        //C-FK
        public virtual ICollection<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }

       
    }
}
