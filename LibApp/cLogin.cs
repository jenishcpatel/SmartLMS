using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

//using System.Data.OracleClient;


namespace LibApp
{
    public class cLogin
    {

        #region "Set Variables"

        private string _role_id;
        private string _user_id;
        private string _password;
        private string _empid;
        private string _firstname;
        private string _lastname;
        private Int64 _mobilenumber;
        private string _email;
        private DateTime? _joiningdate;
        private DateTime? _relevingdate;
        private Int32 _employeeid;
        private Int32 _deptid;
        private Int32 _desig;
        private Int32 _CreatedBy;
        private string _UserType;

        #endregion

        #region " Set Properties"

        public string  Role_ID
        {
            get { return _role_id; }
            set { _role_id = value; }
        }


        public string UserType
        {
            get { return _UserType; }
            set { _UserType = value; }
        }


        public string EmpId
        {
            get { return _empid; }
            set { _empid = value; }
        }

        public string User_Name
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }


        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public Int64 MobileNumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; }

        }
        
               
        public DateTime? Joining_Date
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

        public Int32 CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }

        }


        #endregion


        public static MySqlCommand mCommand;

        public static string INTECH = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        //public  DataSet ExecuteDataSet()
        //{
        //    MySqlConnection conn = new MySqlConnection(INTECH);
        //    conn.Open();
        //    MySqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = "PRC_GET_USER_DETAILS";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("P_USER_NAME", OracleType.VarChar).Value = this.User_Name;
        //    cmd.Parameters.Add("P_ROLE_ID", OracleType.Number).Value = this.Role_ID;
        //    cmd.Parameters.Add("P_PASSWORD", OracleType.VarChar).Value = this.Password;


        //    DataSet ds = new DataSet();
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //    adapter.Fill(ds);
        //    return ds;
        //}


        public DataSet executedatatable()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                if ( cn.State==ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_USER_DETAILS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMP_ID", MySqlDbType.VarChar).Value = this.EmpId;
                cmd.Parameters.Add("P_PASSWORD", MySqlDbType.VarChar).Value = this.Password;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet GetUserData()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_USER_INFO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMP_ID", MySqlDbType.Int32).Value = this.EmpId;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public string insertuser()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                string RETURNVALUE;
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSERT_USER";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMPLOYEE_ID", MySqlDbType.Int64).Value = this.EmpId;
                cmd.Parameters.Add("P_USER_NAME", MySqlDbType.VarChar).Value = this.User_Name;
                cmd.Parameters.Add("P_PASSWORD", MySqlDbType.VarChar).Value = this.Password;
                cmd.Parameters.Add("P_FIRSTNAME", MySqlDbType.VarChar).Value = this.FirstName;
                cmd.Parameters.Add("P_LASTNAME", MySqlDbType.VarChar).Value = this.Lastname;
                cmd.Parameters.Add("P_DOJ", MySqlDbType.Date).Value = this.Joining_Date;
                cmd.Parameters.Add("P_DOR", MySqlDbType.Date).Value = this.Releving_Date;
                cmd.Parameters.Add("P_DEPARTMENT", MySqlDbType.Int32).Value = this.Department_Id;
                cmd.Parameters.Add("P_DESEGNATION", MySqlDbType.Int32).Value = this.Designation;
                cmd.Parameters.Add("P_MOBILE", MySqlDbType.Int64).Value = this.MobileNumber;
                cmd.Parameters.Add("P_EMAIL_ID", MySqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("P_ROLE_NAME", MySqlDbType.VarChar).Value = this.Role_ID;
                cmd.Parameters.Add("P_CREATED_BY", MySqlDbType.Int64).Value = this.CreatedBy;
                cmd.Parameters.Add("P_USER_TYPE", MySqlDbType.VarChar).Value = this.UserType;
                cmd.Parameters.Add("P_RETURN", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                RETURNVALUE = cmd.Parameters["P_RETURN"].Value.ToString() == "1" ? "Employee Id Already Exist" : "User Created Sucessfully";
                cn.Close();
                return RETURNVALUE;
            }

        }

        public DataSet GetIssuedEmpList()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_ALREADY_ISSUED_EMP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMPID", MySqlDbType.Int32).Value = this.EmpId;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GETEMPCOUNT()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_EMPLOYEE_BOOK_RETURN_COUNT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EmployeeId", MySqlDbType.Int32).Value = this.EmpId;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public void updateuser()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_UPDATE_USER";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("EMPLOYEE_ID", MySqlDbType.Int32).Value = this.EmpId;
                cmd.Parameters.Add("P_PASSWORD", MySqlDbType.VarChar).Value = this.Password;
                cmd.Parameters.Add("P_MOBILE", MySqlDbType.Int64).Value = this.MobileNumber;
                cmd.Parameters.Add("P_EMAIL_ID", MySqlDbType.VarChar).Value = this.Email;
                cmd.Parameters.Add("P_ROLE_NAME", MySqlDbType.VarChar).Value = this.Role_ID;
                cmd.Parameters.Add("P_USER_TYPE", MySqlDbType.VarChar).Value = this.UserType;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return;
            }
        }
    }
}