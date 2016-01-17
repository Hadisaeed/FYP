using System;
using System.Data;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutoTollTaxationSystem.DAL;

namespace AutoTollTaxationSystem.BAL
{
   public class BALCust_Registration
    {
        //Member variables declarations
        private long _RFID, _NicNo;
        private int _RegistrationNo, _CurrentBalance;

        private string _WHERE, _CRUD, _Name, _FName, _CarNo, _CarName, _CarManufacturer, _EngineNo, _ChasisNo, _LicenseNo;




        DALCust_Registration objDALCust_Registration = new DALCust_Registration();

        public BALCust_Registration()
        {
            //Initialization of Member variables
            _RegistrationNo = _CurrentBalance = 0;
            _RFID = _NicNo = 0;

            _WHERE = _CRUD = _Name = _FName = _CarNo = _CarName = _CarManufacturer = _EngineNo = _ChasisNo = _LicenseNo = "";



        }

        #region Class Properties
        public int RegistrationNo
        {
            set { _RegistrationNo = value; }
            get { return _RegistrationNo; }
        }
        public int CurrentBalance
        {
            set { _CurrentBalance = value; }
            get { return _CurrentBalance; }
        }
        public long RFID
        {
            set { _RFID = value; }
            get { return _RFID; }
        }
        public long NicNo
        {
            set { _NicNo = value; }
            get { return _NicNo; }
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
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public string FName
        {
            set { _FName = value; }
            get { return _FName; }
        }
        public string CarNo
        {
            set { _CarNo = value; }
            get { return _CarNo; }
        }
        public string CarName
        {
            set { _CarName = value; }
            get { return _CarName; }
        }
        public string CarManufacturer
        {
            set { _CarManufacturer = value; }
            get { return _CarManufacturer; }
        }
        public string EngineNo
        {
            set { _EngineNo = value; }
            get { return _EngineNo; }
        }
        public string ChasisNo
        {
            set { _ChasisNo = value; }
            get { return _ChasisNo; }
        }
        public string LicenseNo
        {
            set { _LicenseNo = value; }
            get { return _LicenseNo; }
        }
        #endregion

        #region Class Methods
        public DataTable Cust_Registration(BALCust_Registration objBALCust_Registration)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = objDALCust_Registration.Cust_Registration(objBALCust_Registration);
            }
            catch (Exception ex)
            { }
            return dt;
        }
        #endregion
    }
}
