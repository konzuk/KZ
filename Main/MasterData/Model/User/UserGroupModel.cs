using System.Collections.ObjectModel;
using System.Linq;
using MainFramework.Classes;
using MainStructure.Model.User;

namespace MainModel.User
{
    public class UserGroupModel : ModelBase, IUserGroupModel
    {
        public int UserGroupId { get; set; }
        public string UserGroupCode { get; set; }
        public string UserGroupName { get; set; }
        public string UserGroupNameInLatin { get; set; }

        public Collection<IUserModel> UserModels { get; set; }

        public Collection<IRoleModel> RoleModels { get; set; }

        public Collection<IRoleModel> AddRoleModels
        {
            get { return RoleModels == null ? null : new Collection<IRoleModel>(RoleModels.Where(s => s.Checked && s.RoleId==0).ToList()); }
        }
        public Collection<IRoleModel> DeleleRoleModels
        {
            get { return RoleModels == null ? null : new Collection<IRoleModel>(RoleModels.Where(s => !s.Checked && s.RoleId != 0).ToList()); }
        }

        public IFunctionModel FunctionModel { get; set; }
    }
}
