using AccountingInfrastructure.Model.Journal.Loan;
using Framework.Base.Helper;
using Framework.Base.Model;
using Microsoft.Practices.Unity;

namespace AccountingModel
{
    public class LoanJournalWDCModel : ModelBaseDecorator, ILoanJournalWDCModel
    {
        
        public LoanJournalWDCModel(IUnityContainer container) : base(container)
        {

        }


        public double Amount { get; set; }
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