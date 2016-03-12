using Framework.Base.App;
using Framework.Base.Helper;
using Framework.Base.Model;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using MainController.Contact;
using MainInfrastructure.Controller;
using MainInfrastructure.Model.Contact;
using MainModel.Contact;
using Microsoft.Practices.Unity;

namespace Framework
{
    public static class MainRegister
    {
        public static void Register(IUnityContainer container)
        {
            RegisterModel(container);    
            RegisterView(container);
            RegisterController(container);
            
        }

        private static void RegisterController(IUnityContainer container)
        {
            container.RegisterType<IContactController, ContactController>();
        }
        private static void RegisterView(IUnityContainer container)
        {

        }
        private static void RegisterModel(IUnityContainer container)
        {

            container.RegisterType<IContactModel, ContactModel>();
        }
    }
}