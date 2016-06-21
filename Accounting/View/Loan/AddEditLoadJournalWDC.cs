using System;
using System.Windows.Forms;
using AccountingInfrastructure.Model.Journal.Loan;
using AccountingInfrastructure.View.Journal.Loan;
using DevExpress.Data.Helpers;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using Framework.Base.App;
using Framework.Base.Helper;
using Framework.Base.View;
using Framework.Interfaces.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace AccountingView.Loan
{
    public partial class AddEditLoadJournalWDC : DialogView , IAddEditLoadJournalWDC
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

            var newCustomer = KZHelper.Container.Resolve<IContactModel>();
            newCustomer.Name = Resource.translate.CreateNew;
            newCustomer.Id = 0;

            this.customGridLookUpEditCustomer.AdditionalModelsList = new KZBindingList<IModelBase> { newCustomer };

            customGridLookUpEditCustomer.IsAdditionalModelsOnTop = false;
            customGridLookUpEditCustomer.OnSelectionChangeAction = OnSelectionChangeAction;
            customGridLookUpEditCustomer.InitLookup(KZHelper.Container, LoanJournalWDCModel.ContactModel);

        }

        private IContactModel NewContactModel { get; set; }

        private void OnSelectionChangeAction(IModelBase modelBase)
        {
            var readOnlyDCInfo = modelBase.Id != 0;

            this.textEditName.Properties.ReadOnly = readOnlyDCInfo;
            this.dateEditDateTimeDOB.Properties.ReadOnly = readOnlyDCInfo;
            this.textEditAddress.Properties.ReadOnly = readOnlyDCInfo;
            this.textEditVI.Properties.ReadOnly = readOnlyDCInfo;
            this.textEditCOM.Properties.ReadOnly = readOnlyDCInfo;
            this.textEditDIS.Properties.ReadOnly = readOnlyDCInfo;
            this.textEditPRO.Properties.ReadOnly = readOnlyDCInfo;
            this.textEditPOB.Properties.ReadOnly = readOnlyDCInfo;
            this.customGridLookUpEditGender.Properties.ReadOnly = readOnlyDCInfo;
            this.customGridLookUpEditNAT.Properties.ReadOnly = readOnlyDCInfo;
            this.customGridLookUpEditCIT.Properties.ReadOnly = readOnlyDCInfo;
            

        }

        protected override void OnSave()
        {
            this.LoanJournalWDCModel.ContactModel = null;
            base.OnSave();
        }

        public override void BindModel()
        {

            if (LoanJournalWDCModel == null)
            {
                LoanJournalWDCModel = KZHelper.Container.Resolve<ILoanJournalWDCModel>();
                LoanJournalWDCModel.ContactModel = KZHelper.Container.Resolve<IContactModel>();
            }
            BindCustomer();
            //this.BindCustomer();

            var bindManager = base.GetModelBindingManager(LoanJournalWDCModel);
      
            bindManager.SetBinding(customGridLookUpEditCustomer, e => e.EditValue, x => x.ContactModel);


            bindManager.SetBinding(textEditName, e => e.EditValue, x => x.ContactName);

            //textEditName.DataBindings.Add("EditValue", LoanJournalWDCModel, "ContactName");

            bindManager.SetBinding(dateEditDateTimeDOB, e => e.EditValue, x => x.ContactModel.DateOfBirth);
            bindManager.SetBinding(textEditPOB, e => e.EditValue, x => x.ContactModel.PlaceOfBirth);
            bindManager.SetBinding(textEditAddress, e => e.EditValue, x => x.ContactModel.ContactAddress);

            
            bindManager.SetBinding(textEditVI, e => e.EditValue, x => x.ContactModel.Village);
            bindManager.SetBinding(textEditCOM, e => e.EditValue, x => x.ContactModel.Commune);
            bindManager.SetBinding(textEditDIS, e => e.EditValue, x => x.ContactModel.District);
            bindManager.SetBinding(textEditPRO, e => e.EditValue, x => x.ContactModel.Province);
            bindManager.SetBinding(customGridLookUpEditGender, e => e.EditValue, x => x.ContactModel.GenderModel);
            bindManager.SetBinding(customGridLookUpEditNAT, e => e.EditValue, x => x.ContactModel.NationalityModel );
            bindManager.SetBinding(customGridLookUpEditCIT, e => e.EditValue, x => x.ContactModel.CitizenshipModel);
            //AssignValidationControl(textEditAmount, LoanJournalWDCModel.AmountValidation);

            bindManager.SetBinding(textEditAmount, e => e.Text, x => x.Amount);
            AssignValidationControl(textEditAmount, LoanJournalWDCModel.AmountValidation);


        }

       

        public override void BindEvent()
        {
            base.BindEvent();
        }
        
    }
}
