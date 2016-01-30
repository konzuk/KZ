using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class ContactMemberTypeTable : TableMasterObjectBase
    {
        
        public int ContactTypeId { get; set; }

        [ForeignKey("ContactTypeId")]
        public virtual ContactTypeTable ContactTypeTable { get; set; }

        public virtual Collection<ContactTable> ContactTables { get; set; }

        
    }
}
