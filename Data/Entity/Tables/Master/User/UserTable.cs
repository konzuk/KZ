using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Accounting.Journal;
using Main.Tables.Master.Contact.Employee;

namespace Main.Tables.Master.User
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