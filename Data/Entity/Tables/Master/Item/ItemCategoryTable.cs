﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Tables.Master.Item
{
    public class ItemCategoryTable : TableMasterObjectBase
    {
        
        public virtual Collection<ItemTable> ItemTables { get; set; }

       
    }
}
