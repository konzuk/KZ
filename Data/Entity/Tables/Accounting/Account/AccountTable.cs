﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Main.Tables.Accounting.Journal;
using Main.Tables.Master.Item;

namespace Main.Tables.Accounting.Account
{
    public class AccountTable : TableMasterObjectBase
    {
        //Field
        public bool IsContra { get; set; }
        public string AccountKey { get; set; }

    //FK
        public int AccountTypeId { get; set; }
        [ForeignKey("AccountTypeId"), InverseProperty("AccountTables")]
        public virtual AccountTypeTable AccountTypeTable { get; set; }

        //C-FK

        public virtual ICollection<JournalItemAccountTable> JournalItemAccountTables { get; set; }

        public virtual ICollection<ItemTable> IncomeItemTables { get; set; }
        public virtual ICollection<ItemTable> ExpenseItemTables { get; set; }
        public virtual ICollection<ItemTable> CogsItemTables { get; set; }
        public virtual ICollection<ItemTable> InventoryItemTables { get; set; }


    }
}
