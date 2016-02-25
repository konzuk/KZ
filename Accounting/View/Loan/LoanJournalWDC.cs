using System.Windows.Forms;
using AccountingInfrastructure.Journal.Loan;
using Framework.Base.App;
using Framework.Base.View;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;

namespace AccountingView.Loan
{
    public partial class LoanJournalWDC : ContentView, ILoanJournalWDC
    {
        public LoanJournalWDC(IUnityContainer container): base(container)
        {
            InitializeComponent();
        }

        public override void LoadAppFunction(IApp app)
        {

            var funcs = KZHelper.Container.Resolve<IFunctions>();
            AssingFunction(app, funcs.Add, AddLoan);
            AssingFunction(app, funcs.Update, UpdateLoan);

            base.LoadAppFunction(app);
        }

        

        private void AddLoan()
        {
           //this.flyoutPanel1.HidePopup();
        }
        private void UpdateLoan()
        {
            //this.flyoutPanel1.ShowPopup();
        }


    }
}
