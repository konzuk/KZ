using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MainDataContext;
using MainEntity.Tables.User;

namespace DataInsertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            var ViewDetail = new FunctionTable()
            {
                Code = "ViewDetail",
            };

            //APPLICATIONS
            //2-LoanJournalWDC
            var LoanJournalWDC = new ApplicationTable
            {
                Code = "LoanJournalWDC",
            };

            var LoanCollectionSheet = new ApplicationTable
            {
                Code = "LoanCollectionSheet",
            };

            var LoanPaymentSheet = new ApplicationTable
            {
                Code = "LoanPaymentSheet",
            };

            //APPAppFunctions
            var repo = new Repository<ApplicationFunctionTable>(dbContext);

            repo.Add(InsertAppFunc(LoanJournalWDC, ViewDetail, view, add, update, delete, print));
            repo.Add(InsertAppFunc(LoanCollectionSheet, view, print));
            repo.Add(InsertAppFunc(LoanPaymentSheet, view, receive, print));

            dbContext.SaveChanges();
        }
        
        private static IEnumerable<ApplicationFunctionTable> InsertAppFunc(ApplicationTable application, params FunctionTable[] functions)
        {
            return functions.Select(functionTable => new ApplicationFunctionTable() {ApplicationTable = application, FunctionTable = functionTable}).ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var adapter = new DatabaseContext();

            InsertApplicationFunctions(adapter);


            MessageBox.Show("Success");

        }
    }
}
