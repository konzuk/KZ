using Framework.Interfaces.Model;

namespace MainInfrastructure.Model.Common
{
    public interface ICurrencyModel : IModelBase
    {
        string CurrencySymbol { get; set; }
    }
}