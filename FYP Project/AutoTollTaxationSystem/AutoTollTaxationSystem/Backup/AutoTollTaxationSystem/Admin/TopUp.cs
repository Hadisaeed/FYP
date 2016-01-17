using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoTollTaxationSystem.BAL;
using Microsoft.ApplicationBlocks.Data;


namespace AutoTollTaxationSystem
{
    public partial class form_TopUp : Form
    {
        public form_TopUp()
        {
            InitializeComponent();
            txt_RFID.Focus();
        }

        private void lbl_header_Click(object sender, EventArgs e)
        {

        }

        private void form_TopUp_Load(object sender, EventArgs e)
        {
            txt_RFID.Focus();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_AdminSession AdminHome = new form_AdminSession();
            AdminHome.ShowDialog();
            this.Close();
        }

        private void txt_RFID_TextChanged(object sender, EventArgs e)
        {
            if (txt_RFID.Text.Length == 8)
            {
                BALCust_Registration SearchForTopUp = new BALCust_Registration();
                SearchForTopUp.CRUD = "SearchForTopUp";
                SearchForTopUp.RFID = Convert.ToInt64(txt_RFID.Text);
                DataTable dt = new DataTable();
                dt = SearchForTopUp.Cust_Registration(SearchForTopUp);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txt_RFID.Text = null;
                    lbl_Name.Text = dt.Rows[0]["Name"].ToString();
                    lbl_CarNo.Text = dt.Rows[0]["CarNo"].ToString();
                    lbl_CurrentAmount.Text = dt.Rows[0]["CurrentBalance"].ToString();
                    lbl_Name.Visible = lbl_CarNo.Visible =lbl_CurrentAmount.Visible=true;

                }
            }
            //if (txt_RegNo.Text.Length == 9)
            //{
            //    BALCust_Registration SearchCustomer = new BALCust_Registration();
            //    SearchCustomer.CRUD = "Search";
            //    DataTable dt = new DataTable();
            //    dt = SearchCustomer.Cust_Registration(SearchCustomer);
            //    if (dt != null && dt.Rows.Count > 0)
            //    {
            //        txt_Name.Text = dt.Rows[0]["Name"].ToString();
            //        txt_FatherName.Text = dt.Rows[0]["FName"].ToString();
            //        txt_NICNo.Text = dt.Rows[0]["NicNo"].ToString();
            //        txt_CarNo.Text = dt.Rows[0]["CarNo"].ToString();
            //        cbo_CarName.Text = dt.Rows[0]["CarName"].ToString();
            //        cbo_CarManufacturer.Text = dt.Rows[0]["CarManufacturer"].ToString();
            //        txt_EngineNo.Text = dt.Rows[0]["EngineNo"].ToString();
            //        txt_ChasisNo.Text = dt.Rows[0]["ChasisNo"].ToString();
            //        txt_LicenseNo.Text = dt.Rows[0]["LicenseNo"].ToString();

            //        txt_Name.ReadOnly = true;
            //        txt_FatherName.ReadOnly = true;
            //        txt_NICNo.ReadOnly = true;
            //        txt_NICNo.ReadOnly = true;
            //        txt_CarNo.ReadOnly = true;
            //        txt_EngineNo.ReadOnly = true;
            //        txt_ChasisNo.ReadOnly = true;
            //        txt_LicenseNo.ReadOnly = true;

        }
    }
}
