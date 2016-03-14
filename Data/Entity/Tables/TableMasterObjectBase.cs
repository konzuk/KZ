using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Tables
{
    public abstract class TableMasterObjectBase : TableBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Index(IsUnique = true, Order = 1), Required, MaxLength(200)]
        public string Code { get; set; }
        public string Name { get; set; }
        public string NameInLatin { get; set; }

    }
}
