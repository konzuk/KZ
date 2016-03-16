using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Tables.Master.Contact.Company;
using Entity.Tables.Master.Contact.Employee;

namespace Entity.Tables.Master.Contact
{
    public class DepartmentTable : TableMasterObjectBase
    {


        //Field

        //FK
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId"), InverseProperty("DepartmentTables")]
        public virtual CompanyTable CompanyTable { get; set; }

        //C-FK
        public virtual ICollection<EmployeeTable> EmployeeTables { get; set; }
        
        

      
    }
}
