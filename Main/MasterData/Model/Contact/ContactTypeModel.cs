using Framework.Interfaces.Model.Contact;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model.Contact
{
    public class ContactTypeModel : ModelBaseDecorator, IContactTypeModel
    {
        public ContactTypeModel(IUnityContainer container) : base(container)
        {
        }
    }
}