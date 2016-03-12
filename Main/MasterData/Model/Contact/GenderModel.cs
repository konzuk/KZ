using Framework.Base.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace MainModel.Contact
{
    public class GenderModel : ModelBaseDecorator, IGenderModel
    {
        public GenderModel(IUnityContainer container) : base(container)
        {
        }
    }
}