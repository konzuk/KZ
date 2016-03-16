using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Tables.Accounting.Journal;
using Entity.Tables.Master.Contact;

namespace Entity.Tables.Master.Location
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
