using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.Journal;
using MainEntity.Tables.Location;
using MainEntity.Tables.User;

namespace MainEntity.Tables.Contact
{
    public class ContactTable : TableMasterObjectBase
    {
        
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string PhotoPath { get; set; }


        public int ContactMemberTypeId { get; set; }

        [ForeignKey("ContactMemberTypeId")]
        public virtual ContactMemberTypeTable ContactMemberTypeTable { get; set; }

        public int? GenderId { get; set; }
        [ForeignKey("GenderId")]
        public virtual GenderTable GenderTable { get; set; }

        public int? NationalityId { get; set; }
        [ForeignKey("NationalityId")]
        public virtual NationalityTable NationalityTable { get; set; }

        public string ContactAddress { get; set; }
        public string ContactAddressInLatin { get; set; }

        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual LocationTable LocationTable { get; set; }
        
        public virtual Collection<JournalTable> JournalTables { get; set; }
 
   

     
    }
}
