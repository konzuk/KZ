using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.Location
{
    public class LocationTypeTable : TableMasterObjectBase
    {
    
        
        public string Description { get; set; }

        public virtual Collection<LocationTable> LocationTables { get; set; }
     

    }
}
