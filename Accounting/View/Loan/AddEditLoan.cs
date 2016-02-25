using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Base.App.Class;
using Microsoft.Practices.Unity;

namespace Framework.Base.View.Loan
{
    public partial class AddEditLoan : DialogView
    {
        public AddEditLoan(IUnityContainer container): base(container)
        {
            InitializeComponent();
        }
    }
}
