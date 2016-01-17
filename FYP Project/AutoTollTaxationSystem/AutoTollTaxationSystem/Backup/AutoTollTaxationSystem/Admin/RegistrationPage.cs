using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using AutoTollTaxationSystem.BAL;
using Microsoft.ApplicationBlocks.Data;

namespace AutoTollTaxationSystem
{
    public partial class form_Registration : Form
    {
        public form_Registration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_RegNo_TextChanged(object sender, EventArgs e)
        {
            if (txt_RegNo.Text.Length == 9)
            {
                BALCust_Registration SearchCustomer = new BALCust_Registration();
                SearchCustomer.CRUD = "Search";
                DataTable dt = new DataTable();
                dt = SearchCustomer.Cust_Registration(SearchCustomer);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txt_Name.Text = dt.Rows[0]["Name"].ToString();
                    txt_FatherName.Text = dt.Rows[0]["FName"].ToString();
                    txt_NICNo.Text = dt.Rows[0]["NicNo"].ToString();
                    txt_CarNo.Text = dt.Rows[0]["CarNo"].ToString();
                    cbo_CarName.Text = dt.Rows[0]["CarName"].ToString();
                    cbo_CarManufacturer.Text = dt.Rows[0]["CarManufacturer"].ToString();
                    txt_EngineNo.Text = dt.Rows[0]["EngineNo"].ToString();
                    txt_ChasisNo.Text = dt.Rows[0]["ChasisNo"].ToString();
                    txt_LicenseNo.Text = dt.Rows[0]["LicenseNo"].ToString();

                    txt_Name.ReadOnly = true;
                    txt_FatherName.ReadOnly = true;
                    txt_NICNo.ReadOnly = true;
                    txt_NICNo.ReadOnly = true;
                    txt_CarNo.ReadOnly = true;
                    txt_EngineNo.ReadOnly = true;
                    txt_ChasisNo.ReadOnly = true;
                    txt_LicenseNo.ReadOnly = true;

                }

            }

            if (txt_RegNo.Text == null && txt_RFID1.Text.Length > 0)
            {
                
            }
        }

        private void form_Registration_Load(object sender, EventArgs e)
        {

            cbo_CarManufacturer.DisplayMember = "Text";
            cbo_CarManufacturer.ValueMember = "Value";

               var items = new[] 
                {
                    new { Text = "*Select*", Value = "0" },
                    new { Text = "Toyota Motors", Value = "1" },
                    new { Text = "Suzuki Motors", Value = "2" }
                };

               cbo_CarManufacturer.DataSource = items;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_AdminSession AdminHome = new form_AdminSession();
            AdminHome.ShowDialog();
            this.Close();
        }

        private void cbo_CarName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_CarManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_CarManufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                BALCust_Registration NewCustomer = new BALCust_Registration();
                NewCustomer.CRUD = "Insert";
                NewCustomer.RFID = Convert.ToInt32(txt_RFID1.Text.Trim());
                NewCustomer.Name=txt_Name.Text.Trim();
                NewCustomer.FName = txt_FatherName.Text.Trim();
                NewCustomer.NicNo = Convert.ToInt32(txt_NICNo.Text.Trim());
                NewCustomer.CarNo = txt_CarNo.Text.Trim();
                NewCustomer.CarName = cbo_CarName.SelectedText;
                NewCustomer.CarManufacturer = txt_FatherName.Text.Trim();
                NewCustomer.EngineNo = txt_EngineNo.Text.Trim();
                NewCustomer.ChasisNo = txt_ChasisNo.Text.Trim();
                NewCustomer.LicenseNo = txt_LicenseNo.Text.Trim();

                DataTable dtInsert = new DataTable();
                dtInsert = NewCustomer.Cust_Registration(NewCustomer);
                    ////txt_Name.Text = Convert.ToInt32(["RFID"]);
                    //txt_FatherName.Text = dt.Rows[0]["FName"].ToString();
                    //txt_NICNo.Text = dt.Rows[0]["NicNo"].ToString();
                    //txt_CarNo.Text = dt.Rows[0]["CarNo"].ToString();
                    //cbo_CarName.Text = dt.Rows[0]["CarName"].ToString();
                    //cbo_CarManufacturer.Text = dt.Rows[0]["CarManufacturer"].ToString();
                    //txt_EngineNo.Text = dt.Rows[0]["EngineNo"].ToString();
                    //txt_ChasisNo.Text = dt.Rows[0]["ChasisNo"].ToString();
                    //txt_LicenseNo.Text = dt.Rows[0]["LicenseNo"].ToString();

                    //oBALInvSaleInvoiceDetail.ItemKey = Convert.ToInt32(dr["pk_intItemRecId"]);
                    //oBALInvSaleInvoiceDetail.Quantity = Convert.ToInt32(dr["intQty"]);
                    //oBALInvSaleInvoiceDetail.UnitPrice = Convert.ToDecimal(dr["decUnitPrice"]);
                    //oBALInvSaleInvoiceDetail.TotalPrice = Convert.ToDecimal(dr["decItemPrice"]);
                    //oBALInvSaleInvoiceDetail.InsertedBy = Convert.ToInt32(Session["UserRecId"].ToString());


            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);

            }
        }
    }
}
