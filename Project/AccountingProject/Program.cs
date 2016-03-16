using System;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AccountingProject;
using DevExpress.Skins;
using Framework;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using KZRegister;
using Microsoft.Practices.Unity;

namespace LoanProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



           

            string khmer = "km-KH";
            //string english = "en-US";

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(khmer);


            IUnityContainer container = new UnityContainer();

            container.RegisterType<IObjectContext, DatabaseContext>();
            
          


            FrameworkRegister.Register(container);
            MainRegister.Register(container);
            AccountingRegister.Register(container);
            ApplicatonsRegister.Register(container);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var kZHelper = container.Resolve<IKZHelper>();



            kZHelper.InitAppFunctions();

            var appview = container.Resolve<IAppView>();

            //Splash screens and wait forms created with the help of the SplashScreenManager component run in a separate thread. Information on custom skins registered in the main thread is not available in the splash screen thread until you call the SplashScreenManager.RegisterUserSkins method. To provide information on custom skins to the splash screen thread, uncomment the following line.
            //SplashScreenManager.RegisterUserSkins(asm); 

            Assembly asm = typeof(DevExpress.UserSkins.KZSkinOffice).Assembly;
            SkinManager.Default.RegisterAssembly(asm);

            Application.Run(appview as Form);
        }
    }

    
}
