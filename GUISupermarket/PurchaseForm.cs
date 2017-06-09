using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUISupermarket
{
    public partial class PurchaseForm : Form
    {
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;

        public PurchaseForm()
        {
            /**
            SUPERMARKETDBDataSet ds = new SUPERMARKETDBDataSet();
            var s = ds.Item.Select(x => x);
             foreach (var y in s)
            {
               MessageBox.Show(y.ToString());
            }**/
            InitializeComponent();

        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var products = context.Items.Select(p => new { p.itemID, p.itemDesc, p.price });
                dataGridView1.DataSource = products;
            }
             
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity
    });
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            
            using (DataClasses1DataContext context = new DataClasses1DataContext()) {
                //Global.CurrUser = new UserAccount();
                //Global.CurrUser.username = "rbakst";
                if (Global.CurrUser.balance > Global.MAXBALANCE)
                {
                    MessageBox.Show(String.Format("Your current balance is {0:C}."
                        + "\nThe Maximum Balance allowed to make a purchase is {1:C}." +
                        "Please make a payment in order to purchase further.", Global.CurrUser.balance, Global.MAXBALANCE));
                }
                else
                {
                    int colVal;
                   // DataRow dr = sUPERMARKETDBDataSet.Purchase.NewRow();
                    //code
                   //context.Purchases.Rows.Add(dr);
                     foreach (DataGridViewRow aRow in dataGridView1.Rows)
                    {
                        //in mid of this, no clue if will work
                        DataGridViewCell col = aRow.Cells["Quantity"];//dk if will work
                        if (Int32.TryParse(col.Value.ToString(), out colVal))
                        {
                            //get itemid from table, insert a purchase
                            dataGridView1.
                        }
                        else
                        {
                            MessageBox.Show("Please review that Quantity column is accurate");
                        }

                    }
                }*/
            } 
        } 
    }

