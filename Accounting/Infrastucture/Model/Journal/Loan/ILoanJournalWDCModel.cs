using Framework.Base.Helper;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;

namespace AccountingInfrastructure.Model.Journal.Loan
{
    public interface ILoanJournalWDCModel : IJournalModel
    {
        double Amount { get; set; }
        KZResultMessage AmountValidation();

    }
}
