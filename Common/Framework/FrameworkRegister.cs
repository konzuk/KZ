using Framework.Base.App;
using Framework.Base.Helper;
using Framework.Base.Model;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using Microsoft.Practices.Unity;

namespace Framework
{
    public static class FrameworkRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IKZHelper, KZHelper>(new ContainerControlledLifetimeManager());


            container.RegisterType<IKZColours, KZColours>(new ContainerControlledLifetimeManager());
            container.RegisterType<IKZFonts, KZFonts>(new ContainerControlledLifetimeManager());
            container.RegisterType<IKZBinaryFile, KZBinaryFile>(new ContainerControlledLifetimeManager());
            container.RegisterType<IKZAppearanceSetter, KZAppearanceSetter>(new ContainerControlledLifetimeManager());
            container.RegisterType<IKZAsynchronousTask, KZAsynchronousTask>(new ContainerControlledLifetimeManager());
            container.RegisterType<IGridLookUpTypes, GridLookUpTypes>(new ContainerControlledLifetimeManager());


            container.RegisterType<IApp, App>();
            container.RegisterType<IAppGroup, AppGroup>();
            container.RegisterType<IAppCategory, AppCategory>();
            container.RegisterType<IAppView, AppView>();
            container.RegisterType<IApps, Apps>();
            container.RegisterType<IFunctions, Functions>();




            container.RegisterType<IKZMessage, KZMessage>();
            container.RegisterType<ICustomComboBoxModel, CustomComboBoxModel>();
            container.RegisterType<IKZHelperMessage, KZHelperMessage>();
        }
    }
}