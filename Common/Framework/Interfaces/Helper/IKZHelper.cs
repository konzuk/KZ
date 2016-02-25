using Framework.Interfaces.App;
using Microsoft.Practices.Unity;

namespace Framework.Interfaces.Helper
{
    public interface IKZHelper
    {
        IUnityContainer Container { get; set; }
        IKZColours KZColours { get; }
        IKZFonts KZFonts { get; }
        IKZBinaryFile KZBinaryFile { get; }
        IKZAppearanceSetter KZAppearanceSetter { get; }
        IKZBindingList<IApp> Apps { get; }

        IKZAsynchronousTask KZAsynchronousTask { get; }
        IKZMessage KZMessage { get; }

        void InitAppFunctions();
    }
}