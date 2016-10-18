using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibApp
{
    public class csReport
    {

        #region "Variable Declaration"
        public DateTime? _fromDate;
        public DateTime? _toDate;
        #endregion

        #region "Property"
        public DateTime? FromDate { get { return _toDate; }  set { _toDate = value; } }
        public DateTime? ToDate { get { return _fromDate; } set { _fromDate = value; } }
        #endregion

        public static string INTECH = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        public DataSet ActivePaidUsers()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_RPT_PAID_USER_LIST";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_FROMDATE", MySqlDbType.Date).Value = this.FromDate;
                cmd.Parameters.Add("P_TO_DATE", MySqlDbType.Date).Value = this.ToDate;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet IssuedBook()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_RPT_ISSUED_BOOK";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_FROMDATE", MySqlDbType.Date).Value = this.FromDate;
                cmd.Parameters.Add("P_TO_DATE", MySqlDbType.Date).Value = this.ToDate;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet ReturnBook()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_RPT_RETURN_BOOK";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_FROMDATE", MySqlDbType.Date).Value = this.FromDate;
                cmd.Parameters.Add("P_TO_DATE", MySqlDbType.Date).Value = this.ToDate;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }
}