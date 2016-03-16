using System;
using System.Windows.Forms;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using Framework.Base.View;
using Microsoft.Practices.Unity;

namespace AccountingView.Loan
{
    public partial class AddEditPositionDialog : DialogView
    {
        public AddEditPositionDialog(IUnityContainer container): base(container)
        {
            InitializeComponent();
        }

       
        
    }
}
