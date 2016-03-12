using Framework.Interfaces.Model;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model
{
    public class CustomComboBoxModel : ModelBaseDecorator, ICustomComboBoxModel
    {
        public CustomComboBoxModel(IUnityContainer container) : base(container)
        {

        }
    }
}