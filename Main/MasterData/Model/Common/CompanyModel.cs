using MainInfrastructure.Model.Common;
using MainModel.Contact;
using Microsoft.Practices.Unity;

namespace MainModel.Common
{
    public class CompanyModel : ContactModel, ICompanyModel
    {
        private ICurrencyModel _currencyModel;

        public CompanyModel(IUnityContainer container) : base(container)
        {
        }

        public int CurrencyId => CurrencyModel?.Id ?? 0;

        public ICurrencyModel CurrencyModel
        {
            get { return _currencyModel; }
            set
            {
                _currencyModel = value;
                RaisePropertyChanged(nameof(CurrencyModel));
            }
        }

        public string CurrencyName => CurrencyModel == null ? "" : CurrencyModel.Name;
    }
}