using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoTollTaxationSystem.BAL;

namespace AutoTollTaxationSystem
{
    public partial class form_AdminLogin : Form
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public form_AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool Validation()
        {
            try
            {
                if (txt_UserName.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter User ID");
                    return false;
                }
                if (txt_Password.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Password");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;


            }
            return true;

        }


        private void GenerateBarCode()
        {
            try
            {
                long _barCode = 0;
                while (true)
                {
                    _barCode = RandomNumber6D();
                    //BALCustomer oBALCustomer = new BALCustomer();
                    //oBALCustomer.CRUD = "Search";
                    //oBALCustomer.Barcode = _barCode;
                    //DataTable dt = oBALCustomer.Customer(oBALCustomer);
                    //if (dt.Rows.Count == 0)
                    //{
                    //    txtBarcode.Text = _barCode.ToString();
                    //    break;
                    //}
                }
            }
            catch (Exception ex)
            {
            }
        }

        public long RandomNumber6D()
        {
            long randomNum = 0;
            try
            {
                lock (syncLock)
                {
                    randomNum = random.Next(100000, 999999);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return randomNum;
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            Addredcord();
        }

        public void Addredcord()
        {
            if (!Validation()) return;
            BALSecUser oBALSecUser = new BALSecUser();
            oBALSecUser.CRUD = "Search";
            oBALSecUser.UserID = txt_UserName.Text;
            oBALSecUser.Password = txt_Password.Text;
            DataTable dtSearch = new DataTable();
            dtSearch = oBALSecUser.SecUser(oBALSecUser);
            if (dtSearch != null && dtSearch.Rows.Count > 0)
            {
                long _barCode = RandomNumber6D();
                MessageBox.Show(_barCode.ToString());
                this.Hide();
                form_AdminSession AdminHome = new form_AdminSession();
                AdminHome.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Id Or Password Not Correct");
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Addredcord();
            }
        }
    }
}
