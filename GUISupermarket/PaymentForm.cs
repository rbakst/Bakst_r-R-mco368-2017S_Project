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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            balanceLabel.Text += String.Format("{0:C}",Global.CurrUser.balance);
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                Global.CurrUser.balance -= numericUpDown1.Value;

                context.SubmitChanges();
                MessageBox.Show("Thank you for your payment.\nYour balance is: " + String.Format("{0:C}",Global.CurrUser.balance));

            }
            this.Hide();
        }
    }
}
