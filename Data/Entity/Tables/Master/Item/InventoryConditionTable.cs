using System.Collections.Generic;
using Entity.Tables.Accounting.Journal;

namespace Entity.Tables.Master.Item
{
    public class InventoryConditionTable : TableMasterObjectBase
    {
      
        //Field

        //FK

        //C-FK
        public virtual ICollection<JournalItemTable> JournalItemTables { get; set; }
    }
}
