using MainFramework.Classes;
using MainStructure.Model.User;

namespace MainModel.User
{
    public class RoleModel : ModelBase, IRoleModel
    {
        
        public int ApplicationFunctionId { 
            get { return ApplicationFunctionModel == null ? 0 : ApplicationFunctionModel.ApplicationFunctionId; } 
        }
        public virtual IApplicationFunctionModel ApplicationFunctionModel { get; set; }


        public int UserGroupId { get { return UserGroupModel == null ? 0 : UserGroupModel.UserGroupId; }}
        public virtual IUserGroupModel UserGroupModel { get; set; }
        public string UserGroupName { get { return UserGroupModel == null ? "" : UserGroupModel.UserGroupName; } }
       
        public bool Checked { get; set; }
    }
}
