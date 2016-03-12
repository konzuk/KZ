using Framework.Base.Model;
using MainInfrastructure.Model.Employee;
using Microsoft.Practices.Unity;

namespace MainModel.Employee
{
    public class PositionModel : ModelBaseDecorator, IPositionModel
    {
        public PositionModel(IUnityContainer container) : base(container)
        {
        }
    }
}