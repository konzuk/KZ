using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class ApplicationCategoryTable : TableMasterObjectBase
    {
       

        public virtual Collection<ApplicationCategoryItemTable> ApplicationCategoryItemTables { get; set; }

       
    }
}
