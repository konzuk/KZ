using Framework.Interfaces.Helper;

namespace Framework.Interfaces.View
{
    public interface IContentView : IViewBase
    {
        IViewBase Owner { get; set; }
        void LoadAppFunction(IApp app);
    }
}