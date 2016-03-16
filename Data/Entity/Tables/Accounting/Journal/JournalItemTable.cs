using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Tables.Master.Common;
using Entity.Tables.Master.Contact;
using Entity.Tables.Master.Item;

namespace Entity.Tables.Accounting.Journal
{
    public class JournalItemTable :TableBase
    {

        //Field
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalItemId { get; set; }

        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        
        public string Note { get; set; }

        private DateTime _journalUtcDateTime = DateTime.UtcNow;
        public DateTime JournalUctDateTime
        {
            get { return _journalUtcDateTime; }
            set { _journalUtcDateTime = value; }
        }

        //FK
        public int JournalId { get; set; }
        [ForeignKey("JournalId"), InverseProperty("JournalItemTables")]
        public virtual JournalTable JournalTable { get; set; }

        public int CurrencyId { get; set; }
        [ForeignKey("CurrencyId"), InverseProperty("JournalItemTables")]
        public CurrencyTable CurrencyTable { get; set; }

        public int ContactId { get; set; }
        [ForeignKey("ContactId"), InverseProperty("JournalItemTables")]
        public virtual ContactTable ContactTable { get; set; }

        public int ItemId { get; set; }
        [ForeignKey("ItemId"), InverseProperty("JournalItemTables")]
        public virtual ItemTable ItemTable { get; set; }

        public int InventoryConditionId { get; set; }
        [ForeignKey("InventoryConditionId"), InverseProperty("JournalItemTables")]
        public virtual InventoryConditionTable InventoryConditionTable { get; set; }
        

        //C-FK
        public virtual ICollection<JournalItemAccountTable> JournalItemAccountTables { get; set; }
        

        //Other

        [NotMapped]
        public DateTime JournalLocalDateTime
        {
            get { return _journalUtcDateTime.ToLocalTime(); }
            set { _journalUtcDateTime = value.ToUniversalTime(); }
        }
    }
}
