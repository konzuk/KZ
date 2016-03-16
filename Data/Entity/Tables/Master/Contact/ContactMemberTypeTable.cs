using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Tables.Master.Contact
{
    public class ContactMemberTypeTable : TableMasterObjectBase
    {
        //Field

        //FK
        public int ContactTypeId { get; set; }

        [ForeignKey("ContactTypeId"), InverseProperty("ContactMemberTypeTables")]
        public virtual ContactTypeTable ContactTypeTable { get; set; }

        //C-FK


        public virtual ICollection<ContactTable> ContactTables { get; set; }

        
    }
}
