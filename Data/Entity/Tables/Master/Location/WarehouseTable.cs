using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Journal;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Location
{
    public class WarehouseTable : TableMasterObjectBase
    {

       
        public string Description { get; set; }

        public virtual Collection<LocationTable> LocationTables { get; set; } 
        public virtual Collection<JournalTable> JournalTables { get; set; }

     
    }
}
