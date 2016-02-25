using Framework.Interfaces.Model.Employee;
using Microsoft.Practices.Unity;

namespace Framework.Base.Model.Employee
{
    public class PositionModel : ModelBaseDecorator, IPositionModel
    {
        public PositionModel(IUnityContainer container) : base(container)
        {
        }
    }
}