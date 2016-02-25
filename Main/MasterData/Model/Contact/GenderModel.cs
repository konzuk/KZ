using Framework.Interfaces.Model.Contact;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model.Contact
{
    public class GenderModel : ModelBaseDecorator, IGenderModel
    {
        public GenderModel(IUnityContainer container) : base(container)
        {
        }
    }
}