using System.Collections.Generic;

namespace Entity.Tables.Master.Item
{
    public class ItemCategoryTable : TableMasterObjectBase
    {
        //Field

        //FK

        //C-FK
        public virtual ICollection<ItemTable> ItemTables { get; set; }

       
    }
}
