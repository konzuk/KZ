using MainInfrastructure.Model.Contact;

namespace MainInfrastructure.Model.Common
{
    public interface ICompanyModel : IContactModel
    {
        int CurrencyId { get; }
        ICurrencyModel CurrencyModel { get; set; }
        string CurrencyName { get; }
    }
}