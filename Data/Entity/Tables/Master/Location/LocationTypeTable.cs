using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Tables.Master.Location
{
    public class LocationTypeTable : TableMasterObjectBase
    {
    
        //Field
        public string Description { get; set; }

        //FK

        //C-FK
        public virtual ICollection<LocationTable> LocationTables { get; set; }
     

    }
}
