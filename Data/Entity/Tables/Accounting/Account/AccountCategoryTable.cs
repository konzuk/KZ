using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Tables.Accounting.Account
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
