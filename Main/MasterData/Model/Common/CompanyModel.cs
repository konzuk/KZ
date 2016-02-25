using Framework.Base.Model.Contact;
using Framework.Interfaces.Model.Common;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model.Common
{
    public class CompanyModel : ContactModel, ICompanyModel
    {
        private ICurrencyModel _currencyModel;

        public CompanyModel(IUnityContainer container) : base(container)
        {
        }

        public int CurrencyId
        {
            get { return CurrencyModel == null ? 0 : CurrencyModel.Id; }
        }

        public ICurrencyModel CurrencyModel
        {
            get { return _currencyModel; }
            set
            {
                _currencyModel = value;
                RaisePropertyChanged("CurrencyModel");
            }
        }

        public string CurrencyName
        {
            get { return CurrencyModel == null ? "" : CurrencyModel.Name; }
        }
    }
}