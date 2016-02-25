using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace Framework.Base.View.Loan
{
    public partial class test : DialogView
    {
        public test(IUnityContainer container):base(container)
        {
            InitializeComponent();
            
        }
        
    }
}
