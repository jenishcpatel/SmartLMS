using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibApp
{
    public class cDeposite
    {
        #region "Variable Declaration"

        public Int32 _employeeId;
        public Int32 _depositeamount;
        public DateTime ? _depoitedate;

        #endregion


        #region "Property"

        public Int32 EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public Int32 DepositeAmount
        {
            get { return _depositeamount; }
            set { _depositeamount = value; }
        }

        public DateTime ? DepositeDate
        {
            get { return _depoitedate; }
            set { _depoitedate = value; }
        }

        
        #endregion

        #region "Method"
        public static string INTECH = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        public DataSet GetEmpList()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_EMP_DEPOSITE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMPID", MySqlDbType.Int32).Value = this.EmployeeId;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public void UpdateDeposite()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_DEPOSITE_ENTER";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EmployeeId", MySqlDbType.Int32).Value = this.EmployeeId;
                cmd.Parameters.Add("P_Deposite_Amount", MySqlDbType.Int32).Value = this.DepositeAmount;
                cmd.Parameters.Add("P_Deposite_Date", MySqlDbType.Date).Value = this.DepositeDate;
                //cmd.Parameters.Add("P_RETURN", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery(); 
                cn.Close();
            }
        }
        #endregion
    }
}