using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.BusinessUnit;
using MainEntity.Tables.Journal;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Common
{
    public class CurrencyTable : TableMasterObjectBase
    {
        
        public string CurrencySymbol { get; set; }

        
        public virtual Collection<ExchangeRateTable> FromExchangeRateTables { get; set; }
        public virtual Collection<ExchangeRateTable> ToExchangeRateTables { get; set; }
        
        public virtual Collection<JournalTable> JournalTables { get; set; }
       
        
    }
}
