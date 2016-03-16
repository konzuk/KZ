using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Entity.Tables.Accounting.Account;
using Entity.Tables.Master.Common;
using Entity.Tables.Master.Contact;
using Entity.Tables.Master.Contact.Employee;
using Entity.Tables.Master.Item;
using Entity.Tables.Master.Location;
using Entity.Tables.Master.User;
using Repository;

namespace LoanProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DatabaseContext context)
        {
            var repo = new Repository<ApplicationTable>(context);

            if (repo.FindNoTracking(s => true).Any())
            {
                return;
            }
            InsertApplicationFunctions(context);
            InsertMasterData(context);
        }


        private void InsertMasterData(DatabaseContext dbContext)
        {

            var maleGender = new GenderTable()
            {
                Code = "M",
                Name = "ប្រុស",
                NameInLatin = "Male",
            };


            var femaleGender = new GenderTable()
            {
                Code = "F",
                Name = "ស្រី",
                NameInLatin = "Female",
            };

            var usdCurrency = new CurrencyTable()
            {
                Code = "USD",
                CurrencySymbol = "$",
            };
            var khrCurrency = new CurrencyTable()
            {
                Code = "KHR",
                CurrencySymbol = "៛",

            };
            
            var customerMember = new ContactMemberTypeTable()
            {
                Code = "Customer",
                Name = "អតិថិជន",
                NameInLatin = "Customer",
                ContactTypeTable = new ContactTypeTable()
                {
                    Code = "Customer",
                    Name = "អតិថិជន",
                    NameInLatin = "Customer",
                }
            };

            var companyMember = new ContactMemberTypeTable()
            {
                Code = "Company",
                Name = "ក្រុមហ៊ុន",
                NameInLatin = "Company",
                ContactTypeTable = new ContactTypeTable()
                {
                    Code = "Company",
                    Name = "ក្រុមហ៊ុន",
                    NameInLatin = "Company",
                }
            };

            var storeMember = new ContactMemberTypeTable()
            {
                Code = "Store",
                Name = "ហាងទំនិញ",
                NameInLatin = "Store",
                ContactTypeTable = new ContactTypeTable()
                {
                    Code = "Store",
                    Name = "ហាងទំនិញ",
                    NameInLatin = "Store",
                }
            };

            var supplierMember = new ContactMemberTypeTable()
            {
                Code = "Supplier",
                Name = "អ្នកផ្គត់ផ្គង់",
                NameInLatin = "Supplier",
                ContactTypeTable = new ContactTypeTable()
                {
                    Code = "Supplier",
                    Name = "អ្នកផ្គត់ផ្គង់",
                    NameInLatin = "Supplier",
                }
            };



            var admin = new UserTable()
            {
                Code = "Admin",
                Name = "Admin",
                Password = "Admin",
                EmployeeTable = new EmployeeTable()
                {
                    Code = "Admin",
                    Name = "Admin",
                    DateOfBirth = DateTime.Today,
                    RegisterDate = DateTime.Today,
                    ResignedDate = DateTime.MaxValue,
                    PositionTable = new PositionTable()
                    {
                        Code = "Admin"
                    },
                    ContactMemberTypeTable = new ContactMemberTypeTable()
                    {
                        Code = "Employee",
                        Name = "បុគ្គលិក",
                        NameInLatin = "Employee",
                        ContactTypeTable = new ContactTypeTable()
                        {
                            Code = "Employee",
                            Name = "បុគ្គលិក",
                            NameInLatin = "Employee",
                        }
                    },
                    GenderTable = maleGender,
                    NationalityTable = new NationalityTable()
                    {
                        Code = "Khmer",
                        Name = "ខ្មែរ",
                        NameInLatin = "Cambodia",
                    },
                    CitizenshipTable = new CitizenshipTable()
                    {
                        Code = "Khmer",
                        Name = "ខ្មែរ",
                        NameInLatin = "Cambodia",
                    },
                    LocationTable = new LocationTable()
                    {
                        Code = "None",
                        LocationTypeTable = new LocationTypeTable()
                        {
                            Code = "None"
                        },
                    },


                },
            };

            var noneInventoryCondition = new InventoryConditionTable()
            {
                Code = "None"
            };


            var noneItemCategory = new ItemCategoryTable()
            {
                Code = "None"
            };

            var noneItemMaker = new ItemMakerTable()
            {
                Code = "None"
            };

            var noneItemType = new ItemTypeTable()
            {
                Code = "None"
            };

            var noneUnit = new UnitTable()
            {
                Code = "None"
            };

           
            var mUnit = new UnitTable()
            {
                Code = "M"
            };

            var kgUnit = new UnitTable()
            {
                Code = "KG"
            };

            var unitUnit = new UnitTable()
            {
                Code = "Unit"
            };


            var assetsAct = new AccountCategoryTable()
            {
                Code = "Assets",
                AccountKey = "1",
            };

            var liabilitiesAct = new AccountCategoryTable()
            {
                Code = "Liabilities",
                AccountKey = "2",
            };

            var equityAct = new AccountCategoryTable()
            {
                Code = "Equity",
                AccountKey = "3",
            };

            var revenueAct = new AccountCategoryTable()
            {
                Code = "Revenue",
                AccountKey = "4",
            };

            var cogsact = new AccountCategoryTable()
            {
                Code = "COGS",
                AccountKey = "5",
            };

            var expenseAct = new AccountCategoryTable()
            {
                Code = "Expense",
                AccountKey = "6",
            };


            var currenctAssetAsct = new AccountSubCategoryTable()
            {
                Code = "CurrentAsset",
                Name = "Current Asset",
                AccountCategoryTable = assetsAct,
                AccountKey = "1",
            };
            var fixedAssetAsct = new AccountSubCategoryTable()
            {
                Code = "FixedAsset",
                Name = "Fixed Asset",
                AccountCategoryTable = assetsAct,
                AccountKey = "3",
            };
            var currentLiabilityAsct = new AccountSubCategoryTable()
            {
                Code = "CurrentLiability",
                Name = "Current Liability",
                AccountCategoryTable = liabilitiesAct,
                AccountKey = "1",
            };
            var longTermLiablilityAsct = new AccountSubCategoryTable()
            {
                Code = "LongTermLiablility",
                Name = "Long-Term Liablility",
                AccountCategoryTable = liabilitiesAct,
                AccountKey = "3",
            };
            var equity = new AccountSubCategoryTable()
            {
                Code = "Equity",
                Name = "Equity",
                AccountCategoryTable = equityAct,
                AccountKey = "1",
            };
            var revenue = new AccountSubCategoryTable()
            {
                Code = "CurrentAsset",
                Name = "Current Asset",
                AccountCategoryTable = revenueAct,
                AccountKey = "1",
            };
            var cogs = new AccountSubCategoryTable()
            {
                Code = "COGS",
                Name = "Cost of Good Sold",
                AccountCategoryTable = cogsact,
                AccountKey = "1",
            };
            var expense = new AccountSubCategoryTable()
            {
                Code = "Expense",
                Name = "Expense",
                AccountCategoryTable = expenseAct,
                AccountKey = "1",
            };


            var cashAt = new AccountTypeTable()
            {
                Code = "Cash",
                Name = "Cash",
                AccountSubCategoryTable = currenctAssetAsct,
                AccountKey = "1",
            };

            var bankAt = new AccountTypeTable()
            {
                Code = "Bank",
                Name = "Bank",
                AccountSubCategoryTable = currenctAssetAsct,
                AccountKey = "2",
            };


            var arat = new AccountTypeTable()
            {
                Code = "AR",
                Name = "AR",
                AccountSubCategoryTable = currenctAssetAsct,
                AccountKey = "3",
            };

            var otherReceivableAt = new AccountTypeTable()
            {
                Code = "OtherReceivable",
                Name = "Other Receivable",
                AccountSubCategoryTable = currenctAssetAsct,
                AccountKey = "4",
            };

            var otherRevenueAt = new AccountTypeTable()
            {
                Code = "OtherRevenue",
                Name = "Other Revenue",
                AccountSubCategoryTable = currenctAssetAsct,
                AccountKey = "2",
            };

            var cash = new AccountTable()
            {
                Code = "Cash",
                Name = "Cash",
                AccountTypeTable = cashAt,
                AccountKey = "001",
            };


            var ar = new AccountTable()
            {
                Code = "AR",
                Name = "AR",
                AccountTypeTable = arat,
                AccountKey = "001",
            };


            var ir = new AccountTable()
            {
                Code = "InterestReceivable",
                Name = "Interest Receivable",
                AccountTypeTable = otherReceivableAt,
                AccountKey = "002",
            };

            var interestRevenue = new AccountTable()
            {
                Code = "InterestRevenue",
                Name = "Interest Revenue",
                AccountTypeTable = otherRevenueAt,
                AccountKey = "002",
            };

            new Repository<CurrencyTable>(dbContext).Add(usdCurrency);
            new Repository<CurrencyTable>(dbContext).Add(khrCurrency);

            new Repository<UserTable>(dbContext).Add(admin);
            new Repository<GenderTable>(dbContext).Add(femaleGender);

            new Repository<ContactMemberTypeTable>(dbContext).Add(customerMember);
            new Repository<ContactMemberTypeTable>(dbContext).Add(companyMember);
            new Repository<ContactMemberTypeTable>(dbContext).Add(storeMember);
            new Repository<ContactMemberTypeTable>(dbContext).Add(supplierMember);

            new Repository<InventoryConditionTable>(dbContext).Add(noneInventoryCondition);

            new Repository<ItemCategoryTable>(dbContext).Add(noneItemCategory);

            new Repository<ItemMakerTable>(dbContext).Add(noneItemMaker);

            new Repository<ItemTypeTable>(dbContext).Add(noneItemType);

            new Repository<UnitTable>(dbContext).Add(noneUnit);
            new Repository<UnitTable>(dbContext).Add(mUnit);
            new Repository<UnitTable>(dbContext).Add(kgUnit);
            new Repository<UnitTable>(dbContext).Add(unitUnit);
            
            new Repository<AccountTable>(dbContext).Add(cash);
            new Repository<AccountTable>(dbContext).Add(ar);
            new Repository<AccountTable>(dbContext).Add(ir);
            new Repository<AccountTable>(dbContext).Add(interestRevenue);

            dbContext.SaveChanges();
            
        }



       

        private void InsertApplicationFunctions(DatabaseContext dbContext)
        {

            //FUNCTIONS
            //1 View
            var view = new FunctionTable()
            {
                Code = "View",
            };

            //2 Create
            var add = new FunctionTable()
            {
                Code = "Add",
            };

            //3 Update
            var update = new FunctionTable()
            {
                Code = "Update",
            };

            //4 Delete
            var delete = new FunctionTable()
            {
                Code = "Delete",
            };

            //5 Print
            var print = new FunctionTable()
            {
                Code = "Print",
            };

            //5 Receive
            var receive = new FunctionTable()
            {
                Code = "Receive",
            };

            var viewDetail = new FunctionTable()
            {
                Code = "ViewDetail",
            };

            //APPLICATIONS
            //2-LoanJournalWDC
            var loanJournalWDC = new ApplicationTable
            {
                Code = "LoanJournalWDC",
            };

            var loanCollectionSheet = new ApplicationTable
            {
                Code = "LoanCollectionSheet",
            };

            var loanPaymentSheet = new ApplicationTable
            {
                Code = "LoanPaymentSheet",
            };

            //APPAppFunctions
            var repo = new Repository<ApplicationFunctionTable>(dbContext);
            
            repo.Add(InsertAppFunc(loanJournalWDC, viewDetail, view, add, update, delete, print));
            repo.Add(InsertAppFunc(loanCollectionSheet, view, print));
            repo.Add(InsertAppFunc(loanPaymentSheet, view, receive, print));
            
            dbContext.SaveChanges();
        }
        private static IEnumerable<ApplicationFunctionTable> InsertAppFunc(ApplicationTable application, params FunctionTable[] functions)
        {
            return functions.Select(functionTable => new ApplicationFunctionTable() { ApplicationTable = application, FunctionTable = functionTable }).ToList();
        }

    }
}
