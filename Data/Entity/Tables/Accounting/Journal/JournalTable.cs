using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Main.Tables.Master.Common;
using Main.Tables.Master.Contact;
using Main.Tables.Master.Location;
using Main.Tables.Master.User;

namespace Main.Tables.Accounting.Journal
{
    public class JournalTable : TableBase
    {

        //Field
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalId { get; set; }
        [Index("JournalCode_Index", 1, IsUnique = true), Required, MaxLength(200)]
        public string JournalCode { get; set; }
       
        
        //FK
        public int JournalStatusId { get; set; }
        [ForeignKey("JournalStatusId"),InverseProperty("JournalTables")]
        public virtual JournalStatusTable JournalStatusTable { get; set; }
        
        public int TransactionTypeId { get; set; }
        [ForeignKey("TransactionTypeId"), InverseProperty("JournalTables")]
        public virtual TransactionTypeTable TransactionTypeTable { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId"), InverseProperty("JournalTables")]
        public virtual UserTable UserTable { get; set; }


        //C-FK
        public virtual ICollection<JournalItemTable> JournalItemTables { get; set; }


      
    }
}
