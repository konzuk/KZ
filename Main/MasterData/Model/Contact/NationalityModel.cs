using Framework.Base.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace MainModel.Contact
{
    public class NationalityModel : ModelBaseDecorator, INationalityModel
    {
        public NationalityModel(IUnityContainer container) : base(container)
        {
        }
    }
}