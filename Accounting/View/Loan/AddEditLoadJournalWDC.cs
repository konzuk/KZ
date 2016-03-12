using System;
using System.Windows.Forms;
using AccountingInfrastructure.Model.Journal.Loan;
using DevExpress.Data.Helpers;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using Framework.Base.View;
using Microsoft.Practices.Unity;

namespace AccountingView.Loan
{
    public partial class AddEditLoadJournalWDC : DialogView
    {
        public AddEditLoadJournalWDC(IUnityContainer container): base(container)
        {
            InitializeComponent();
        }

        public ILoanJournalWDCModel LoanJournalWDCModel { get; set; }

        public override void AssignName()
        {
            this.xtraTabPage1.Text = Resource.translate.Information;
            this.xtraTabPage2.Text = Resource.translate.PaymentSchedule;

            this.layoutControlItemCustomer.Text = Resource.translate.Customer;
            this.layoutControlItemName.Text = Resource.translate.Name;
            this.layoutControlItemGender.Text = Resource.translate.Gender;
            this.layoutControlItemNAT.Text = Resource.translate.Nationality;
            this.layoutControlItemCIT.Text = Resource.translate.Citizenship;
            this.layoutControlItemDOB.Text = Resource.translate.DateOfBirth;
            this.layoutControlItemPOB.Text = Resource.translate.PlaceOfBirth;
            this.layoutControlItemAddress.Text = Resource.translate.Address;
            this.layoutControlItemVI.Text = Resource.translate.Village;
            this.layoutControlItemCOM.Text = Resource.translate.Commune;
            this.layoutControlItemDIS.Text = Resource.translate.District;
            this.layoutControlItemPRO.Text = Resource.translate.Province;
            this.layoutControlItemLoan.Text = Resource.translate.Loan;
            this.layoutControlItemAmount.Text = Resource.translate.Amount;
            this.layoutControlItemRate.Text = Resource.translate.Interest;
            this.layoutControlItemPeriod.Text = Resource.translate.Period;
            this.layoutControlItemPayType.Text = Resource.translate.PayType;

            this.No.Caption = Resource.translate.Number;
            this.Date.Caption = Resource.translate.Date;
            this.Principle.Caption = Resource.translate.Principal;
            this.Interest.Caption = Resource.translate.Interest;
            this.Total.Caption = Resource.translate.Total;
            this.Balance.Caption = Resource.translate.Balance;

            this.Title = Resource.translate.LoanJournalWDC;

        }

        private void BindCustomer()
        {
            this.customGridLookUpEditCustomer.GridLookUpType = KZHelper.GridLookUpTypes.Customer;
            
            //customGridLookUpEditCustomer.InitLookup(KZHelper.Container, LoanJournalWDCModel.DCModel);

        }

        public override void BindModel()
        {
            LoanJournalWDCModel = KZHelper.Container.Resolve<ILoanJournalWDCModel>();

            this.BindCustomer();

            var bindManager = base.GetModelBindingManager(LoanJournalWDCModel);

           
            bindManager.SetBinding(textEditAmount, e => e.EditValue, x => x.Amount);
            AssignValidationControl(textEditAmount, LoanJournalWDCModel.AmountValidation);
            

        }

       

        public override void BindEvent()
        {
            base.BindEvent();
        }
        
    }
}
