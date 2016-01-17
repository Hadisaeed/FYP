using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using AutoTollTaxationSystem.BAL;

namespace AutoTollTaxationSystem.DAL
{
   public class DALCust_Registration
    {
        public DALCust_Registration()
        { }

        public DataTable Cust_Registration(BALCust_Registration objBALCust_Registration)
        {
            DataTable dt = new DataTable();
            //TYPE YOUR STORE PROCEDURE NAME HERE
            string spName = "spro_Cust_Registration";
            SqlParameter[] objSqlParameter = new SqlParameter[14];
            string where = "";
            try
            {
                #region Search

                if (objBALCust_Registration.WHERE != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += objBALCust_Registration.WHERE;
                }
                if (objBALCust_Registration.RegistrationNo != 0)
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "RegistrationNo=" + objBALCust_Registration.RegistrationNo;
                }
                if (objBALCust_Registration.CurrentBalance != 0)
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "CurrentBalance=" + objBALCust_Registration.CurrentBalance;
                }
                if (objBALCust_Registration.RFID != 0)
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "RFID=" + objBALCust_Registration.RFID;
                }
                if (objBALCust_Registration.NicNo != 0)
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "NicNo=" + objBALCust_Registration.NicNo;
                }
                if (objBALCust_Registration.Name != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "Name='" + objBALCust_Registration.Name + "'";
                }
                if (objBALCust_Registration.FName != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "FName='" + objBALCust_Registration.FName + "'";
                }
                if (objBALCust_Registration.CarNo != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "CarNo='" + objBALCust_Registration.CarNo + "'";
                }
                if (objBALCust_Registration.CarName != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "CarName='" + objBALCust_Registration.CarName + "'";
                }
                if (objBALCust_Registration.CarManufacturer != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "CarManufacturer='" + objBALCust_Registration.CarManufacturer + "'";
                }
                if (objBALCust_Registration.EngineNo != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "EngineNo='" + objBALCust_Registration.EngineNo + "'";
                }
                if (objBALCust_Registration.ChasisNo != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "ChasisNo='" + objBALCust_Registration.ChasisNo + "'";
                }
                if (objBALCust_Registration.LicenseNo != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "LicenseNo='" + objBALCust_Registration.LicenseNo + "'";
                }
                objBALCust_Registration.WHERE = where;
                #endregion

                #region Add

                objSqlParameter[0] = new SqlParameter("@CRUD", objBALCust_Registration.CRUD);
                objSqlParameter[1] = new SqlParameter("@WHERE", objBALCust_Registration.WHERE);

                objSqlParameter[2] = new SqlParameter("@RegistrationNo", objBALCust_Registration.RegistrationNo);

                objSqlParameter[3] = new SqlParameter("@CurrentBalance", objBALCust_Registration.CurrentBalance);

                objSqlParameter[4] = new SqlParameter("@RFID", objBALCust_Registration.RFID);

                objSqlParameter[5] = new SqlParameter("@NicNo", objBALCust_Registration.NicNo);

                objSqlParameter[6] = new SqlParameter("@Name", objBALCust_Registration.Name);

                objSqlParameter[7] = new SqlParameter("@FName", objBALCust_Registration.FName);

                objSqlParameter[8] = new SqlParameter("@CarNo", objBALCust_Registration.CarNo);

                objSqlParameter[9] = new SqlParameter("@CarName", objBALCust_Registration.CarName);

                objSqlParameter[10] = new SqlParameter("@CarManufacturer", objBALCust_Registration.CarManufacturer);

                objSqlParameter[11] = new SqlParameter("@EngineNo", objBALCust_Registration.EngineNo);

                objSqlParameter[12] = new SqlParameter("@ChasisNo", objBALCust_Registration.ChasisNo);

                objSqlParameter[13] = new SqlParameter("@LicenseNo", objBALCust_Registration.LicenseNo);
                #endregion

                 dt = SqlHelper.ExecuteDataset(SqlHelper.SqlCon, CommandType.StoredProcedure, spName, objSqlParameter).Tables[0];
            }
            catch (Exception ex)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
                dt.Rows[0][0] = 0;
            }
            return dt;
        }
    }
}
