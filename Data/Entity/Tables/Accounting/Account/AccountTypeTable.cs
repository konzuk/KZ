using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Tables.Accounting.Account
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
