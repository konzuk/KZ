using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Journal
{
    public class JournalStatusTable : TableMasterObjectBase
    {
        
        public virtual Collection<JournalTable> JournalTables { get; set; } 
    }
}
