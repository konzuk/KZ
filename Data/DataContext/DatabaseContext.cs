using System.Data.Entity;
using System.Data.Entity.Migrations;
using MainEntity.Tables.BusinessUnit;
using MainEntity.Tables.Common;
using MainEntity.Tables.Contact;
using MainEntity.Tables.Employee;
using MainEntity.Tables.Journal;
using MainEntity.Tables.Location;
using MainEntity.Tables.User;

namespace MainDataContext
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
            //:base("name=Database1Entities")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DatabaseContext>());
            //this.Configuration.ProxyCreationEnabled = false;
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.AutoDetectChangesEnabled = false;
        }

        //Common
        public virtual DbSet<CurrencyTable> CurrencyTables { get; set; }
        public virtual DbSet<ExchangeRateTable> ExchangeRateTables { get; set; }

        //Account

        //User Tables
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<ApplicationTable> ApplicationTables { get; set; }
        public virtual DbSet<FunctionTable> FunctionTables { get; set; }
        public virtual DbSet<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }
        public virtual DbSet<UserGroupTable> UserGroupTables { get; set; }
        public virtual DbSet<RoleTable> RoleTables { get; set; }
        public virtual DbSet<UserSessionTable> UserSessionTables { get; set; }

        //Contact Tables
        public virtual DbSet<ContactTypeTable> ContactTypeTables { get; set; }
        public virtual DbSet<ContactMemberTypeTable> ContactMemberTypeTables { get; set; }
        public virtual DbSet<ContactTable> ContactTables { get; set; }
        public virtual DbSet<NationalityTable> NationalityTables { get; set; }
        public virtual DbSet<GenderTable> GenderTables { get; set; }

        //Business Unit Tables
        public virtual DbSet<CompanyTable> CompanyTables { get; set; }
        public virtual DbSet<CustomerTable> CustomerTables { get; set; }
        public virtual DbSet<SupplierTable> SupplierTables { get; set; }
        public virtual DbSet<StoreTable> StoreTables { get; set; }


        //Location tables

        public virtual DbSet<LocationTypeTable> LocationTypeTables { get; set; }
        public virtual DbSet<WarehouseTable> WarehouseTables { get; set; }
        public virtual DbSet<LocationTable> LocationTables { get; set; }


        //Journal Tables
        public virtual DbSet<JournalTable> JournalTables { get; set; }

        public virtual DbSet<JournalStatusTable> JournalStatusTables { get; set; }

        public virtual DbSet<TransactionTypeTable> TransactionTypeTables { get; set; }

        //Employee Tables
        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; }
        public virtual DbSet<DepartmentTable> DepartmentTables { get; set; }
        public virtual DbSet<PositionTable> PositionTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder tableBuilder)
        {
            //Make table support unicode font
            tableBuilder.Properties<string>().Configure(t => t.IsUnicode(true));

            #region "Common Relationship Use"
            //Recursive relationship
            //tableBuilder.Entity<ItemCategoryTable>().HasMany(m => m.ItemCategoryTables).WithMany();

            //One-to-Many relationship
            //tableBuilder.Entity<SaleItem>()
            //    .HasRequired(p => p.Product)
            //    .WithMany(p => p.SaleItemProducts)
            //    .HasForeignKey(p => p.ProductId).WillCascadeOnDelete(false);

            //Zero/One-to-Many relationship
            //tableBuilder.Entity<SaleItem>()
            //    .HasOptional(p => p.Service)
            //    .WithMany(p => p.SaleItemServices)
            //    .HasForeignKey(p => p.ServiceId).WillCascadeOnDelete(false);

            //Set Key
            //tableBuilder.Entity<Product>()
            //.HasKey(t => t.ProductId);

            //Inheritence
            //tableBuilder.Entity<Product>()
            //    .HasRequired(t => t.Item)
            //    .WithOptional(t => t.Product);

           
            #endregion

            base.OnModelCreating(tableBuilder);
        }
    }

    public class KZMigrationConfiguration:DbMigrationsConfiguration<DatabaseContext>
    {
        public KZMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
           
        }

        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}
