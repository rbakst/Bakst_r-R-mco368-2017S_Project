﻿using System;
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
            new ViewAllPurchasesForm();
           
        }
    }

}
