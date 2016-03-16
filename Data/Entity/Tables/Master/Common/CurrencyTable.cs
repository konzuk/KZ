using System.Collections.Generic;
using Entity.Tables.Accounting.Journal;
using Entity.Tables.Master.Contact.Company;

namespace Entity.Tables.Master.Common
{
    public class CurrencyTable : TableMasterObjectBase
    {
        //Field
        public string CurrencySymbol { get; set; }

        //FK


        //C-FK
        public virtual ICollection<ExchangeRateTable> FromExchangeRateTables { get; set; }
        public virtual ICollection<ExchangeRateTable> ToExchangeRateTables { get; set; }

        public virtual ICollection<JournalItemTable> JournalItemTables { get; set; }
        public virtual ICollection<CompanyTable> CompanyTables { get; set; }


    }
}
