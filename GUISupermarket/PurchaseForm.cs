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
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                
                //format price to currency accross project.
                var products = context.Items.Select(p => new { p.itemID, p.itemDesc,  p.price });
                dataGridView1.DataSource = products;
            }

            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.DefaultCellStyle.NullValue =0.ToString();
            this.dataGridView1.Columns["price"].DefaultCellStyle.Format = "c";

            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity
             });
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
                       

           // using (Global.Context)
           using (DataClasses1DataContext c = new DataClasses1DataContext())
            {
                Global.CurrUser = c.UserAccounts.Where(u => u.username == "rb").FirstOrDefault();

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
                        decimal total = 0m;
                        int numItems = 0;
                        decimal price;
                        string itemDesc;
                        List<Purchase_Item> purItems = new List<Purchase_Item>();

                       
                        foreach (DataGridViewRow aRow in dataGridView1.Rows)
                        {

                            DataGridViewCell col = aRow.Cells["Quantity"];//dk if will work
                            if (col.Value != null)
                            {
                                if (Int32.TryParse(col.Value.ToString(), out colVal))
                                {

                                    Purchase_Item pi = new Purchase_Item();
                                    itemID = (int)(aRow.Cells["itemID"].Value);

                                    pi.itemID = itemID;
                                    pi.amount = colVal;
                                    purItems.Add(pi);

                                    total += colVal * (Decimal)(aRow.Cells["price"].Value);
                                    numItems += colVal;

                                }
                                else
                                {
                                    MessageBox.Show("Quantity column is innacurate for " + aRow.Cells["itemDesc"].Value.ToString() + ".\nExcluded from order.");

                                }
                            }


                        }
                        Purchase p = new Purchase();

                        p.username = Global.CurrUser.username;
                        p.numItems = numItems;
                        p.totalPrice = (decimal)(total);
                        //p.totalPrice = 7.97m;
                        p.purchaseDate = DateTime.Now;
                        //Global.Context.Purchases.InsertOnSubmit(p);

                        //test -this works
                       // int i = Global.Context.ExecuteCommand("insert into Purchase values('rb', 2, 5.00, getDate())");
                       //ChangeSet x2 = Global.Context.GetChangeSet();
                        c.Purchases.InsertOnSubmit(p);
                        c.SubmitChanges();
                        //Global.Context.SubmitChanges();
                        //doesn't submit?
                        //bool x = Global.Context.Purchases.Contains(p);
                        //MessageBox.Show(x.ToString());

                        int pID = p.PurchaseID;

                        //does this update the table in the datacontext?
                        Global.CurrUser.balance = Global.CurrUser.balance + total;

                        foreach (Purchase_Item pi in purItems)
                        {
                            pi.purchaseID = pID;
                            //Global.Context.Purchase_Items.InsertOnSubmit(pi);
                            c.Purchase_Items.InsertOnSubmit(pi);
                            //Global.Context.SubmitChanges();
                            c.SubmitChanges();
                        }
                        MessageBox.Show("Order submitted. Thank you for shopping with us");
                        this.Hide();

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error, could not process order"+ (ex.StackTrace));
                    
                }
                //catch(NotSupportedException ex1)
                //{
                //    MessageBox.Show("Error, could not process order");
                //}
            }
        }
    }
}

