using Framework.Base.Helper;
using Framework.Interfaces.Controller;
using Framework.Interfaces.Helper;
using MainInfrastructure.Model.Contact;

namespace MainInfrastructure.Controller
{
    public interface IContactController : IControllerBase
    {
        KZResult<IContactModel> GetCustomers(IContactModel queryModel);
    }
}