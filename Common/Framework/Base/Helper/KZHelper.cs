using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Entity.Tables.Master.User;
using Framework.Base.App;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;
using Repository;

namespace Framework.Base.Helper
{
    public class KZHelper : IKZHelper
    {
        public KZHelper(IUnityContainer container)
        {
            Container = container;
        }


        
        public void InitAppFunctions()
        {
            var apps = Container.Resolve<IApps>();
            var funcs = Container.Resolve<IFunctions>();

            //var dbContext = new DatabaseContext();

            

            var adapter = Container.Resolve<IObjectContext>();

            var appRepo = new Repository<ApplicationTable>(adapter);

            var applicationTables = appRepo.FindNoTracking(s => true).ToList(); //TODO User Role
            

            if (!applicationTables.Any()) return;


            Apps = new KZBindingList<IApp>();

            foreach (var applicationTable in applicationTables)
            {
                if (!apps.ListApps.ContainsKey(applicationTable.Code)) continue;
                var app = apps.ListApps[applicationTable.Code].Clone() as IApp;

                if (app == null) continue;
                app.Id = applicationTable.Id;

                app.Functions = new KZBindingList<IFunction>();

                //TODO User Role

                foreach (var applicationFunctionTable in applicationTable.ApplicationFunctionTables)
                {
                    if (!funcs.ListFuncs.ContainsKey(applicationFunctionTable.FunctionTable.Code)) continue;

                    var func = funcs.ListFuncs[applicationFunctionTable.FunctionTable.Code].Clone() as IFunction;

                    if (func == null) continue;
                    func.Id = applicationFunctionTable.FunctionId;

                    app.Functions.Add(func);
                }

                Apps.Add(app);
            }
        }

        public IUnityContainer Container { get; set; }

        public IKZColours KZColours => Container.Resolve<IKZColours>();
        public IGridLookUpTypes GridLookUpTypes => Container.Resolve<IGridLookUpTypes>();

        public IKZFonts KZFonts => Container.Resolve<IKZFonts>();

        public IKZBinaryFile KZBinaryFile => Container.Resolve<IKZBinaryFile>();

        public IKZAppearanceSetter KZAppearanceSetter => Container.Resolve<IKZAppearanceSetter>();
        public KZBindingList<IApp> Apps { get; private set; }
        public IKZAsynchronousTask KZAsynchronousTask => Container.Resolve<IKZAsynchronousTask>();
        public IKZMessage KZMessage => Container.Resolve<IKZMessage>();
        public IKZHelperMessage KZHelperMessage => Container.Resolve<IKZHelperMessage>();
    }
}