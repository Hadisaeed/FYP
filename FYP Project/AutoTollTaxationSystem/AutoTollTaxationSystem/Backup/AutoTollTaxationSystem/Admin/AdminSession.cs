using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoTollTaxationSystem
{
    public partial class form_AdminSession : Form
    {
        public form_AdminSession()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_Registration Registration = new form_Registration();
            Registration.ShowDialog();
            this.Close();
        }

        private void btn_TopUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_TopUp TopUp = new form_TopUp();
            TopUp.ShowDialog();
            this.Close();
        }

        private void form_AdminSession_Load(object sender, EventArgs e)
        {

        }
    }
}
