using System.Collections.Generic;

namespace Entity.Tables.Accounting.Account
{
    public class AccountCategoryTable : TableMasterObjectBase
    {

        //Field

        public string AccountKey { get; set; }

        //FK


        //C-FK
        public virtual ICollection<AccountSubCategoryTable> AccountSubCategoryTables { get; set; }
        
    }
    
}
