using System.Drawing;
using Framework.Interfaces.App;

namespace Framework.Interfaces.Helper
{
    public interface IApp : IHelperObject
    {
        IAppCategory AppCategory { get; set; }
        IAppGroup AppGroup { get; set; }
        Image Image { get; set; }
        IKZBindingList<IFunction> Functions { get; set; }
    }
}