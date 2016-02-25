using System.Collections.Generic;
using Framework.Interfaces.Helper;
using Resource;

namespace Framework.Base.Helper
{
    public class Apps : IApps
    {
        public Apps()
        {
            ListApps = new Dictionary<string, IApp>
            {
                {LoanJournalWDC.Code, LoanJournalWDC},
                {LoanCollectionSheet.Code, LoanCollectionSheet},
                {LoanPaymentSheet.Code, LoanPaymentSheet}
            };
        }

        public IApp LoanJournalWDC => new App
        {
            Code = "LoanJournalWDC",
            AppGroup = AppGroups.Loan,
            Name = translate.LoanJournalWDC,
            Image = Icons.Close_Black_32
        };

        public IApp LoanCollectionSheet => new App
        {
            Code = "LoanCollectionSheet",
            AppGroup = AppGroups.Loan,
            Name = translate.LoanCollectionSheet,
            Image = Icons.Setting_Black_32
        };

        public IApp LoanPaymentSheet => new App
        {
            Code = "LoanPaymentSheet",
            AppGroup = AppGroups.Loan,
            Name = translate.LoanPaymentSheet,
            Image = Icons.User_Black_32
        };


        public Dictionary<string, IApp> ListApps { get; }
    }
}