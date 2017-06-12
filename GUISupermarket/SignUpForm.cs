using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace GUISupermarket
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            using (Global.Context)
            {
                //why don't we need this?
                //Table<UserAccount> users = context.GetTable<UserAccount>();

                Boolean contains = Global.Context.UserAccounts.Any(u => u.username.Equals(usernameTB.Text));
                if (contains)
                {
                    newUsernameLabel.Visible = true;
                }
                else if (pswdTB.TextLength != 8)
                {
                    passwordProblemLabel.Text = "Password must be 8 characters long";
                    passwordProblemLabel.Visible = true;
                }
                else if (pswdTB.Text != reenterpswdTB.Text)
                {
                    passwordProblemLabel.Text = "Passwords don't match";
                    passwordProblemLabel.Visible = true;
                }
                else
                {
                    UserAccount user = new UserAccount();
                    user.username = usernameTB.Text;
                    user.pswd = pswdTB.Text;
                    user.balance = 0;
                    Global.Context.UserAccounts.InsertOnSubmit(user);
                    Global.Context.SubmitChanges();
                    MessageBox.Show("Thank you for signing up");
                    new MainMenuForm().Show();

                }
            }
        }

       
    }
}
