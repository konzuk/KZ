using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Tables.Master.Common;

namespace Entity.Tables.Master.Contact.Company
{
    public class CompanyTable : ContactTable
    {

        //Field

        //FK 
        public int CurrencyId { get; set; }
        [ForeignKey("CurrencyId"), InverseProperty("CompanyTables")]
        public virtual CurrencyTable CurrencyTable { get; set; }

        //C-FK
        public virtual ICollection<DepartmentTable> DepartmentTables { get; set; }
    }
}
