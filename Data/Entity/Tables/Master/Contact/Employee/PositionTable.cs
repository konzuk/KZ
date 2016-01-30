using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Employee
{
    public class PositionTable : TableMasterObjectBase
    {
        
        public virtual Collection<EmployeeTable> EmployeeTables { get; set; }

       
    }
}
