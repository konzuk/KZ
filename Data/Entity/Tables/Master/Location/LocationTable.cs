using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Accounting.Journal;
using Main.Tables.Master.Contact;

namespace Main.Tables.Master.Location
{
    public class LocationTable : TableMasterObjectBase
    {
        
        //Field
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }

        //FK
        public int LocationTypeId { get; set; }
        [ForeignKey("LocationTypeId"), InverseProperty("LocationTables")]
        public virtual LocationTypeTable LocationTypeTable { get; set; }

        public int? ParentLocationId { get; set; }
        [ForeignKey("ParentLocationId"), InverseProperty("ChildLocationTables")]
        public virtual LocationTable ParentLocationTable { get; set; }


        //C-FK
        public virtual ICollection<LocationTable> ChildLocationTables { get; set; }
        public virtual ICollection<ContactTable> ContactTables { get; set; }
        public virtual ICollection<JournalItemMovementMovementTable> JournalItemMovementMovementTables { get; set; }
       
    }
}
