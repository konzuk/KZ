using System.Collections.Generic;

namespace Entity.Tables.Accounting.Journal
{
    public class TransactionTypeTable: TableMasterObjectBase
    {
        //Field

        //FK

        //C-FK
        public virtual ICollection<JournalTable> JournalTables { get; set; } 
    }
}
