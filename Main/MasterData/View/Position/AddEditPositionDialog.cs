using Framework.Base.View;
using Microsoft.Practices.Unity;

namespace MainView.Position
{
    public partial class AddEditPositionDialog : DialogView
    {
        public AddEditPositionDialog(IUnityContainer container): base(container)
        {
            InitializeComponent();
        }

       
        
    }
}
