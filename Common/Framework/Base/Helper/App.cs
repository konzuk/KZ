using System.Drawing;
using Framework.Base.App;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class App : HelperObject, IApp
    {
        public IAppCategory AppCategory { get; set; }
        public IAppGroup AppGroup { get; set; }
        public Image Image { get; set; }
        public KZBindingList<IFunction> Functions { get; set; }
    }
}