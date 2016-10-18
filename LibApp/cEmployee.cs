using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibApp
{
    public class cEmployee
    {
        #region "Property"

        private string _firstname;
        private string _middlename;
        private string _lastname;
        private DateTime _dateofbirth;
        private string _gender;
        private Int64 _mobilenumber;
        private string _email;
        private string _currflatnumber;
        private string _currstreet;
        private Int32 _currpincode;
        private Int32 _currstate;
        private Int32 _curdistrict;
        private string _currcity;
        private string _perflatnumber;
        private string _perstreet;
        private Int32 _perpincode;
        private Int32 _perstate;
        private Int32 _perdistrict;
        private string _percity;
        private DateTime _joiningdate;
        private DateTime? _relevingdate;
        private Int32 _employeeid;
        private Int32 _deptid;
        private Int32 _desig;
        private string _barcode;
        private string _bookname;

        #endregion

        #region "Set Property"
        public string FirstName
        {
            get { return _firstname ; }
            set { _firstname = value; }
        }

        public string BARCODE
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        public string BOOKNAME
        {
            get { return _bookname; }
            set { _bookname = value; }
        }
        public string MiddleName
        {
            get { return _middlename; }
            set { _middlename = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname  = value; }
        }

        public DateTime DOB
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; }

        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }

        }

        public Int64 MobileNumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; }

        }


        public string Email
        {
            get { return _email; }
            set { _email = value; }

        }


        public string Current_Flat_Number
        {
            get { return _currflatnumber; }
            set { _currflatnumber = value; }

        }

        public string Current_Street
        {
            get { return _currstreet; }
            set { _currstreet = value; }
   
        }

        public Int32 Current_Pin_Code
        {
            get { return _currpincode; }
            set { _currpincode = value; }
   
        }

        public Int32 Current_State
        {
            get { return _currstate; }
            set { _currstate = value; }

        }
        public Int32 Current_District
        {
            get { return _curdistrict; }
            set { _curdistrict = value; }

        }

        public string Current_City
        {
            get { return _currcity; }
            set { _currcity = value; }

        }

        public string Permanent_Flat_Number
        {
            get { return _perflatnumber; }
            set { _perflatnumber = value; }

        }

        public string Permanent_Street
        {
            get { return _perstreet; }
            set { _perstreet = value; }

        }

        public Int32 Permanent_Pin_Code
        {
            get { return _perpincode; }
            set { _perpincode = value; }

        }

        public Int32 Permanent_State
        {
            get { return _perstate; }
            set { _perstate = value; }

        }
        public Int32 Permanent_District
        {
            get { return _perdistrict; }
            set { _perdistrict = value; }

        }

        public string Permanent_City
        {
            get { return _percity; }
            set { _percity = value; }

        }

        public DateTime Joining_Date
        {
            get { return _joiningdate; }
            set { _joiningdate = value; }

        }

        public DateTime? Releving_Date
        {
            get { return _relevingdate; }
            set { _relevingdate = value; }

        }

        public Int32 Employee_Id
        {
            get { return _employeeid; }
            set { _employeeid = value; }

        }

        public Int32 Department_Id
        {
            get { return _deptid; }
            set { _deptid = value; }

        }

        public Int32 Designation
        {
            get { return _desig; }
            set { _desig = value; }

        }

        #endregion


        #region "methods"

        public static string INTECH = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public string insertEmployee()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                string RETURNVALUE;
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSERT_EMPLOYEE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_FirstName", MySqlDbType.VarChar).Value = this.FirstName;
                cmd.Parameters.Add("P_MiddleName", MySqlDbType.VarChar).Value = this.MiddleName;
                cmd.Parameters.Add("P_LastName", MySqlDbType.VarChar).Value = this.Lastname;
                cmd.Parameters.Add("P_DateOfBirth", MySqlDbType.Date).Value = this.DOB;
                cmd.Parameters.Add("P_Gender", MySqlDbType.VarChar).Value = this.Gender;
                cmd.Parameters.Add("P_MobileNumber", MySqlDbType.Int64).Value = this.MobileNumber;
                cmd.Parameters.Add("P_EmailId", MySqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("P_CurrentFlatNumber", MySqlDbType.VarChar).Value = this.Current_Flat_Number;
                cmd.Parameters.Add("P_CurrentStreet", MySqlDbType.VarChar).Value = this.Current_Street;
                cmd.Parameters.Add("P_CurrentPinCode", MySqlDbType.Int32).Value = this.Current_Pin_Code;
                cmd.Parameters.Add("P_CurrentState", MySqlDbType.Int32).Value = this.Current_State;
                cmd.Parameters.Add("P_CurrentDistrict", MySqlDbType.Int32).Value = this.Current_District;
                cmd.Parameters.Add("P_CurrentCity", MySqlDbType.VarChar).Value = this.Current_City;
                cmd.Parameters.Add("P_PermanentFlatNumber", MySqlDbType.VarChar).Value = this.Permanent_Flat_Number;
                cmd.Parameters.Add("P_PermanentStreet", MySqlDbType.VarChar).Value = this.Permanent_Street;
                cmd.Parameters.Add("P_PermanentPinCode", MySqlDbType.Int32).Value = this.Permanent_Pin_Code;
                cmd.Parameters.Add("P_PermanentState", MySqlDbType.Int32).Value = this.Permanent_State;
                cmd.Parameters.Add("P_PermanentDistrict", MySqlDbType.Int32).Value = this.Permanent_District;
                cmd.Parameters.Add("P_PermanentCity", MySqlDbType.VarChar).Value = this.Permanent_City;
                cmd.Parameters.Add("P_JoiningDate", MySqlDbType.Date).Value = this.Joining_Date;
                cmd.Parameters.Add("P_RelevingDate", MySqlDbType.Date).Value = this.Releving_Date;
                cmd.Parameters.Add("P_EmployeeId", MySqlDbType.Int32).Value = this.Employee_Id;
                cmd.Parameters.Add("P_DepartmentId", MySqlDbType.Int32).Value = this.Department_Id;
                cmd.Parameters.Add("P_Designation", MySqlDbType.Int32).Value = this.Designation;
                cmd.Parameters.Add("P_RETURN", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                RETURNVALUE = cmd.Parameters["P_RETURN"].Value.ToString() == "1" ? "1" : "2";
                cn.Close();
                return RETURNVALUE;
            }
        }

        public DataSet GetDesignation()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_DESIGNATION";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GetDepartment()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_DEPARTMENT";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet GetState()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_State";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GetDistrict(Int16 FLAG)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_DISTRICT";
                if (FLAG == 1)
                {
                    cmd.Parameters.Add("P_STATE_ID", MySqlDbType.Int32).Value = this.Current_State;
                }
                else if (FLAG == 2)
                {
                    cmd.Parameters.Add("P_STATE_ID", MySqlDbType.Int32).Value = this.Permanent_State;
                }

                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GetEmployeeData()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_EMPLYOEE_DATA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMP_ID", MySqlDbType.Int32).Value = this.Employee_Id;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet GetBookDetails()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_BOOK_SEARCH";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_BARCODE", MySqlDbType.VarChar).Value = this.BARCODE;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GetALLBookDetails()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_ALL_BOOKS";
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
        #endregion 
    }
}