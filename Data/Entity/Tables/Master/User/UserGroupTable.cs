using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Tables.Master.User
{
    public class UserGroupTable : TableMasterObjectBase
    {

        

        //Field

        //FK

        //C-FK
        public virtual ICollection<UserTable> UserTables { get; set; }
        public virtual ICollection<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }

       
    }
}
