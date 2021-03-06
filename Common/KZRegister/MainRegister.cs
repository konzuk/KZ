﻿using MainController.Contact;
using MainInfrastructure.Controller;
using MainInfrastructure.Model.Contact;
using MainModel.Contact;
using Microsoft.Practices.Unity;

namespace KZRegister
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