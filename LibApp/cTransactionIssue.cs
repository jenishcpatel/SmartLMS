using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace LibApp
{
    public class cTransactionIssue
    {
        #region "Variable Declaration"

        public Int32 _employeeId;
        public Int32 _depositeamount;
        public DateTime? _depoitedate;
        public string _barcode;
        public Int32 _bookid;
        public Int32 _bookcateid;
        public DateTime? _fromdate;
        public DateTime? _todate;
        public Int32 _flag;
        public Int32 _issue_id;
        public Int32 _fine;
        public DateTime? _returndate;
        public string remarks;
        public Int32 _onlinefine;
        public Int32 _req_id;
        #endregion
                      

        #region "Property"

        public Int32 EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public Int32 REQ_ID
        {
            get { return _req_id; }
            set { _req_id = value; }
        }

        public string  Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        public Int32 FinePaid
        {
            get { return _fine; }
            set { _fine = value; }
        }


        public Int32 IssueID
        {
            get { return _issue_id; }
            set { _issue_id = value; }
        }

        public Int32 BookCatID
        {
            get { return _bookcateid; }
            set { _bookcateid = value; }
        }

        public Int32 BookID
        {
            get { return _bookid; }
            set { _bookid = value; }
        }

        public Int32 DepositeAmount
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public Int32 Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        public Int32 OnlineFlag
        {
            get { return _onlinefine; }
            set { _onlinefine = value; }
        }

        public DateTime? DepositeDate
        {
            get { return _depoitedate; }
            set { _depoitedate = value; }
        }

        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }


        public DateTime? FromIssuedDate
        {
            get { return _fromdate; }
            set { _fromdate = value; }
        }

        public DateTime? ToIssuedDate
        {
            get { return _todate ; }
            set { _todate = value; }
        }


        public DateTime? ReturnDate
        {
            get { return _returndate ; }
            set { _returndate = value; }
        }


        #endregion
        public static string INTECH = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public DataSet GetEmpList()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitializeLifetimeService = 20000;
                cmd.CommandText = "PRC_GET_EMP_DEPOSITE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMPID", MySqlDbType.Int32).Value = this.EmployeeId;
                ////cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GetEmpData()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_EMP_DATA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMPID", MySqlDbType.Int32).Value = this.EmployeeId;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
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
                cmd.CommandText = "PRC_GET_ALREADY_ISSUED";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EMPID", MySqlDbType.Int32).Value = this.EmployeeId;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GetFineSummary()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_FINE_DETAILS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EmployeeId", MySqlDbType.Int32).Value = this.EmployeeId;
                cmd.Parameters.Add("P_BOOK_ID", MySqlDbType.Int32).Value = this.BookID;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet GetFineSummaryAll()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_FINE_DETAILS_ALL";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EmployeeId", MySqlDbType.Int32).Value = this.EmployeeId;
              
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet GetBookListBarcode()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_BOOKS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_BARCODE", MySqlDbType.VarChar).Value = this.Barcode;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GetExtendedBookCount()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_NO_OF_EXTENDS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_ISSUEID", MySqlDbType.Int32).Value = this.IssueID;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public int insertIssueBook()
        {
            int RVALUE;
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSERT_ISSUE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EmployeeId", MySqlDbType.Int32).Value = this.EmployeeId;
                cmd.Parameters.Add("P_BOOK_ID", MySqlDbType.Int32).Value = this.BookID;
                cmd.Parameters.Add("P_BARCODE", MySqlDbType.VarChar).Value = this.Barcode;
                cmd.Parameters.Add("P_BOOK_CAT_ID", MySqlDbType.Int32).Value = this.BookCatID;
                cmd.Parameters.Add("P_ISSUE_FROM_DATE", MySqlDbType.Date).Value = this.FromIssuedDate;
                cmd.Parameters.Add("P_ISUE_TO_DATE", MySqlDbType.Date).Value = this.ToIssuedDate;
                cmd.Parameters.Add("P_ISSUE_F_ID", MySqlDbType.Int32).Value = this.IssueID;
                cmd.Parameters.Add("P_FLAG", MySqlDbType.Int32).Value = this.Flag;
                cmd.Parameters.Add("P_FLAG_ONLINE", MySqlDbType.Int32).Value = this.OnlineFlag;
                cmd.Parameters.Add("P_OUT", MySqlDbType.Int32).Direction = ParameterDirection.Output;  
                //cmd.Parameters.Add("P_FINE_PAID", MySqlDbType.Int32).Value = this.FinePaid;
                cn.Open();
                cmd.ExecuteNonQuery();
                RVALUE = int.Parse(cmd.Parameters["P_OUT"].Value.ToString());
                cn.Close();
            }
            return RVALUE;
        }

        public void RejectRequest()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_REJECT_REQ";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_REQ_ID", MySqlDbType.Int32).Value = this.REQ_ID;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void insertReturnBook()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_RETURN_BOOK";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EmployeeId", MySqlDbType.Int32).Value = this.EmployeeId;
                cmd.Parameters.Add("P_BOOK_ID", MySqlDbType.Int32).Value = this.BookID;
                cmd.Parameters.Add("P_FINE_AMOUNT", MySqlDbType.Int32).Value = this.FinePaid;
                cmd.Parameters.Add("P_REMARKS", MySqlDbType.VarChar).Value = this.Remarks;
                cmd.Parameters.Add("P_RETURNDATE", MySqlDbType.Date).Value = this.ReturnDate;
                //cmd.Parameters.Add("P_FINE_PAID", MySqlDbType.Int32).Value = this.FinePaid;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public int insertOnlineBookRequest()
        {
            int RVALUE;
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSERT_ONLINE_REQ_EXTEND ";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_EmployeeId", MySqlDbType.Int32).Value = this.EmployeeId;
                cmd.Parameters.Add("P_BARCODE", MySqlDbType.VarChar).Value = this.Barcode;
                cmd.Parameters.Add("P_ISSUE_FROM_DATE", MySqlDbType.Date).Value = this.FromIssuedDate;
                cmd.Parameters.Add("P_ISUE_TO_DATE", MySqlDbType.Date).Value = this.ToIssuedDate;
                cmd.Parameters.Add("P_USER_ID", MySqlDbType.Int32).Value = this.EmployeeId;
                cmd.Parameters.Add("P_BOOK_ID", MySqlDbType.Int32).Value = this.BookID;
                cmd.Parameters.Add("P_BOOK_CAT_ID", MySqlDbType.Int32).Value = this.BookCatID;
                cmd.Parameters.Add("P_FLAG", MySqlDbType.Int32).Value = this.Flag;
                cmd.Parameters.Add("P_ISSUE_F_ID", MySqlDbType.Int32).Value = this.IssueID;
                cmd.Parameters.Add("P_OUT", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                //OracleParameter retval = new OracleParameter("P_OUT", MySqlDbType.Int32);
                //retval.Direction = ParameterDirection.ReturnValue;
                //cmd.Parameters.Add(retval);
                //int returnval = Convert.ToInt32(retval.Value);
                //               cmd.Parameters.Add("P_FINE_PAID", MySqlDbType.Int32).Value = this.FinePaid;
                cn.Open();
                cmd.ExecuteNonQuery();
                RVALUE = int.Parse(cmd.Parameters["P_OUT"].Value.ToString());            
                cn.Close();
            }
            return RVALUE;

        }

        public DataSet GetOnlineBookReq()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_ONLINE_REQ_APPROVAL";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

    }
}