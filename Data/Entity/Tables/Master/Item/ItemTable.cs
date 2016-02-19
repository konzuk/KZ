using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Accounting.Account;
using Main.Tables.Accounting.Journal;

namespace Main.Tables.Master.Item
{
    public class ItemTable : TableMasterObjectBase
    {
        //Field
        public string Barcode { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public bool IsManageInventory { get; set; }
        public string Model { get; set; }

        //FK
        public int ItemCategoryId { get; set; }
        [ForeignKey("ItemCategoryId"), InverseProperty("ItemTables")]
        public virtual ItemCategoryTable ItemCategoryTable { get; set; }

        public int ItemTypeId { get; set; }
        [ForeignKey("ItemTypeId"), InverseProperty("ItemTables")]
        public virtual ItemTypeTable ItemTypeTable { get; set; }

        public int ItemMakerId { get; set; }
        [ForeignKey("ItemMakerId"), InverseProperty("ItemTables")]
        public virtual ItemTypeTable ItemMakerTable { get; set; }

        public int UnitId { get; set; }
        [ForeignKey("UnitId"), InverseProperty("ItemTables")]
        public virtual UnitTable UnitTable { get; set; }

        public int? IncomeAccountId { get; set; }
        [ForeignKey("IncomeAccountId"), InverseProperty("IncomeItemTables")]
        public virtual AccountTable IncomeAccountTable { get; set; }

        public int? ExpenseAccountId { get; set; }
        [ForeignKey("ExpenseAccountId"), InverseProperty("ExpenseItemTables")]
        public virtual AccountTable ExpenseAccountTable { get; set; }

        public int? CogsAccountId { get; set; }
        [ForeignKey("CogsAccountId"), InverseProperty("CogsItemTables")]
        public virtual AccountTable CogsAccountTable { get; set; }

        public int? InventoryAccountId { get; set; }
        [ForeignKey("InventoryAccountId"), InverseProperty("InventoryItemTables")]
        public virtual AccountTable InventoryAccountTable { get; set; }


        //C-FK
        public virtual Collection<JournalItemTable> JournalItemTables { get; set; }

    }
}
