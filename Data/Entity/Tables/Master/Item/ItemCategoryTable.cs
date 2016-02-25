using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Tables.Master.Item
{
    public class ItemCategoryTable : TableMasterObjectBase
    {
        //Field

        //FK

        //C-FK
        public virtual ICollection<ItemTable> ItemTables { get; set; }

       
    }
}
