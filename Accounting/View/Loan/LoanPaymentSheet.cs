using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Interfaces.Model.Home;
using Framework.Interfaces.View.Loan;
using Microsoft.Practices.Unity;

namespace Framework.Base.View.Loan
{
    public partial class LoanPaymentSheet : ContentView, ILoanJournalWDC
       
    {
        public LoanPaymentSheet(IUnityContainer container): base(container)
        {
            InitializeComponent();
        }
    }
}
