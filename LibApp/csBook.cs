using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibApp
{
    public class csBook
    {
        #region "Declaration"

        public string _categoriename;
        public string _isactive;
        private Int32 _empid;
        public string _bookname;
        public string _authorname;
        public DateTime? _dateofpurchase;
        public Int32 _bookcateid;
        public string _barcode;
        public Int32 _PurcaseRate;
        public Int32 _mailid;
        public Int32 _issueddays;
        public Int32 _extenddays;
        public Int32 _extendtime;
        public Int32 _noofcopies;
        public string _departname;
        public string _designame;
        


        #endregion

        #region "Property"
        public Int32 IssueDays
        {
            get { return _issueddays; }
            set { _issueddays = value; }
        }

        public Int32 NoofCopies
        {
            get { return _noofcopies; }
            set { _noofcopies = value; }
        }
        public Int32 ExtendDays
        {
            get { return _extenddays; }
            set { _extenddays = value; }
        }

        public Int32 ExtendTime
        {
            get { return _extendtime; }
            set { _extendtime = value; }
        }


        public Int32 EmpId
        {
            get { return _empid; }
            set { _empid = value; }
        }


        public Int32 MailId
        {
            get { return _mailid; }
            set { _mailid = value; }
        }



        public string CategoryName
        {
            get { return _categoriename; }
            set { _categoriename = value; }
        }

        public string DepartmentName
        {
            get { return _departname; }
            set { _departname = value; }
        }


        public string DesignationName
        {
            get { return _designame; }
            set { _designame = value; }
        }


        public string IsActive
        {
            get { return _isactive; }
            set { _isactive = value; }
        }


        public string BookName
        {
            get { return _bookname; }
            set { _bookname = value; }
        }

        public string AuthorName
        {
            get { return _authorname; }
            set { _authorname = value; }
        }

        public DateTime ? PurchaseDate
        {
            get { return _dateofpurchase; }
            set { _dateofpurchase = value; }
        }

        public Int32 BookCatID
        {
            get { return _bookcateid; }
            set { _bookcateid = value; }
        }

        public Int32 PUrchaseRate
        {
            get { return _PurcaseRate; }
            set { _PurcaseRate = value; }
        }

        public string  Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }







        #endregion


        #region "Method"
        public static string INTECH = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public void insertCategory()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSERT_CATEGORY";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_CategoryName", MySqlDbType.VarChar).Value = this.CategoryName;
                cmd.Parameters.Add("P_IsActive", MySqlDbType.VarChar).Value = this.IsActive;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void insertDepartment()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSERT_DEPARTMENT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_DEPARTMENT_NAME", MySqlDbType.VarChar).Value = this.DepartmentName;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void insertDesignation()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSERT_DESIGNATION";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_DESIGNATION_NAME", MySqlDbType.VarChar).Value = this.DesignationName;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public DataSet GetCategoryList()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_CATEGORY";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet GetMailList()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_MAIL";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet GetMailCount()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_COUNT_MAIL";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public DataSet GetDashBoardCount()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_DASHBOARD_COUNT";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public void DeleteCategory( Int32 CATEG_ID)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_DELETE_CATEGORY";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_Categoryid", MySqlDbType.Int32).Value = CATEG_ID;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void DeleteDepartment(Int32 DEPTID)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_DELETE_DEPARTMENT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_DEPT_ID", MySqlDbType.Int32).Value = DEPTID;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void DeleteDesignation(Int32 DESIGID)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_DELETE_DESIGNATION";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_DESIG_ID", MySqlDbType.Int32).Value = DESIGID;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void UpdateMail()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_UPDATE_MAIL";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_MAIL_ID", MySqlDbType.Int32).Value = this.MailId;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void UpdateCategory(Int32 CatID)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_UPDATE_CATEGORY";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_CategoryName", MySqlDbType.VarChar).Value = this.CategoryName;
                cmd.Parameters.Add("P_IsActive", MySqlDbType.VarChar).Value = this.IsActive;
                cmd.Parameters.Add("P_CAT_ID", MySqlDbType.Int32).Value = CatID;
                //cmd.Parameters.Add("P_RETURN", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void UpdateDepartment(Int32 DepID)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_UPDATE_DEPARTMENT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_DEPT_NAME", MySqlDbType.VarChar).Value = this.DepartmentName;
                cmd.Parameters.Add("P_DEP_ID", MySqlDbType.Int32).Value = DepID;
                //cmd.Parameters.Add("P_RETURN", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void UpdateDesignation(Int32 DESIGID)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_UPDATE_DESIGNATION";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_DESIG_NAME", MySqlDbType.VarChar).Value = this.DesignationName;
                cmd.Parameters.Add("P_DESIG_ID", MySqlDbType.Int32).Value = DESIGID;
                //cmd.Parameters.Add("P_RETURN", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void ReqForNewBook()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSERT_MAIL";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_CategoryName", MySqlDbType.VarChar).Value = this.EmpId;
                cmd.Parameters.Add("P_IsActive", MySqlDbType.VarChar).Value = this.BookName;
                cmd.Parameters.Add("P_IsActive", MySqlDbType.VarChar).Value = this.AuthorName;
                //cmd.Parameters.Add("P_RETURN", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void insertBook()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_INSRT_BOOK";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_BOOK_NAME", MySqlDbType.VarChar).Value = this.BookName;
                cmd.Parameters.Add("P_BAR_CODE", MySqlDbType.VarChar).Value = this.Barcode;
                cmd.Parameters.Add("P_AUTHOR_NAME", MySqlDbType.VarChar).Value = this.AuthorName;
                cmd.Parameters.Add("P_PURCHASE_DATE", MySqlDbType.Date).Value = this.PurchaseDate;
                cmd.Parameters.Add("P_BOOK_CAT_ID", MySqlDbType.Int32).Value = this.BookCatID;
                cmd.Parameters.Add("P_BOOK_PRICE", MySqlDbType.Int32).Value = this.PUrchaseRate;
                cmd.Parameters.Add("P_ISSUED_DAYS", MySqlDbType.Int32).Value = this.IssueDays;
                cmd.Parameters.Add("P_EXTEND_DAYS", MySqlDbType.Int32).Value = this.ExtendDays;
                cmd.Parameters.Add("P_EXTEND_TIME", MySqlDbType.Int32).Value = this.ExtendTime;
                cmd.Parameters.Add("P_NO_OF_COPIES", MySqlDbType.Int32).Value = this.NoofCopies;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void UpdateBook(Int32 BookID)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_UPDATE_BOOK";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_BOOK_NAME", MySqlDbType.VarChar).Value = this.BookName;
                cmd.Parameters.Add("P_BAR_CODE", MySqlDbType.VarChar).Value = this.Barcode;
                cmd.Parameters.Add("P_AUTHOR_NAME", MySqlDbType.VarChar).Value = this.AuthorName;
                cmd.Parameters.Add("P_PURCHASE_DATE", MySqlDbType.Date).Value = this.PurchaseDate;
                cmd.Parameters.Add("P_BOOK_CAT_ID", MySqlDbType.Int32).Value = this.BookCatID;
                cmd.Parameters.Add("P_BOOKID", MySqlDbType.Int32).Value = BookID;
                cmd.Parameters.Add("P_BOOK_PRICE", MySqlDbType.Int32).Value = this.PUrchaseRate;
                cmd.Parameters.Add("P_ISSUED_DAYS", MySqlDbType.Int32).Value = this.IssueDays;
                cmd.Parameters.Add("P_EXTEND_DAYS", MySqlDbType.Int32).Value = this.ExtendDays;
                cmd.Parameters.Add("P_EXTEND_TIME", MySqlDbType.Int32).Value = this.ExtendTime;
                cmd.Parameters.Add("P_NO_OF_COPIES", MySqlDbType.Int32).Value = this.NoofCopies;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

        }


        public DataSet GetBookList()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_ALL_BOOKS";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        public DataSet GetBookCat()
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_GET_CATEGORY";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("P_O", MySqlDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }



        public void DeleteBook(Int32 BOOKID)
        {
            using (MySqlConnection cn = new MySqlConnection(INTECH))
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                //cmd.InitialLONGFetchSize = 20000;
                cmd.CommandText = "PRC_DELETE_BOOK";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("P_BookID", MySqlDbType.Int32).Value = BOOKID;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
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
        
        #endregion
    }
}