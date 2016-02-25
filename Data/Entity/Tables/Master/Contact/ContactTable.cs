using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Accounting.Journal;
using Main.Tables.Master.Location;

namespace Main.Tables.Master.Contact
{
    public class ContactTable : TableMasterObjectBase
    {
        


        //Field
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string PhotoPath { get; set; }
        public string ContactAddress { get; set; }
        public string ContactAddressInLatin { get; set; }

        //FK
        public int ContactMemberTypeId { get; set; }
        [ForeignKey("ContactMemberTypeId"), InverseProperty("ContactTables")]
        public virtual ContactMemberTypeTable ContactMemberTypeTable { get; set; }

        public int GenderId { get; set; }
        [ForeignKey("GenderId"), InverseProperty("ContactTables")]
        public virtual GenderTable GenderTable { get; set; }

        public int NationalityId { get; set; }
        [ForeignKey("NationalityId"), InverseProperty("ContactTables")]
        public virtual NationalityTable NationalityTable { get; set; }

        public int CitizenshipId { get; set; }
        [ForeignKey("CitizenshipId"), InverseProperty("ContactTables")]
        public virtual CitizenshipTable CitizenshipTable { get; set; }


        public int LocationId { get; set; }
        [ForeignKey("LocationId"), InverseProperty("ContactTables")]
        public virtual LocationTable LocationTable { get; set; }
        

        //C-FK
        public virtual ICollection<JournalItemTable> JournalItemTables { get; set; }
 
   

     
    }
}
