using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Tables.Accounting.Journal
{
    public class JournalStatusTable : TableMasterObjectBase
    {
        //Field

        //FK

        //C-FK
        public virtual ICollection<JournalTable> JournalTables { get; set; } 
    }
}
