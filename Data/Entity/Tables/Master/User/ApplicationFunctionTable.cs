using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class ApplicationFunctionTable 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationFunctionId { get; set; }

        public int ApplicationId { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual ApplicationTable ApplicationTable { get; set; }
        public int FunctionId { get; set; }
        [ForeignKey("FunctionId")]
        public virtual FunctionTable FunctionTable { get; set; }

        public virtual Collection<RoleTable> RoleTables { get; set; }

        
    }
}
