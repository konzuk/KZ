
using MainFramework.Classes;
using MainStructure.Model.User;

namespace MainModel.User
{
    public class ApplicationModel : ModelBase, IApplicationModel
    {
        public int ApplicationId { get; set; }

        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationNameInLatin { get; set; }
       

    }
}
