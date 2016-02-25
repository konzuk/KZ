using Framework.Interfaces.App;

namespace Framework.Interfaces.Helper
{
    public interface IAppGroup : IHelperObject
    {
        IKZBindingList<IApp> Apps { get; set; }
    }
}