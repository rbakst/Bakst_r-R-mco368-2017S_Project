using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
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
           
            InitializeComponent();

        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            using (Global.Context)
            {
                var products = Global.Context.Items.Select(p => new { p.itemID, p.itemDesc, p.price });
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

            using (Global.Context)
            {



                try
                {
                    if (Global.CurrUser.balance > Global.MAXBALANCE)
                    {
                        MessageBox.Show(String.Format("Your current balance is {0:C}."
                            + "\nThe Maximum Balance allowed to make a purchase is {1:C}." +
                            "Please make a payment in order to purchase further.", Global.CurrUser.balance, Global.MAXBALANCE));
                    }
                    else
                    {
                        int colVal;
                        int itemID;
                        decimal total = 0;
                        int numItems = 0;
                        decimal price;
                        string itemDesc;


                        Purchase p = new Purchase();
                        p.UserAccount = Global.CurrUser;
                        Global.Context.Purchases.InsertOnSubmit(p);

                        Global.Context.SubmitChanges();
                        int pID = p.PurchaseID;

                        foreach (DataGridViewRow aRow in dataGridView1.Rows)
                        {

                            DataGridViewCell col = aRow.Cells["Quantity"];//dk if will work
                            if (Int32.TryParse(col.Value.ToString(), out colVal))
                            {
                               
                                itemID = (int)(aRow.Cells["itemID"].Value);
                                Purchase_Item pi = new Purchase_Item();
                                pi.itemID = itemID;
                                pi.Purchase = p;
                                pi.amount = colVal;
                                total += colVal * (decimal)aRow.Cells["price"].Value;
                                Global.Context.Purchase_Items.InsertOnSubmit(pi);
                                Global.Context.SubmitChanges();
                                numItems += colVal;

                            }
                            else
                            {
                                MessageBox.Show("Quantity column is innacurate for " + aRow.Cells["itemDesc"].ToString() + ".\nExcluded from order.");

                            }



                        }

                        p.numItems = numItems;
                        p.totalPrice = total;
                        Global.CurrUser.balance += total;
                        Global.Context.SubmitChanges();
                        MessageBox.Show("Order submitted. Thank you for shopping with us");

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error, could not process order");
                }
                //catch(NotSupportedException ex1)
                //{
                //    MessageBox.Show("Error, could not process order");
                //}
            }
        }
    }
}

