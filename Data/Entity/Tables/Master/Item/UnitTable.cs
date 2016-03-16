using System.Collections.Generic;

namespace Entity.Tables.Master.Item
{
    public  class UnitTable: TableMasterObjectBase
    {

        //Field

        //FK

        //C-FK
        public virtual ICollection<ItemTable> ItemTables { get; set; }

     

    }
}
