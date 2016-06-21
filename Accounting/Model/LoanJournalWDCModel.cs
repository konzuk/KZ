using System.ComponentModel;
using AccountingInfrastructure.Model.Journal.Loan;
using Framework.Base.Helper;
using Framework.Base.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace AccountingModel
{
    public class LoanJournalWDCModel : ModelBaseDecorator, ILoanJournalWDCModel
    {
        
        public LoanJournalWDCModel(IUnityContainer container) : base(container)
        {
            
        }


        public string ContactName
        {
            get
            {
                return _contactModel.Name; 
                
            }
            set
            {
                _contactModel.Name = value;
                RaisePropertyChanged();
            }
        }

        public double Amount { get; set; }

        public IContactModel ContactModel
        {
            get { return _contactModel; }
            set
            {
                _contactModel = value; 
                RaiseAllPropertyChanged();
            }
        }

        private IContactModel _contactModel;

        public KZResultMessage AmountValidation()
        {
            return new KZResultMessage()
            {
                IsSuccess = Amount > 0,
                Message = Amount > 0 ? "" : "Error Amount",
            };
        }
    }
}