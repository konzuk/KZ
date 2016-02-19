using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Accounting.Journal;

namespace Main.Tables.Master.Item
{
    public class InventoryConditionTable : TableMasterObjectBase
    {
      

        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }
    }
}
