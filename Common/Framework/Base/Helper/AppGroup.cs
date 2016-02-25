using Framework.Interfaces.App;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class AppGroup : HelperObject, IAppGroup
    {
        public IKZBindingList<IApp> Apps { get; set; }
    }
}