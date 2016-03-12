using System.Drawing;
using Framework.Base.App;
using Framework.Interfaces.App;

namespace Framework.Interfaces.Helper
{
    public interface IApp : IHelperObject
    {
        IAppCategory AppCategory { get; set; }
        IAppGroup AppGroup { get; set; }
        Image Image { get; set; }
        KZBindingList<IFunction> Functions { get; set; }
    }
}