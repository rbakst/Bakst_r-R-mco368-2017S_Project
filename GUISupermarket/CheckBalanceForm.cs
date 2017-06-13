using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUISupermarket
{
    public partial class CheckBalanceForm : Form
    {
        public CheckBalanceForm()
        {
            InitializeComponent();
            balanceLabel.Text += Global.CurrUser.balance;
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            new PaymentForm().Show();
            this.Hide();
        }
    }
}
