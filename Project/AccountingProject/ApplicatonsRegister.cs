using AccountingView.Loan;
using Framework.Interfaces.Helper;
using Framework.Interfaces.View;
using MainView.Position;
using Microsoft.Practices.Unity;

namespace AccountingProject
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