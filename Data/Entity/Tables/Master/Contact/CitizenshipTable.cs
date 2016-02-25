using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Tables.Master.Contact
{
    public class CitizenshipTable : TableMasterObjectBase
    {

        //Field

        //FK

        //C-FK
        public virtual ICollection<ContactTable> ContactTables { get; set; }

       
    }
}
