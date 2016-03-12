using System.Resources;
using System.Threading;
using System.Windows.Forms;
using AccountingInfrastructure.Journal.Loan;
using DevExpress.XtraEditors;
using Framework.Base.App;
using Framework.Base.Model;
using Framework.Base.View;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.ObjectBuilder2;
using Microsoft.Practices.Unity;

namespace AccountingView.Loan
{
    public partial class LoanJournalWDC : ContentView, ILoanJournalWDC
    {
        public LoanJournalWDC(IUnityContainer container): base(container)
        {
            InitializeComponent();

            this.customGridLookUpEditCustomer.GridLookUpType = KZHelper.GridLookUpTypes.Customer;
            this.customGridLookUpEditStatus.GridLookUpType = KZHelper.GridLookUpTypes.CustomList;
        }

        public override void LoadAppFunction(IApp app)
        {

            var funcs = KZHelper.Container.Resolve<IFunctions>();
            AssingFunction(app, funcs.Add, AddLoan);
            AssingFunction(app, funcs.Update, UpdateLoan);
            base.LoadAppFunction(app);
        }

        public override void AssignName()
        {
            this.layoutControlItemDateTimeFrom.Text = Resource.translate.DateTimeFrom;
            this.layoutControlItemDateTimeTo.Text = Resource.translate.DateTimeTo;
            this.checkEditIsAllDate.Text = Resource.translate.IsAllDate;
            this.layoutControlItemCustomer.Text = Resource.translate.Customer;
            this.layoutControlItemStatus.Text = Resource.translate.Status;

            this.layoutControlItemSearch.Text = Resource.translate.Search;

            this.No.Caption = Resource.translate.Number;
            this.DDA.Caption = Resource.translate.DDA;
            this.Date.Caption = Resource.translate.Date;
            this.Amount.Caption = Resource.translate.Amount;
            this.Status.Caption = Resource.translate.Status;
            this.Customer.Caption = Resource.translate.Customer;

        }

        public override void BindModel()
        {

            var All = KZHelper.Container.Resolve<IContactModel>();
            All.Name = "All";
            All.Id = 0;

            customGridLookUpEditCustomer.AdditionalModelsList = new KZBindingList<IModelBase> { All };
            customGridLookUpEditCustomer.InitLookup(KZHelper.Container, null);

            var model = KZHelper.Container.Resolve<ICustomComboBoxModel>();
            model.Name = "test";
            model.Id = 1;
            var model2 = KZHelper.Container.Resolve<ICustomComboBoxModel>();
            model2.Name = "test2";
            model2.Id = 2;

            customGridLookUpEditStatus.AdditionalModelsList = new KZBindingList<IModelBase> {model, model2};
            customGridLookUpEditStatus.RefreshGridLookUp(KZHelper.Container, null);
        }

        

        public override void BindEvent()
        {
            this.textEditSearch.KeyUp += TextEditSearch_KeyUp;
            this.checkEditIsAllDate.CheckedChanged += CheckEditIsAllDate_CheckedChanged;
        }

        private void CheckEditIsAllDate_CheckedChanged(object sender, System.EventArgs e)
        {
            this.dateEditDateTimeFrom.Enabled = !checkEditIsAllDate.Checked;
            this.dateEditDateTimeTo.Enabled = !checkEditIsAllDate.Checked;
        }

        private void TextEditSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var textEdit = sender as TextEdit;
            if (textEdit != null) gridView.ApplyFindFilter(textEdit.Text);
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
