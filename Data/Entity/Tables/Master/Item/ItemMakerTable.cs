using System.Collections.Generic;

namespace Entity.Tables.Master.Item
{
    public class ItemMakerTable:TableMasterObjectBase
    {

        //Field

        //FK

        //C-FK
        public virtual ICollection<ItemTable> ItemTables { get; set; }

       
    }
}
