using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class ContactTypeTable  : TableMasterObjectBase
    {
       
        public virtual Collection<ContactMemberTypeTable> ContactMemberTypeTables { get; set; }

       
    }
}
