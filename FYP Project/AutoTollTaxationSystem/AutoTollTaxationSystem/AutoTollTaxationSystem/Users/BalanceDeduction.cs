using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using AutoTollTaxationSystem.BAL;

namespace AutoTollTaxationSystem
{
    public partial class form_BalDeduct : Form
    {
        public form_BalDeduct()
        {
            InitializeComponent();
        }

        private void form_BalDeduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage HomePage = new HomePage();
            HomePage.ShowDialog();
            this.Close();
        }

        private void tb_RFID_TextChanged(object sender, EventArgs e)
        {
            if (tb_RFID.Text.Length < 10) return;
            BALCust_Registration objCustomer = new BALCust_Registration();
            objCustomer.CRUD = "Search";
            objCustomer.RFID = Convert.ToInt64(tb_RFID.Text);
            DataTable dt = new DataTable();
            dt = objCustomer.Cust_Registration(objCustomer);
            lbl_CurrAmount.Text = dt.Rows[0]["CurrentBalance"].ToString();
            if (dt != null && dt.Rows.Count > 0)
            {
                lbl_PrvsAmount.Text = dt.Rows[0]["CurrentBalance"].ToString();
                BALCust_Registration oBALCust_Registration = new BALCust_Registration();
                oBALCust_Registration.CRUD = "UpdateBalance";
                oBALCust_Registration.RFID = Convert.ToInt64(tb_RFID.Text);
                oBALCust_Registration.CurrentBalance = Convert.ToInt32(dt.Rows[0]["CurrentBalance"]) - 20;
                lbl_CurrAmount.Text = Convert.ToString(Convert.ToInt32(dt.Rows[0]["CurrentBalance"]) - 20);
                DataTable dtUpdate = new DataTable();
                oBALCust_Registration.Cust_Registration(oBALCust_Registration);


                BALtblTransaction oBALtblTransaction = new BALtblTransaction();
                oBALtblTransaction.CRUD = "Insert";
                oBALtblTransaction.RefID = Convert.ToInt64(tb_RFID.Text);
                DataTable dtInsert = new DataTable();
                dtInsert = oBALtblTransaction.tblTransaction(oBALtblTransaction);
                if (dtInsert != null && dtInsert.Rows.Count > 0)
                {
                    MessageBox.Show("Verified");
                   tb_RFID.Text = "";
                }




               
            }

        }
    }
}
