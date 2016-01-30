using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using MainEntity.Tables.User;

namespace MainEntity.Tables
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
