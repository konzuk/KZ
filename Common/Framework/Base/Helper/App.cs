using System.Drawing;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class App : HelperObject, IApp
    {
        public IAppCategory AppCategory { get; set; }
        public IAppGroup AppGroup { get; set; }
        public Image Image { get; set; }
        public IKZBindingList<IFunction> Functions { get; set; }
    }
}