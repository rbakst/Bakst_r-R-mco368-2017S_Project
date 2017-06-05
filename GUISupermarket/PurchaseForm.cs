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
            // TODO: This line of code loads data into the 'sUPERMARKETDBDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.sUPERMARKETDBDataSet.Item);
            //itemDesc col is null in the dataset so the dataadpater isn't uploading it properly
            //MessageBox.Show(this.sUPERMARKETDBDataSet.Item[0].itemDesc);

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext()) {
                //Global.CurrUser = new UserAccount();
                //Global.CurrUser.username = "rbakst";
                //if(Global.CurrUser.balance > Global.MAXBALANCE)
                //{
                //    MessageBox.Show(String.Format("Your current balance is {0:C}."
                //        + "\nThe Maximum Balance allowed to make a purchase is {1:C}." +
                //        "Please make a payment in order to purchase further.", Global.CurrUser.balance, Global.MAXBALANCE));
                //}
               //  else
                {
                    int colVal;
                    DataRow dr = sUPERMARKETDBDataSet.Purchase.NewRow();
                    //code
                    sUPERMARKETDBDataSet.Purchase.Rows.Add(dr);

                    DataRow purchaseItemDR;
                    //dr["username"] = Global.CurrUser.username;
                    foreach (DataGridViewRow aRow in dataGridView1.Rows)
                    {
                        //in mid of this, no clue if will work
                        DataGridViewCell col = aRow.Cells["Quantity"];//dk if will work
                        if (Int32.TryParse(col.Value.ToString(), out colVal))
                        {
                            purchaseItemDR = sUPERMARKETDBDataSet.Purchase_Item.NewRow();
                            purchaseItemDR["purchaseID"] = dr["PurchaseID"];
                            
                            
                            context.Items i = (Item)aRow.DataBoundItem;
                            purchaseItemDR["itemID"] = i.itemID;
                        }
                        else
                        {
                            MessageBox.Show("Please review that Quantity column is accurate");
                        }

                    }
                }
            } 
        } 
    }
}
