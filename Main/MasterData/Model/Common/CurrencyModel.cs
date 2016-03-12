using Framework.Base.Model;
using MainInfrastructure.Model.Common;
using Microsoft.Practices.Unity;

namespace MainModel.Common
{
    public class CurrencyModel : ModelBaseDecorator, ICurrencyModel
    {
        private string _currencySymbol;

        public CurrencyModel(IUnityContainer container) : base(container)
        {
        }

        public string CurrencySymbol
        {
            get { return _currencySymbol; }
            set
            {
                _currencySymbol = value;
                RaisePropertyChanged(nameof(CurrencySymbol));
            }
        }
    }
}