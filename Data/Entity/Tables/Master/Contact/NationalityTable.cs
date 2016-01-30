using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class NationalityTable : TableMasterObjectBase
    {
        
        public virtual Collection<ContactTable> ContactTables { get; set; }

       
    }
}
