using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Tables.Accounting.Account;

namespace Entity.Tables.Accounting.Journal
{
    public class JournalItemAccountTable : TableBase
    {

        //Field
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalItemAccountId { get; set; }
        public bool IsDebit { get; set; }
        public bool IsVoided { get; set; }

        //FK
        public int JournalItemId { get; set; }
        [ForeignKey("JournalItemId"), InverseProperty("JournalItemAccountTables")]
        public virtual JournalItemTable JournalItemTable { get; set; }

        public int AccountId { get; set; }
        [ForeignKey("AccountId"), InverseProperty("JournalItemAccountTables")]
        public virtual AccountTable AccountTable { get; set; }


        public int? PaytoId { get; set; }
        [ForeignKey("PaytoId"), InverseProperty("PaymentJournalItemAccountTables")]
        public virtual JournalItemAccountTable PaytoJournalItemAccountTables { get; set; }
        //C-FK

        public virtual ICollection<JournalItemAccountTable> PaymentJournalItemAccountTables { get; set; }
       


    }
}
