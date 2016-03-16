using AccountingView.Loan;
using Framework.Interfaces.Helper;
using Framework.Interfaces.View;
using Microsoft.Practices.Unity;

namespace LoanProject
{
    public static class ApplicatonsRegister
    {
        public static void Register(IUnityContainer container)
        {
            var apps = container.Resolve<IApps>();

            container.RegisterType<IContentView, PositionContent>(apps.LoanJournalWDC.Code);
        }
    }
}