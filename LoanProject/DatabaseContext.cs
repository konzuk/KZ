using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.IO;
using System.Linq;
using DataContext.Migrations;
using Framework.Interfaces.Helper;
using Main.Tables.Accounting.Account;
using Main.Tables.Accounting.Journal;
using Main.Tables.Master.Common;
using Main.Tables.Master.Contact;
using Main.Tables.Master.Contact.Company;
using Main.Tables.Master.Contact.Customer;
using Main.Tables.Master.Contact.Employee;
using Main.Tables.Master.Contact.Store;
using Main.Tables.Master.Contact.Supplier;
using Main.Tables.Master.Location;
using Main.Tables.Master.User;

namespace LoanProject
{
    public class DatabaseContext : DbContext , IObjectContext
    {
        public static string GetSqlConnection()
        {

            string drive =  Path.GetPathRoot(Environment.SystemDirectory);
            
            string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "
                                        + drive +
                                      @"Data\DBContext.mdf; Integrated Security = True; Connect Timeout = 30";

            return connectionstring;
        }
        public DatabaseContext()
            :base(GetSqlConnection())
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext,Configuration>());
        }

       
        //Account
        public virtual DbSet<AccountCategoryTable> AccountCategoryTables { get; set; }
        public virtual DbSet<AccountSubCategoryTable> AccountSubCategoryTables { get; set; }
        public virtual DbSet<AccountTypeTable> AccountTypeTables { get; set; }
        public virtual DbSet<AccountTable> AccountTables { get; set; }


        public virtual DbSet<JournalItemAccountTable> JournalItemAccountTables { get; set; }
        public virtual DbSet<JournalItemMovementMovementTable> JournalItemMovementMovementTables { get; set; }
        public virtual DbSet<JournalItemTable> JournalItemTables { get; set; }
        public virtual DbSet<JournalStatusTable> JournalStatusTables { get; set; }
        public virtual DbSet<JournalTable> JournalTables { get; set; }
        public virtual DbSet<LoanJournalTable> LoanJournalTables { get; set; }
        public virtual DbSet<TransactionTypeTable> TransactionTypeTables { get; set; }


        //Common
        public virtual DbSet<CurrencyTable> CurrencyTables { get; set; }
        public virtual DbSet<ExchangeRateTable> ExchangeRateTables { get; set; }


        //Business Unit Tables
        public virtual DbSet<CompanyTable> CompanyTables { get; set; }
        public virtual DbSet<CustomerTable> CustomerTables { get; set; }
        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; }
        public virtual DbSet<PositionTable> PositionTables { get; set; }
        public virtual DbSet<StoreTable> StoreTables { get; set; }
        public virtual DbSet<SupplierTable> SupplierTables { get; set; }


        //Contact Tables
        public virtual DbSet<ContactMemberTypeTable> ContactMemberTypeTables { get; set; }
        public virtual DbSet<ContactTable> ContactTables { get; set; }
        public virtual DbSet<ContactTypeTable> ContactTypeTables { get; set; }
        public virtual DbSet<DepartmentTable> DepartmentTables { get; set; }
        public virtual DbSet<GenderTable> GenderTables { get; set; }
        public virtual DbSet<NationalityTable> NationalityTables { get; set; }
        public virtual DbSet<CitizenshipTable> C { get; set; }


        //Location tables
        public virtual DbSet<LocationTypeTable> LocationTypeTables { get; set; }
        public virtual DbSet<LocationTable> LocationTables { get; set; }

        //User Tables
        public virtual DbSet<ApplicationFunctionTable> ApplicationFunctionTables { get; set; }
        public virtual DbSet<ApplicationTable> ApplicationTables { get; set; }
        public virtual DbSet<FunctionTable> FunctionTables { get; set; }
        public virtual DbSet<UserGroupTable> UserGroupTables { get; set; }
        public virtual DbSet<UserSessionTable> UserSessionTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        
        
        //Employee Tables
       

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
            

            //tableBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            tableBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(tableBuilder);
        }

        public bool EnableLazyLoading
        {
            get
            {
                return Configuration.LazyLoadingEnabled;
            }
            set
            {
                Configuration.LazyLoadingEnabled = value;
            }
        }
        public DateTime GetServerDate => Database.SqlQuery<DateTime>("select getdate()").LastOrDefault();

        public IDbSet<T> CreateObjectSet<T>() where T : class
        {
           return Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
