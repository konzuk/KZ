using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class UserGroupTable : TableMasterObjectBase
    {
       

        public virtual Collection<UserTable> UserTables { get; set; }
        public virtual Collection<RoleTable> RoleTables { get; set; }

       
    }
}
