using Framework.Interfaces.Controller;
using Microsoft.Practices.Unity;

namespace Framework.Base.Controller
{
    public class HomeController : ControllerBase, IHomeController
    {
        public HomeController(IUnityContainer container) : base(container)
        {
        }
    }
}