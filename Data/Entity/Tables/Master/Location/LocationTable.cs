using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Location
{
    public class LocationTable : TableMasterObjectBase
    {
        
       
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }

        public int? LocationTypeId { get; set; }
        [ForeignKey("LocationTypeId")]
        public virtual LocationTypeTable LocationTypeTable { get; set; }

        public int? WarehouseId { get; set; }
        [ForeignKey("WarehouseId")]
        public virtual WarehouseTable WarehouseTable { get; set; }

        public int? ParentLocationId { get; set; }
        [ForeignKey("ParentLocationId"), InverseProperty("LocationTables")]
        public virtual LocationTable ParentLocationTable { get; set; }
        public virtual Collection<LocationTable> LocationTables { get; set; } 
        
        //public virtual Collection<LocationServiceTable> FromLocationServiceTables { get; set; }
        //public virtual Collection<LocationServiceTable> ToLocationServiceTables { get; set; }
        //public virtual Collection<HotelServiceTable> HotelServiceTables { get; set; }


      

       
    }
}
