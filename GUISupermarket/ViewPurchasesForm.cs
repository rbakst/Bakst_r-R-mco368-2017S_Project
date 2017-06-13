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
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
               /* ViewAllPurchasesForm form = new ViewAllPurchasesForm();
                form.purchasesGridView.DataSource = context.Purchases.Select(p => p);
                form.Show();
                //this.Hide();*/
                var rs = context.Purchases.Select(p => p);
                new ViewAllPurchasesForm(rs).Show();

            }
           
        }

        private void btnDatePurchases_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                /*
                ViewAllPurchasesForm form = new ViewAllPurchasesForm();
                form.purchasesGridView.DataSource = context.Purchases.Where(p => p.purchaseDate >= calendar.SelectionStart && p.purchaseDate <= calendar.SelectionEnd);
                form.Show();
                this.Hide();   */

                var rs = context.Purchases.Where(p => p.purchaseDate >= calendar.SelectionStart && p.purchaseDate <= calendar.SelectionEnd);
                new ViewAllPurchasesForm(rs).Show();
            }
        }

        private void btnAmountPurchases_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {/*
                ViewAllPurchasesForm form = new ViewAllPurchasesForm();
                form.purchasesGridView.DataSource =context.Purchases.Where(p => p.totalPrice >= FromAmount.Value && p.totalPrice <= ToAmount.Value);
                form.Show();
                this.Hide();*/
                var rs = context.Purchases.Where(p => p.totalPrice >= FromAmount.Value && p.totalPrice <= ToAmount.Value);
                new ViewAllPurchasesForm(rs).Show();

            }
        }
    }

}
