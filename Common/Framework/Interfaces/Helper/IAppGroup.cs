using Framework.Base.App;
using Framework.Interfaces.App;

namespace Framework.Interfaces.Helper
{
    public interface IAppGroup : IHelperObject
    {
        KZBindingList<IApp> Apps { get; set; }
    }
}