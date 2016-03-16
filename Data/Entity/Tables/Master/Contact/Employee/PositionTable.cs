using System.Collections.Generic;

namespace Entity.Tables.Master.Contact.Employee
{
    public class PositionTable : TableMasterObjectBase
    {
        //Field

        //FK

        //C-FK
        public virtual ICollection<EmployeeTable> EmployeeTables { get; set; }

       
    }
}
