using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Master.Common;

namespace Main.Tables.Master.Contact.Company
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
