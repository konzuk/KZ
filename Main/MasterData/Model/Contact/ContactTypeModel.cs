using Framework.Base.Model;
using MainInfrastructure.Model.Contact;
using Microsoft.Practices.Unity;

namespace MainModel.Contact
{
    public class ContactTypeModel : ModelBaseDecorator, IContactTypeModel
    {
        public ContactTypeModel(IUnityContainer container) : base(container)
        {
        }
    }
}