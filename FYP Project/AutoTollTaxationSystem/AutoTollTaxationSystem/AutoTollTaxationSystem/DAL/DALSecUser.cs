using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using AutoTollTaxationSystem.BAL;

namespace AutoTollTaxationSystem.BAL
{
   public class DALSecUser
    {
        public DALSecUser()
        { }

        public DataTable SecUser(BALSecUser objBALSecUser)
        {
            DataTable dt = new DataTable();
            //TYPE YOUR STORE PROCEDURE NAME HERE
            string spName = "spro_SecUser";
            SqlParameter[] objSqlParameter = new SqlParameter[5];
            string where = "";
            try
            {
                #region Search

                if (objBALSecUser.WHERE != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += objBALSecUser.WHERE;
                }
                if (objBALSecUser.UserKey != 0)
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "UserKey=" + objBALSecUser.UserKey;
                }
                if (objBALSecUser.UserID != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "UserID='" + objBALSecUser.UserID + "'";
                }
                if (objBALSecUser.Password != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "Password='" + objBALSecUser.Password + "'";
                }
                objBALSecUser.WHERE = where;
                #endregion

                #region Add

                objSqlParameter[0] = new SqlParameter("@CRUD", objBALSecUser.CRUD);
                objSqlParameter[1] = new SqlParameter("@WHERE", objBALSecUser.WHERE);

                objSqlParameter[2] = new SqlParameter("@UserKey", objBALSecUser.UserKey);

                objSqlParameter[3] = new SqlParameter("@UserID", objBALSecUser.UserID);

                objSqlParameter[4] = new SqlParameter("@Password", objBALSecUser.Password);
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
