using System.Collections.Generic;

namespace Framework.Interfaces.Helper
{
    public interface IApps
    {
        IApp LoanJournalWDC { get; }
        IApp LoanCollectionSheet { get; }
        IApp LoanPaymentSheet { get; }
        Dictionary<string, IApp> ListApps { get; }
    }
}