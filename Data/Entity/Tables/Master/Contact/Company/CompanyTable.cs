
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Common;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Employee;

namespace MainEntity.Tables.BusinessUnit
{
    public class CompanyTable : ContactTable
    {
       

        public int? CurrencyId { get; set; }
        [ForeignKey("CurrencyId")]
        public virtual CurrencyTable CurrencyTable { get; set; }
        
        public virtual Collection<DepartmentTable> DepartmentTables { get; set; }
    }
}
