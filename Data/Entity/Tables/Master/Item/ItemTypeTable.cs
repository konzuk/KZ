﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Tables.Master.Item
{
    public class ItemTypeTable
    {
      

        public virtual Collection<ItemTable> ItemTables { get; set; }

       
    }
}