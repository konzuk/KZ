using System.Collections.Generic;
using System.Collections.ObjectModel;
using Main.Tables.Accounting.Journal;
using Main.Tables.Master.Contact.Company;

namespace Main.Tables.Master.Common
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
