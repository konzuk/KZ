using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Tables.Master.User
{
    public class ApplicationFunctionTable 
    {

        //Field
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationFunctionId { get; set; }


        //FK
        public int ApplicationId { get; set; }
        [ForeignKey("ApplicationId"), InverseProperty("ApplicationFunctionTables")]
        public virtual ApplicationTable ApplicationTable { get; set; }
        public int FunctionId { get; set; }
        [ForeignKey("FunctionId"), InverseProperty("ApplicationFunctionTables")]
        public virtual FunctionTable FunctionTable { get; set; }


        //C-FK
        public virtual ICollection<UserGroupTable> UserGroupTables { get; set; }

        
    }
}
