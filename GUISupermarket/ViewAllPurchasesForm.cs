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
    public partial class ViewAllPurchasesForm : Form
    {
        public ViewAllPurchasesForm(IEnumerable<Purchase> rs)
        {
            InitializeComponent();
            // var rs = context.Purchases.Where(p => p.totalPrice >= FromAmount.Value && p.totalPrice <= ToAmount.Value).Select(p => new { id = p.PurchaseID, numItems = p.numItems, total = p.totalPrice, date = p.purchaseDate });

            purchasesGridView.DataSource = rs.Select(p => new { id = p.PurchaseID, numItems = p.numItems, total = p.totalPrice, date = p.purchaseDate }).ToList();
             this.purchasesGridView.Columns["total"].DefaultCellStyle.Format = "c";
        }

        
    }
}
