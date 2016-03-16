using System.ComponentModel.DataAnnotations.Schema;
using Entity.Tables.Master.Location;

namespace Entity.Tables.Accounting.Journal
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
