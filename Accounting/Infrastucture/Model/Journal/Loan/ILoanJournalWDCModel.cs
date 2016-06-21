using Framework.Base.Helper;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using MainInfrastructure.Model.Contact;

namespace AccountingInfrastructure.Model.Journal.Loan
{
    public interface ILoanJournalWDCModel : IJournalModel
    {

        IContactModel ContactModel { get; set; }
        string ContactName { get; set; }
        double Amount { get; set; }
        KZResultMessage AmountValidation();

    }
}
