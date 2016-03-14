using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Tables.Accounting.Journal;
using Entity.Tables.Master.Contact.Employee;

namespace Entity.Tables.Master.User
{
    public class UserTable : TableMasterObjectBase
    {
        //Field
        public string Password { get; set; }
        public bool IsActive { get; set; }

        //FK

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId"), InverseProperty("UserTables")]
        public virtual EmployeeTable EmployeeTable { get; set; }

        //C-FK
        public virtual ICollection<UserSessionTable> UserSessionTables { get; set; }
        public virtual ICollection<UserGroupTable> UserGroupTables { get; set; }
        public virtual ICollection<JournalTable> JournalTables { get; set; }

    }
}