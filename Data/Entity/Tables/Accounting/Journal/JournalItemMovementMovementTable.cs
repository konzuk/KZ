using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Master.Location;

namespace Main.Tables.Accounting.Journal
{
    public class JournalItemMovementMovementTable : JournalItemTable
    {
        //Field
        public bool IsStockIn { get; set; }

        //FK
        public int LocationId { get; set; }
        [ForeignKey("LocationId"), InverseProperty("JournalItemMovementMovementTables")]
        public virtual LocationTable LocationTable { get; set; }

        //C-FK
    }
}
