using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Tables.Master.User
{
    public class UserSessionTable 
    {

        //Field
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SessionId { get; set; }
        public bool IsLogout { get; set; }


        private DateTime _loginUtcDateTime = DateTime.UtcNow;
        private DateTime _logoutUtcDateTime = DateTime.UtcNow;
        public DateTime LoginUtcDateTime
        {
            get { return _loginUtcDateTime; }
            set { _loginUtcDateTime = value; }
        }
        public DateTime LogoutUtcDateTime
        {
            get { return _logoutUtcDateTime; }
            set { _logoutUtcDateTime = value; }
        }


        //FK
        public int UserId { get; set; }
        [ForeignKey("UserId"), InverseProperty("UserSessionTables")]
        public UserTable UserTable { get; set; }
        
        //C-FK


        //Other

        [NotMapped]
        public DateTime LoginDateTime
        {
            get { return _loginUtcDateTime.ToLocalTime(); }
            set { _loginUtcDateTime = value.ToUniversalTime(); }
        }
        [NotMapped]
        public DateTime LogoutDateTime
        {
            get { return _logoutUtcDateTime.ToLocalTime(); }
            set { _logoutUtcDateTime = value.ToUniversalTime(); }
        }
    }
}