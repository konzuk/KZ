using System.Collections.Generic;

namespace Entity.Tables.Master.Contact
{
    public class NationalityTable : TableMasterObjectBase
    {

        //Field

        //FK

        //C-FK
        public virtual ICollection<ContactTable> ContactTables { get; set; }

       
    }
}
