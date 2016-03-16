using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Tables.Accounting.Account
{
    public class AccountSubCategoryTable : TableMasterObjectBase
    {

        //Field

        public string AccountKey { get; set; }
        public string Offset { get; set; }

        //FK
        public int AccountCategoryId { get; set; }
        [ForeignKey("AccountCategoryId"), InverseProperty("AccountSubCategoryTables")]
        public AccountCategoryTable AccountCategoryTable { get; set; }

        //C-FK
        public virtual ICollection<AccountTypeTable> AccountTypeTables { get; set; }
        
    }
}
