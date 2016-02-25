using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Main.Tables.Master.Contact
{
    public class ContactTypeTable  : TableMasterObjectBase
    {
        //Field

        //FK

        //C-FK
        public virtual ICollection<ContactMemberTypeTable> ContactMemberTypeTables { get; set; }

       
    }
}
