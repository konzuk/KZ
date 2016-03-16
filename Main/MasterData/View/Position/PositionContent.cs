using System.Windows.Forms;
using Framework.Base.App;
using Framework.Base.View;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;

namespace MainView.Position
{
    public partial class PositionContent : ContentView
    {
        public PositionContent(IUnityContainer container): base(container)
        {
            InitializeComponent();
        }

        public override void LoadAppFunction(IApp app)
        {

            var funcs = KZHelper.Container.Resolve<IFunctions>();
            AssingFunction(app, funcs.Add, AddLoan);
            //AssingFunction(app, funcs.Update, UpdateLoan);
            base.LoadAppFunction(app);
        }

       
      

        private void AddLoan()
        {
            var addLoan = new AddEditPositionDialog(KZHelper.Container);
            addLoan.OwnerView = this;

            var flyout = new KZFlyoutDialog(KZHelper.Container, ParentForm, addLoan as Control);
            flyout.ShowDialog(ParentForm);

            //this.flyoutPanel1.HidePopup();
        }
      

    }
}
