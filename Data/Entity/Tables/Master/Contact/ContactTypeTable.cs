using System.Collections.Generic;

namespace Entity.Tables.Master.Contact
{
    public class ContactTypeTable  : TableMasterObjectBase
    {
        //Field

        //FK

        //C-FK
        public virtual ICollection<ContactMemberTypeTable> ContactMemberTypeTables { get; set; }

       
    }
}
