using System.Collections.Generic;

namespace Entity.Tables.Master.User
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
