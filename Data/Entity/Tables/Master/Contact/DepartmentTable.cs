using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Master.Contact.Company;
using Main.Tables.Master.Contact.Employee;

namespace Main.Tables.Master.Contact
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
