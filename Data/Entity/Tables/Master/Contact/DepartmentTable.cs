using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.BusinessUnit;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Employee
{
    public class DepartmentTable : TableMasterObjectBase
    {
        public int? ParentDepartmentId { get; set; }
        [ForeignKey("ParentDepartmentId"), InverseProperty("DepartmentTables")]
        public virtual DepartmentTable ParentDepartmentTable { get; set; }
       
        public virtual Collection<DepartmentTable> DepartmentTables { get; set; }
        public virtual Collection<EmployeeTable> EmployeeTables { get; set; }
        
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId"), InverseProperty("DepartmentTables")]
        public virtual CompanyTable CompanyTable { get; set; }

      
    }
}
