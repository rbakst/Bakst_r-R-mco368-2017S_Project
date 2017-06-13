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

namespace GUISupermarket
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context =  new DataClasses1DataContext())
            {
                var user = context.UserAccounts.FirstOrDefault(u => u.username.Equals(usernameTB.Text) && u.pswd.Equals(pswdTB.Text));
                if (user == null)
                {
                    MessageBox.Show("Username or Password Invalid");
                }
                else
                {
                    Global.CurrUser = user;
                    //temporary
                    new MainMenuForm().Show();
                    this.Hide();
                }
            }
                
        }

        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignUpForm().Show();
            this.Hide();
        }
    }
}
