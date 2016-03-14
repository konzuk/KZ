using AccountingInfrastructure.Model.Journal.Loan;
using AccountingInfrastructure.View.Journal.Loan;
using AccountingModel;
using AccountingView.Loan;
using Microsoft.Practices.Unity;

namespace KZRegister
{
    public static class AccountingRegister
    {
        public static void Register(IUnityContainer container)
        {
            RegisterModel(container);    
            RegisterView(container);
            RegisterController(container);
            
        }

        private static void RegisterController(IUnityContainer container)
        {
        }
        private static void RegisterView(IUnityContainer container)
        {
            container.RegisterType<IAddEditLoadJournalWDC, AddEditLoadJournalWDC>();
        }
        private static void RegisterModel(IUnityContainer container)
        {
            container.RegisterType<ILoanJournalWDCModel, LoanJournalWDCModel>();

        }
    }
}