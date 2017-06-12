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
    public partial class ViewPurchasesForm : Form
    {
        public ViewPurchasesForm()
        {
            InitializeComponent();
        }

        private void btnAllPurchases_Click(object sender, EventArgs e)
        {
            using (Global.Context)
            {
                ViewAllPurchasesForm form = new ViewAllPurchasesForm();
                form.purchasesGridView.DataSource = Global.Context.Purchases.Select(p => p);
                form.Show();
            }
           
        }

        private void btnDatePurchases_Click(object sender, EventArgs e)
        {
            using (Global.Context)
            {
                ViewAllPurchasesForm form = new ViewAllPurchasesForm();
                form.purchasesGridView.DataSource = Global.Context.Purchases.Where(p => p.purchaseDate >= calendar.SelectionStart && p.purchaseDate <= calendar.SelectionEnd);
                form.Show();    
            }
        }

        private void btnAmountPurchases_Click(object sender, EventArgs e)
        {
            using (Global.Context)
            {
                ViewAllPurchasesForm form = new ViewAllPurchasesForm();
                form.purchasesGridView.DataSource = Global.Context.Purchases.Where(p => p.totalPrice >= FromAmount.Value && p.totalPrice <= ToAmount.Value);
                form.Show();
            }
        }
    }

}
