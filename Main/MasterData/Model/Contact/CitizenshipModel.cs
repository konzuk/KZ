using Framework.Base.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace MainModel.Contact
{
    public class CitizenshipModel : ModelBaseDecorator, ICitizenshipModel
    {
        public CitizenshipModel(IUnityContainer container) : base(container)
        {
        }
    }
}