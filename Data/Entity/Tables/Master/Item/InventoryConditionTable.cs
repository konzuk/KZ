using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Accounting.Journal;

namespace Main.Tables.Master.Item
{
    public class InventoryConditionTable : TableMasterObjectBase
    {
      
        //Field

        //FK

        //C-FK
        public virtual ICollection<JournalItemTable> JournalItemTables { get; set; }
    }
}
