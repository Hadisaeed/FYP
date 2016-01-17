using System;
using System.Data;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTollTaxationSystem.BAL;
namespace AutoTollTaxationSystem.BAL
{
  public  class BALSecUser
    {
        //Member variables declarations

        private int _UserKey;

        private string _WHERE, _CRUD, _UserID, _Password;




        DALSecUser objDALSecUser = new DALSecUser();

        public BALSecUser()
        {
            //Initialization of Member variables
            _UserKey = 0;


            _WHERE = _CRUD = _UserID = _Password = "";



        }

        #region Class Properties
        public int UserKey
        {
            set { _UserKey = value; }
            get { return _UserKey; }
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
        public string UserID
        {
            set { _UserID = value; }
            get { return _UserID; }
        }
        public string Password
        {
            set { _Password = value; }
            get { return _Password; }
        }
        #endregion

        #region Class Methods
        public DataTable SecUser(BALSecUser objBALSecUser)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = objDALSecUser.SecUser(objBALSecUser);
            }
            catch (Exception ex)
            { }
            return dt;
        }
        #endregion
    }
}
