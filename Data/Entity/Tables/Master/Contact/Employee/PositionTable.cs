using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Tables.Master.Contact.Employee
{
    public class PositionTable : TableMasterObjectBase
    {
        //Field

        //FK

        //C-FK
        public virtual ICollection<EmployeeTable> EmployeeTables { get; set; }

       
    }
}
