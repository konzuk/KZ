using MainModel.Contact;
using MainStructure.Model.Employee;
using MainStructure.Model.User;

namespace MainModel.User
{
    public  class UserModel : ContactModel, IUserModel
    {
        
        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserNameInLatin { get; set; }
        
        private string _password;
        public string Password {
            get { return _password; }
            set { _password = value; RaisePropertyChanged("Password"); }
        }

        private bool _isActive;
        public bool IsActive {
            get { return _isActive; }
            set { _isActive = value; RaisePropertyChanged("IsActive"); }
        }

        private IUserGroupModel _userGroupModel;
        public IUserGroupModel UserGroupModel {
            get { return _userGroupModel; }
            set { _userGroupModel = value; RaisePropertyChanged("UserGroupModel"); }
        }
        public int UserGroupId { get { return UserGroupModel == null ? 0 : UserGroupModel.UserGroupId; } }
        public string UserGroupName{get { return UserGroupModel == null ? "" : UserGroupModel.UserGroupName; }}
       
        public int EmployeeId {
            get { return EmployeeModel == null ? 0 : EmployeeModel.ContactId; }
        }
        public IEmployeeModel EmployeeModel { get; set; }
        public string EmployeeName { get { return EmployeeModel == null ? "" : EmployeeModel.ContactName; } }
    }
}
