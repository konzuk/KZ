using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Tables.Accounting.Account
{
    public class AccountTypeTable : TableMasterObjectBase
    {
        //Field

        public string AccountKey { get; set; }
        public string Offset { get; set; }

        //FK
        public int AccountSubCategoryId { get; set; }
        [ForeignKey("AccountSubCategoryId"), InverseProperty("AccountTypeTables")]
        public virtual AccountSubCategoryTable AccountSubCategoryTable { get; set; }

        //C-FK
        public virtual ICollection<AccountTable> AccountTables { get; set; }
    
    }
}
