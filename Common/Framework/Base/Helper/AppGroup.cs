using Framework.Base.App;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class AppGroup : HelperObject, IAppGroup
    {
        public KZBindingList<IApp> Apps { get; set; }
    }
}