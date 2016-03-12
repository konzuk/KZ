using System;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Framework;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
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
            ApplicatonsRegister.Register(container);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var kZHelper = container.Resolve<IKZHelper>();



            kZHelper.InitAppFunctions();

            var appview = container.Resolve<IAppView>();

            Application.Run(appview as Form);
        }
    }
}
