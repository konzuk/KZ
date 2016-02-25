using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Master.User;

namespace Main.Tables.Master.Contact.Employee
{
    public class EmployeeTable : ContactTable
    {


        //Field
        public DateTime DateOfBirth { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsResigned { get; set; }
        public DateTime ResignedDate { get; set; }
        public string Reason { get; set; }

        //FK
        public int? PositionId { get; set; }
        [ForeignKey("PositionId"),InverseProperty("EmployeeTables")]
        public virtual PositionTable PositionTable { get; set; }

        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId"), InverseProperty("EmployeeTables")]
        public virtual DepartmentTable DepartmentTable { get; set; }

        //C-FK
        public virtual ICollection<UserTable> UserTables { get; set; } 




    }
}
