using System.Collections.Generic;

namespace Entity.Tables.Master.User
{
    public class ApplicationTable : TableMasterObjectBase
    {
        
        //Field

        //FK

        //C-FK
        public virtual ICollection<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }

       
    }
}
