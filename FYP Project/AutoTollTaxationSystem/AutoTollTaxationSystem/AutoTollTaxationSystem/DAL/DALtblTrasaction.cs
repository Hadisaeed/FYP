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
    class DALtblTransaction
    {
        public DALtblTransaction()
        { }

        public DataTable tblTransaction(BALtblTransaction objBALtblTransaction)
        {
            DataTable dt = new DataTable();
            //TYPE YOUR STORE PROCEDURE NAME HERE
            string spName = "spro_tblTransaction";
            SqlParameter[] objSqlParameter = new SqlParameter[3];
            string where = "";
            try
            {
                #region Search

                if (objBALtblTransaction.WHERE != "")
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += objBALtblTransaction.WHERE;
                }
                //if (objBALtblTransaction.TransactionDate != 0)
                //{
                //    where += where == "" ? " WHERE " : " AND ";
                //    where += "TransactionDate='" + objBALtblTransaction.TransactionDate + "'";
                //}
                if (objBALtblTransaction.RefID != 0)
                {
                    where += where == "" ? " WHERE " : " AND ";
                    where += "RefID=" + objBALtblTransaction.RefID;
                }
                objBALtblTransaction.WHERE = where;
                #endregion

                #region Add

                objSqlParameter[0] = new SqlParameter("@CRUD", objBALtblTransaction.CRUD);
                objSqlParameter[1] = new SqlParameter("@WHERE", objBALtblTransaction.WHERE);

                //objSqlParameter[2] = new SqlParameter("@TransactionDate", objBALtblTransaction.TransactionDate);

                objSqlParameter[2] = new SqlParameter("@RefID", objBALtblTransaction.RefID);
                #endregion

                if (objBALtblTransaction.CRUD == "Insert" || objBALtblTransaction.CRUD == "Update" || objBALtblTransaction.CRUD == "Delete")
                {
                    dt.Columns.Add("pk", typeof(Int32));
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                    int pk = 0;
                    pk = SqlHelper.ExecuteNonQuery(SqlHelper.SqlCon, CommandType.StoredProcedure, spName, objSqlParameter);
                    if (pk == 0)
                        dt.Rows[0][0] = 0;
                    else
                        dt.Rows[0][0] = 1;
                }
                else
                {
                    dt = SqlHelper.ExecuteDataset(SqlHelper.SqlCon, CommandType.StoredProcedure, spName, objSqlParameter).Tables[0];
                }
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
