
using System;
using MainFramework.Classes;
using MainStructure.Model.User;

namespace MainModel.User
{
    public class UserSession : ModelBase, IUserSessionModel
    {
        public Guid SessionId { get; set; }

        public int UserId { get { return UserModel == null ? 0 : UserModel.UserId; } }
        public IUserModel UserModel { get; set; }

        private DateTime _loginUtcDateTime= DateTime.UtcNow;
        private DateTime _logoutUtcDateTime=DateTime.UtcNow;
        public DateTime LoginUtcDateTime
        {
            get { return _loginUtcDateTime; }
            set { _loginUtcDateTime = value; RaisePropertyChanged("LoginUtcDateTime"); }
        }

        public DateTime LogoutUtcDateTime
        {
            get { return _logoutUtcDateTime; }
            set { _logoutUtcDateTime = value; RaisePropertyChanged("LogoutUtcDateTime"); }
        }

        public DateTime LoginDateTime
        {
            get { return _loginUtcDateTime.ToLocalTime(); }
            set { _loginUtcDateTime = value.ToUniversalTime(); RaisePropertyChanged("LoginDateTime"); }
        }

        public DateTime LogoutDateTime
        {
            get { return _logoutUtcDateTime.ToLocalTime(); }
            set { _logoutUtcDateTime = value.ToUniversalTime(); RaisePropertyChanged("LogoutDateTime"); }
        }

        public bool IsLogout { get; set; }
    }
}
