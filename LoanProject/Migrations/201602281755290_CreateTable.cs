namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountCategoryTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountKey = c.String(),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.AccountSubCategoryTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountKey = c.String(),
                        Offset = c.String(),
                        AccountCategoryId = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountCategoryTables", t => t.AccountCategoryId)
                .Index(t => t.AccountCategoryId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.AccountTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountKey = c.String(),
                        Offset = c.String(),
                        AccountSubCategoryId = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountSubCategoryTables", t => t.AccountSubCategoryId)
                .Index(t => t.AccountSubCategoryId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.AccountTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsContra = c.Boolean(nullable: false),
                        AccountKey = c.String(),
                        AccountTypeId = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTypeTables", t => t.AccountTypeId)
                .Index(t => t.AccountTypeId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.ItemTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Barcode = c.String(),
                        PhotoPath = c.String(),
                        Description = c.String(),
                        IsManageInventory = c.Boolean(nullable: false),
                        Model = c.String(),
                        ItemCategoryId = c.Int(nullable: false),
                        ItemTypeId = c.Int(nullable: false),
                        ItemMakerId = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                        IncomeAccountId = c.Int(nullable: false),
                        ExpenseAccountId = c.Int(nullable: false),
                        CogsAccountId = c.Int(nullable: false),
                        InventoryAccountId = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTables", t => t.CogsAccountId)
                .ForeignKey("dbo.AccountTables", t => t.ExpenseAccountId)
                .ForeignKey("dbo.AccountTables", t => t.IncomeAccountId)
                .ForeignKey("dbo.AccountTables", t => t.InventoryAccountId)
                .ForeignKey("dbo.ItemCategoryTables", t => t.ItemCategoryId)
                .ForeignKey("dbo.ItemMakerTables", t => t.ItemMakerId)
                .ForeignKey("dbo.ItemTypeTables", t => t.ItemTypeId)
                .ForeignKey("dbo.UnitTables", t => t.UnitId)
                .Index(t => t.ItemCategoryId)
                .Index(t => t.ItemTypeId)
                .Index(t => t.ItemMakerId)
                .Index(t => t.UnitId)
                .Index(t => t.IncomeAccountId)
                .Index(t => t.ExpenseAccountId)
                .Index(t => t.CogsAccountId)
                .Index(t => t.InventoryAccountId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.ItemCategoryTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.ItemMakerTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.ItemTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.JournalItemTables",
                c => new
                    {
                        JournalItemId = c.Int(nullable: false, identity: true),
                        Qty = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Note = c.String(),
                        JournalUctDateTime = c.DateTime(nullable: false),
                        JournalId = c.Int(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                        ContactId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        InventoryConditionId = c.Int(nullable: false),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                        IsStockIn = c.Boolean(),
                        LocationId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.JournalItemId)
                .ForeignKey("dbo.LocationTables", t => t.LocationId)
                .ForeignKey("dbo.ContactTables", t => t.ContactId)
                .ForeignKey("dbo.CurrencyTables", t => t.CurrencyId)
                .ForeignKey("dbo.InventoryConditionTables", t => t.InventoryConditionId)
                .ForeignKey("dbo.ItemTables", t => t.ItemId)
                .ForeignKey("dbo.JournalTables", t => t.JournalId)
                .Index(t => t.JournalId)
                .Index(t => t.CurrencyId)
                .Index(t => t.ContactId)
                .Index(t => t.ItemId)
                .Index(t => t.InventoryConditionId)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.ContactTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactNumber = c.String(),
                        Email = c.String(),
                        Note = c.String(),
                        PhotoPath = c.String(),
                        ContactAddress = c.String(),
                        ContactAddressInLatin = c.String(),
                        ContactMemberTypeId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        NationalityId = c.Int(nullable: false),
                        CitizenshipId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                        CurrencyId = c.Int(),
                        DateOfBirth = c.DateTime(),
                        RegisterDate = c.DateTime(),
                        IsResigned = c.Boolean(),
                        ResignedDate = c.DateTime(),
                        Reason = c.String(),
                        PositionId = c.Int(),
                        DepartmentId = c.Int(),
                        DateOfBirth1 = c.DateTime(),
                        PlaceOfBirth = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CitizenshipTables", t => t.CitizenshipId)
                .ForeignKey("dbo.ContactMemberTypeTables", t => t.ContactMemberTypeId)
                .ForeignKey("dbo.GenderTables", t => t.GenderId)
                .ForeignKey("dbo.CurrencyTables", t => t.CurrencyId)
                .ForeignKey("dbo.DepartmentTables", t => t.DepartmentId)
                .ForeignKey("dbo.PositionTables", t => t.PositionId)
                .ForeignKey("dbo.LocationTables", t => t.LocationId)
                .ForeignKey("dbo.NationalityTables", t => t.NationalityId)
                .Index(t => t.ContactMemberTypeId)
                .Index(t => t.GenderId)
                .Index(t => t.NationalityId)
                .Index(t => t.CitizenshipId)
                .Index(t => t.LocationId)
                .Index(t => t.Code, unique: true)
                .Index(t => t.CurrencyId)
                .Index(t => t.PositionId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.CitizenshipTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.ContactMemberTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactTypeId = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactTypeTables", t => t.ContactTypeId)
                .Index(t => t.ContactTypeId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.ContactTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.GenderTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.LocationTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Description = c.String(),
                        LocationTypeId = c.Int(nullable: false),
                        ParentLocationId = c.Int(),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LocationTypeTables", t => t.LocationTypeId)
                .ForeignKey("dbo.LocationTables", t => t.ParentLocationId)
                .Index(t => t.LocationTypeId)
                .Index(t => t.ParentLocationId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.CurrencyTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencySymbol = c.String(),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.DepartmentTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactTables", t => t.CompanyId)
                .Index(t => t.CompanyId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.NationalityTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.PositionTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.UserTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactTables", t => t.EmployeeId)
                .Index(t => t.EmployeeId)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.JournalTables",
                c => new
                    {
                        JournalId = c.Int(nullable: false, identity: true),
                        JournalCode = c.String(nullable: false, maxLength: 200),
                        JournalStatusId = c.Int(nullable: false),
                        TransactionTypeId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                        InterestFrequency = c.String(),
                        InstallmentFrequency = c.String(),
                        InterestRate = c.Double(),
                        Installment = c.Double(),
                        InterestMethod = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.JournalId)
                .ForeignKey("dbo.JournalStatusTables", t => t.JournalStatusId)
                .ForeignKey("dbo.TransactionTypeTables", t => t.TransactionTypeId)
                .ForeignKey("dbo.UserTables", t => t.UserId)
                .Index(t => t.JournalCode, unique: true, name: "JournalCode_Index")
                .Index(t => t.JournalStatusId)
                .Index(t => t.TransactionTypeId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.JournalStatusTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.TransactionTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.UserGroupTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.ApplicationFunctionTables",
                c => new
                    {
                        ApplicationFunctionId = c.Int(nullable: false, identity: true),
                        ApplicationId = c.Int(nullable: false),
                        FunctionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApplicationFunctionId)
                .ForeignKey("dbo.ApplicationTables", t => t.ApplicationId)
                .ForeignKey("dbo.FunctionTables", t => t.FunctionId)
                .Index(t => t.ApplicationId)
                .Index(t => t.FunctionId);
            
            CreateTable(
                "dbo.ApplicationTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.FunctionTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.UserSessionTables",
                c => new
                    {
                        SessionId = c.Guid(nullable: false, identity: true),
                        IsLogout = c.Boolean(nullable: false),
                        LoginUtcDateTime = c.DateTime(nullable: false),
                        LogoutUtcDateTime = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SessionId)
                .ForeignKey("dbo.UserTables", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ExchangeRateTables",
                c => new
                    {
                        ExchangeRateId = c.Int(nullable: false, identity: true),
                        BuyRate = c.Double(nullable: false),
                        SaleRate = c.Double(nullable: false),
                        FromCurrencyId = c.Int(nullable: false),
                        ToCurrencyId = c.Int(nullable: false),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ExchangeRateId)
                .ForeignKey("dbo.CurrencyTables", t => t.FromCurrencyId)
                .ForeignKey("dbo.CurrencyTables", t => t.ToCurrencyId)
                .Index(t => new { t.FromCurrencyId, t.ToCurrencyId }, unique: true, name: "ExchangeRate_Index");
            
            CreateTable(
                "dbo.InventoryConditionTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.JournalItemAccountTables",
                c => new
                    {
                        JournalItemAccountId = c.Int(nullable: false, identity: true),
                        IsDebit = c.Boolean(nullable: false),
                        IsVoided = c.Boolean(nullable: false),
                        JournalItemId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        PaytoId = c.Int(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.JournalItemAccountId)
                .ForeignKey("dbo.AccountTables", t => t.AccountId)
                .ForeignKey("dbo.JournalItemTables", t => t.JournalItemId)
                .ForeignKey("dbo.JournalItemAccountTables", t => t.PaytoId)
                .Index(t => t.JournalItemId)
                .Index(t => t.AccountId)
                .Index(t => t.PaytoId);
            
            CreateTable(
                "dbo.LocationTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.UnitTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        NameInLatin = c.String(),
                        CreatedUtcDateTime = c.DateTime(nullable: false),
                        ModefiedUtcDateTime = c.DateTime(nullable: false),
                        IsPreventDelete = c.Boolean(nullable: false),
                        IsPreventEdit = c.Boolean(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.ApplicationFunctionTableUserGroupTables",
                c => new
                    {
                        ApplicationFunctionTable_ApplicationFunctionId = c.Int(nullable: false),
                        UserGroupTable_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ApplicationFunctionTable_ApplicationFunctionId, t.UserGroupTable_Id })
                .ForeignKey("dbo.ApplicationFunctionTables", t => t.ApplicationFunctionTable_ApplicationFunctionId, cascadeDelete: true)
                .ForeignKey("dbo.UserGroupTables", t => t.UserGroupTable_Id, cascadeDelete: true)
                .Index(t => t.ApplicationFunctionTable_ApplicationFunctionId)
                .Index(t => t.UserGroupTable_Id);
            
            CreateTable(
                "dbo.UserGroupTableUserTables",
                c => new
                    {
                        UserGroupTable_Id = c.Int(nullable: false),
                        UserTable_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserGroupTable_Id, t.UserTable_Id })
                .ForeignKey("dbo.UserGroupTables", t => t.UserGroupTable_Id, cascadeDelete: true)
                .ForeignKey("dbo.UserTables", t => t.UserTable_Id, cascadeDelete: true)
                .Index(t => t.UserGroupTable_Id)
                .Index(t => t.UserTable_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemTables", "UnitId", "dbo.UnitTables");
            DropForeignKey("dbo.JournalItemTables", "JournalId", "dbo.JournalTables");
            DropForeignKey("dbo.JournalItemTables", "ItemId", "dbo.ItemTables");
            DropForeignKey("dbo.JournalItemTables", "InventoryConditionId", "dbo.InventoryConditionTables");
            DropForeignKey("dbo.JournalItemTables", "CurrencyId", "dbo.CurrencyTables");
            DropForeignKey("dbo.JournalItemTables", "ContactId", "dbo.ContactTables");
            DropForeignKey("dbo.ContactTables", "NationalityId", "dbo.NationalityTables");
            DropForeignKey("dbo.ContactTables", "LocationId", "dbo.LocationTables");
            DropForeignKey("dbo.LocationTables", "ParentLocationId", "dbo.LocationTables");
            DropForeignKey("dbo.LocationTables", "LocationTypeId", "dbo.LocationTypeTables");
            DropForeignKey("dbo.JournalItemTables", "LocationId", "dbo.LocationTables");
            DropForeignKey("dbo.JournalItemAccountTables", "PaytoId", "dbo.JournalItemAccountTables");
            DropForeignKey("dbo.JournalItemAccountTables", "JournalItemId", "dbo.JournalItemTables");
            DropForeignKey("dbo.JournalItemAccountTables", "AccountId", "dbo.AccountTables");
            DropForeignKey("dbo.ExchangeRateTables", "ToCurrencyId", "dbo.CurrencyTables");
            DropForeignKey("dbo.ExchangeRateTables", "FromCurrencyId", "dbo.CurrencyTables");
            DropForeignKey("dbo.UserSessionTables", "UserId", "dbo.UserTables");
            DropForeignKey("dbo.UserGroupTableUserTables", "UserTable_Id", "dbo.UserTables");
            DropForeignKey("dbo.UserGroupTableUserTables", "UserGroupTable_Id", "dbo.UserGroupTables");
            DropForeignKey("dbo.ApplicationFunctionTableUserGroupTables", "UserGroupTable_Id", "dbo.UserGroupTables");
            DropForeignKey("dbo.ApplicationFunctionTableUserGroupTables", "ApplicationFunctionTable_ApplicationFunctionId", "dbo.ApplicationFunctionTables");
            DropForeignKey("dbo.ApplicationFunctionTables", "FunctionId", "dbo.FunctionTables");
            DropForeignKey("dbo.ApplicationFunctionTables", "ApplicationId", "dbo.ApplicationTables");
            DropForeignKey("dbo.JournalTables", "UserId", "dbo.UserTables");
            DropForeignKey("dbo.JournalTables", "TransactionTypeId", "dbo.TransactionTypeTables");
            DropForeignKey("dbo.JournalTables", "JournalStatusId", "dbo.JournalStatusTables");
            DropForeignKey("dbo.UserTables", "EmployeeId", "dbo.ContactTables");
            DropForeignKey("dbo.ContactTables", "PositionId", "dbo.PositionTables");
            DropForeignKey("dbo.ContactTables", "DepartmentId", "dbo.DepartmentTables");
            DropForeignKey("dbo.DepartmentTables", "CompanyId", "dbo.ContactTables");
            DropForeignKey("dbo.ContactTables", "CurrencyId", "dbo.CurrencyTables");
            DropForeignKey("dbo.ContactTables", "GenderId", "dbo.GenderTables");
            DropForeignKey("dbo.ContactTables", "ContactMemberTypeId", "dbo.ContactMemberTypeTables");
            DropForeignKey("dbo.ContactMemberTypeTables", "ContactTypeId", "dbo.ContactTypeTables");
            DropForeignKey("dbo.ContactTables", "CitizenshipId", "dbo.CitizenshipTables");
            DropForeignKey("dbo.ItemTables", "ItemTypeId", "dbo.ItemTypeTables");
            DropForeignKey("dbo.ItemTables", "ItemMakerId", "dbo.ItemMakerTables");
            DropForeignKey("dbo.ItemTables", "ItemCategoryId", "dbo.ItemCategoryTables");
            DropForeignKey("dbo.ItemTables", "InventoryAccountId", "dbo.AccountTables");
            DropForeignKey("dbo.ItemTables", "IncomeAccountId", "dbo.AccountTables");
            DropForeignKey("dbo.ItemTables", "ExpenseAccountId", "dbo.AccountTables");
            DropForeignKey("dbo.ItemTables", "CogsAccountId", "dbo.AccountTables");
            DropForeignKey("dbo.AccountTables", "AccountTypeId", "dbo.AccountTypeTables");
            DropForeignKey("dbo.AccountTypeTables", "AccountSubCategoryId", "dbo.AccountSubCategoryTables");
            DropForeignKey("dbo.AccountSubCategoryTables", "AccountCategoryId", "dbo.AccountCategoryTables");
            DropIndex("dbo.UserGroupTableUserTables", new[] { "UserTable_Id" });
            DropIndex("dbo.UserGroupTableUserTables", new[] { "UserGroupTable_Id" });
            DropIndex("dbo.ApplicationFunctionTableUserGroupTables", new[] { "UserGroupTable_Id" });
            DropIndex("dbo.ApplicationFunctionTableUserGroupTables", new[] { "ApplicationFunctionTable_ApplicationFunctionId" });
            DropIndex("dbo.UnitTables", new[] { "Code" });
            DropIndex("dbo.LocationTypeTables", new[] { "Code" });
            DropIndex("dbo.JournalItemAccountTables", new[] { "PaytoId" });
            DropIndex("dbo.JournalItemAccountTables", new[] { "AccountId" });
            DropIndex("dbo.JournalItemAccountTables", new[] { "JournalItemId" });
            DropIndex("dbo.InventoryConditionTables", new[] { "Code" });
            DropIndex("dbo.ExchangeRateTables", "ExchangeRate_Index");
            DropIndex("dbo.UserSessionTables", new[] { "UserId" });
            DropIndex("dbo.FunctionTables", new[] { "Code" });
            DropIndex("dbo.ApplicationTables", new[] { "Code" });
            DropIndex("dbo.ApplicationFunctionTables", new[] { "FunctionId" });
            DropIndex("dbo.ApplicationFunctionTables", new[] { "ApplicationId" });
            DropIndex("dbo.UserGroupTables", new[] { "Code" });
            DropIndex("dbo.TransactionTypeTables", new[] { "Code" });
            DropIndex("dbo.JournalStatusTables", new[] { "Code" });
            DropIndex("dbo.JournalTables", new[] { "UserId" });
            DropIndex("dbo.JournalTables", new[] { "TransactionTypeId" });
            DropIndex("dbo.JournalTables", new[] { "JournalStatusId" });
            DropIndex("dbo.JournalTables", "JournalCode_Index");
            DropIndex("dbo.UserTables", new[] { "Code" });
            DropIndex("dbo.UserTables", new[] { "EmployeeId" });
            DropIndex("dbo.PositionTables", new[] { "Code" });
            DropIndex("dbo.NationalityTables", new[] { "Code" });
            DropIndex("dbo.DepartmentTables", new[] { "Code" });
            DropIndex("dbo.DepartmentTables", new[] { "CompanyId" });
            DropIndex("dbo.CurrencyTables", new[] { "Code" });
            DropIndex("dbo.LocationTables", new[] { "Code" });
            DropIndex("dbo.LocationTables", new[] { "ParentLocationId" });
            DropIndex("dbo.LocationTables", new[] { "LocationTypeId" });
            DropIndex("dbo.GenderTables", new[] { "Code" });
            DropIndex("dbo.ContactTypeTables", new[] { "Code" });
            DropIndex("dbo.ContactMemberTypeTables", new[] { "Code" });
            DropIndex("dbo.ContactMemberTypeTables", new[] { "ContactTypeId" });
            DropIndex("dbo.CitizenshipTables", new[] { "Code" });
            DropIndex("dbo.ContactTables", new[] { "DepartmentId" });
            DropIndex("dbo.ContactTables", new[] { "PositionId" });
            DropIndex("dbo.ContactTables", new[] { "CurrencyId" });
            DropIndex("dbo.ContactTables", new[] { "Code" });
            DropIndex("dbo.ContactTables", new[] { "LocationId" });
            DropIndex("dbo.ContactTables", new[] { "CitizenshipId" });
            DropIndex("dbo.ContactTables", new[] { "NationalityId" });
            DropIndex("dbo.ContactTables", new[] { "GenderId" });
            DropIndex("dbo.ContactTables", new[] { "ContactMemberTypeId" });
            DropIndex("dbo.JournalItemTables", new[] { "LocationId" });
            DropIndex("dbo.JournalItemTables", new[] { "InventoryConditionId" });
            DropIndex("dbo.JournalItemTables", new[] { "ItemId" });
            DropIndex("dbo.JournalItemTables", new[] { "ContactId" });
            DropIndex("dbo.JournalItemTables", new[] { "CurrencyId" });
            DropIndex("dbo.JournalItemTables", new[] { "JournalId" });
            DropIndex("dbo.ItemTypeTables", new[] { "Code" });
            DropIndex("dbo.ItemMakerTables", new[] { "Code" });
            DropIndex("dbo.ItemCategoryTables", new[] { "Code" });
            DropIndex("dbo.ItemTables", new[] { "Code" });
            DropIndex("dbo.ItemTables", new[] { "InventoryAccountId" });
            DropIndex("dbo.ItemTables", new[] { "CogsAccountId" });
            DropIndex("dbo.ItemTables", new[] { "ExpenseAccountId" });
            DropIndex("dbo.ItemTables", new[] { "IncomeAccountId" });
            DropIndex("dbo.ItemTables", new[] { "UnitId" });
            DropIndex("dbo.ItemTables", new[] { "ItemMakerId" });
            DropIndex("dbo.ItemTables", new[] { "ItemTypeId" });
            DropIndex("dbo.ItemTables", new[] { "ItemCategoryId" });
            DropIndex("dbo.AccountTables", new[] { "Code" });
            DropIndex("dbo.AccountTables", new[] { "AccountTypeId" });
            DropIndex("dbo.AccountTypeTables", new[] { "Code" });
            DropIndex("dbo.AccountTypeTables", new[] { "AccountSubCategoryId" });
            DropIndex("dbo.AccountSubCategoryTables", new[] { "Code" });
            DropIndex("dbo.AccountSubCategoryTables", new[] { "AccountCategoryId" });
            DropIndex("dbo.AccountCategoryTables", new[] { "Code" });
            DropTable("dbo.UserGroupTableUserTables");
            DropTable("dbo.ApplicationFunctionTableUserGroupTables");
            DropTable("dbo.UnitTables");
            DropTable("dbo.LocationTypeTables");
            DropTable("dbo.JournalItemAccountTables");
            DropTable("dbo.InventoryConditionTables");
            DropTable("dbo.ExchangeRateTables");
            DropTable("dbo.UserSessionTables");
            DropTable("dbo.FunctionTables");
            DropTable("dbo.ApplicationTables");
            DropTable("dbo.ApplicationFunctionTables");
            DropTable("dbo.UserGroupTables");
            DropTable("dbo.TransactionTypeTables");
            DropTable("dbo.JournalStatusTables");
            DropTable("dbo.JournalTables");
            DropTable("dbo.UserTables");
            DropTable("dbo.PositionTables");
            DropTable("dbo.NationalityTables");
            DropTable("dbo.DepartmentTables");
            DropTable("dbo.CurrencyTables");
            DropTable("dbo.LocationTables");
            DropTable("dbo.GenderTables");
            DropTable("dbo.ContactTypeTables");
            DropTable("dbo.ContactMemberTypeTables");
            DropTable("dbo.CitizenshipTables");
            DropTable("dbo.ContactTables");
            DropTable("dbo.JournalItemTables");
            DropTable("dbo.ItemTypeTables");
            DropTable("dbo.ItemMakerTables");
            DropTable("dbo.ItemCategoryTables");
            DropTable("dbo.ItemTables");
            DropTable("dbo.AccountTables");
            DropTable("dbo.AccountTypeTables");
            DropTable("dbo.AccountSubCategoryTables");
            DropTable("dbo.AccountCategoryTables");
        }
    }
}
