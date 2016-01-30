using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Common;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Employee;
using MainEntity.Tables.Journal;
using MainEntity.Tables.Location;

namespace MainEntity.Tables.User
{
    public class UserTable : TableMasterObjectBase
    {
        
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public int? UserGroupId { get; set; }
        [ForeignKey("UserGroupId"), InverseProperty("UserTables")]
        public virtual UserGroupTable UserGroupTable { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId"), InverseProperty("UserTables")]
        public virtual EmployeeTable EmployeeTable { get; set; }

        public virtual Collection<UserSessionTable> UserSessionTables { get; set; } 
        
    }
}