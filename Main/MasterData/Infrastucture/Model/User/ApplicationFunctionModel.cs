using System.Collections.ObjectModel;
using MainFramework.Classes;
using MainStructure.Model.User;

namespace MainModel.User
{
    public class ApplicationFunctionModel : ModelBase, IApplicationFunctionModel
    {
        
        public int ApplicationId { get { return ApplicationModel == null ? 0 : ApplicationModel.ApplicationId; } }
        public virtual IApplicationModel ApplicationModel { get; set; }
        public string ApplicationName { get { return ApplicationModel == null ? "" : ApplicationModel.ApplicationName; } }

        public int FunctionId { get { return FunctionModel == null ? 0 : FunctionModel.FunctionId; } }
        public virtual IFunctionModel FunctionModel { get; set; }
        public string FunctionName { get { return FunctionModel == null ? "" : FunctionModel.FunctionName; } }

        public virtual Collection<IRoleModel> RoleModels { get; set; }

      
    }
}
