using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoTollTaxationSystem;

namespace AutoTollTaxationSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_BalDeduction_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_BalDeduct BalanceDeduct = new form_BalDeduct();
            BalanceDeduct.ShowDialog();
            this.Close();
        }

        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_AdminLogin AdminLogin = new form_AdminLogin();;
            AdminLogin.ShowDialog();
            this.Close();
        }
    }
}
