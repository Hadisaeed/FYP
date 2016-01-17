using System;
using System.Data;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutoTollTaxationSystem.DAL;

namespace  AutoTollTaxationSystem.BAL
{
    public class BALtblTransaction
    {
        //Member variables declarations
        private long _RefID;


        private string _WHERE, _CRUD;



       private DateTime  _TransactionDate;

        DALtblTransaction objDALtblTransaction = new DALtblTransaction();

        public BALtblTransaction()
        {
            //Initialization of Member variables

            _RefID = 0;

            _WHERE = _CRUD = "";



            //OTHER FILEDS TYPES NOT MATCHED
            //_TransactionDate = 0;
        }

        #region Class Properties
        public long RefID
        {
            set { _RefID = value; }
            get { return _RefID; }
        }
        public string WHERE
        {
            set { _WHERE = value; }
            get { return _WHERE; }
        }
        public string CRUD
        {
            set { _CRUD = value; }
            get { return _CRUD; }
        }
        /*
        public OtherTypes TransactionDate
        {
        set {_TransactionDate = value; }
        get { return _TransactionDate; }
        }
        */
        #endregion

        #region Class Methods
        public DataTable tblTransaction(BALtblTransaction objBALtblTransaction)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = objDALtblTransaction.tblTransaction(objBALtblTransaction);
            }
            catch (Exception ex)
            { }
            return dt;
        }
        #endregion
    }
}

