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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PurchaseForm().Show();
        }

        private void viewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewPurchasesForm().Show();
        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PaymentForm().Show();
        }

        private void checkBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CheckBalanceForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            
        }
    }
}
