using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class TransactionTypeTable: TableMasterObjectBase
    {
      
       
        public virtual Collection<JournalTable> JournalTables { get; set; } 
    }
}
