using Framework.Interfaces.View;
using Microsoft.Practices.Unity;

namespace Framework.Base.View
{
    public partial class BlankView : ContentView, IContentView

    {
        public BlankView(IUnityContainer container) : base(container)
        {
            InitializeComponent();
        }
    }
}