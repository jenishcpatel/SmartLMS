using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibApp;
using System.Data;

namespace SmartLMS.SmartLMS
{
    public partial class frmOnlineBookIssue : System.Web.UI.Page
    {
        int RVALUE;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["USER_NAME"] != null && Session["RoleName"] != null)
                {
                    lblUser.Text = Session["USER_NAME"].ToString();
                    lblRole.Text = Session["RoleName"].ToString();
                    txtIssuedTo.Disabled = true;
                    txtIssuedFrom.Disabled = true;
                    bindgrid();
                }
                else
                {
                    Response.Redirect("~/SmartLMS/frmLogin.aspx");
                }
            }
        }

        private void bindgrid()
        {
            try { 
            cTransactionIssue objcTran = new cTransactionIssue();
            objcTran.EmployeeId = Convert.ToInt32(Session["EmpId"].ToString());
            DataSet ds1 = new DataSet();
            ds1 = objcTran.GetIssuedEmpList();
            if (ds1.Tables[0].Rows.Count > 0)
            {
                gvAlredayIssued.DataSource = ds1;
                gvAlredayIssued.DataBind();
                DivAlreadyIssued.Visible = true;
            }
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void lnkSingOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmLogin.aspx");
            Session["USER_NAME"] = "";
            Session["RoleName"] = "";
            Session["EmpId"] = "";
        }

        protected void gvAlredayIssued_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                cTransactionIssue objcTran = new cTransactionIssue();
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                objcTran.IssueID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[0]);
                string fromdate = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[1]).ToString("dd/MM/yyyy");
                string todate = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[2]).ToString("dd/MM/yyyy");
                string currentdate = Convert.ToDateTime(System.DateTime.Now).ToString("dd/MM/yyyy");
                if (DateTime.ParseExact(fromdate, "dd/MM/yyyy", null) >= DateTime.ParseExact(currentdate, "dd/MM/yyyy", null) && DateTime.ParseExact(todate, "dd/MM/yyyy", null) >= DateTime.ParseExact(currentdate, "dd/MM/yyyy", null))
                {
                    Response.Write("<script>alert('Book Already Issued, Kindly Extend when time period is Over');</script>");
                }
                else
                {
                    cTransactionIssue objcTran1 = new cTransactionIssue();
                    DataSet ds2 = new DataSet();
                    objcTran1.IssueID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[0]);
                    ds2 = objcTran1.GetExtendedBookCount();
                   Session["EXTVAL"] =ds2.Tables[0].Rows.Count > 0? Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString()):0;
                    // ExtendValue = Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString());
                    int bookextend = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[3]);
                    int EXTVAL = Convert.ToInt32(Session["EXTVAL"].ToString());
                    if (bookextend == EXTVAL)
                    {
                        Response.Write("<script>alert('Book Cant Extended, Extended Time Exceed');</script>");
                    }
                    else
                    {
                        cTransactionIssue objcTran2 = new cTransactionIssue();
                        objcTran2.EmployeeId = Convert.ToInt32(Session["EmpId"].ToString());
                        objcTran2.Barcode = gvAlredayIssued.DataKeys[rowIndex].Values[5].ToString();
                        int extdays = 0;
                        DateTime to_date;
                        int days = 1;
                        string ExtFromDate;
                        string ExtTodate;
                        extdays = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[4]);
                        to_date = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[2].ToString());
                        ExtFromDate = to_date.AddDays(days).ToString("dd/MM/yyyyy");
                        ExtTodate = to_date.AddDays(extdays).ToString("dd/MM/yyyyy");
                        objcTran2.FromIssuedDate = Convert.ToDateTime(ExtFromDate);
                        objcTran2.ToIssuedDate = Convert.ToDateTime(ExtTodate);
                        objcTran2.BookID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[6]);
                        objcTran2.BookCatID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[7]);
                        objcTran2.Flag = 1;
                        int fissueid = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[0]);
                        objcTran2.IssueID = fissueid > 0?fissueid:0;
                        int RVALUE=objcTran2.insertOnlineBookRequest();
                        if (RVALUE == 1)
                        {
                            Response.Write("<script>alert('Request for Book Issue Extended Already Sent.');</script>");
                        }
                        else if (RVALUE == 3)
                        {
                            Response.Write("<script>alert('CAN NOT EXTEND,YOU ARE ALRAEDY HAVING FINE ON THIS BOOK PLEASE RETURN THE BOOK AND PAY FINE');</script>");
                        }
                        else 
                        {
                            Response.Write("<script>alert('Request for Book Issue Extended Sent to librarian sucessfully.');</script>");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Error in Issue Book Issued');</script>");
            }
        }

        protected void SaveAccountInfo_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (txtBarcode.Text == "")
                {
                    Response.Write("<script>alert('Kindly enter Barcode');</script>");
                    return;
                }
                cTransactionIssue objcTran = new cTransactionIssue();
                DataSet ds = new DataSet();
                objcTran.EmployeeId = Convert.ToInt32(Session["EMPID"]);
                ds = objcTran.GetEmpData();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int rval;
                    objcTran.EmployeeId = Convert.ToInt32(Session["EMPID"]);
                    objcTran.BookID = Convert.ToInt32(Session["BookID"]);
                    objcTran.Barcode = txtBarcode.Text;
                    objcTran.BookCatID = Convert.ToInt32(Session["BOOKCATID"]);
                    objcTran.FromIssuedDate = DateTime.ParseExact(txtIssuedFrom.Value, "dd/MM/yyyy", null);
                    objcTran.ToIssuedDate = DateTime.ParseExact(txtIssuedTo.Value, "dd/MM/yyyy", null);
                    objcTran.Flag = 2;
                    objcTran.IssueID = 0;
                    rval = objcTran.insertOnlineBookRequest();
                    if (rval == 1)
                    {
                        Response.Write("<script>alert('Request for Book Issue Already Sent');</script>");
                    }
                    else if (rval == 4)
                    {
                        Response.Write("<script>alert('You Already Sent the Request for this book');</script>");
                    }
                    else if (rval == 5)
                    {
                        Response.Write("<script>alert('kindly Submit your Deposite');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('New Book Issue Request Sucessfully Sent');</script>");
                    }
                    DataSet ds1 = new DataSet();
                    ds1 = objcTran.GetIssuedEmpList();
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        gvAlredayIssued.DataSource = ds1;
                        gvAlredayIssued.DataBind();
                        DivAlreadyIssued.Visible = true;
                    }
                }
                else
                {
                    Response.Write("<script>alert('Kindly Submit Your Deposite');</script>");
                    return;
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Error in Issue Book Issued');</script>");
            }
        }

        protected void btnBook_Click(object sender, ImageClickEventArgs e)
        {
            try { 
            cTransactionIssue objcTran = new cTransactionIssue();
            if (txtBarcode.Text.Length > 0)
            {
                objcTran.Barcode = txtBarcode.Text;
            }
            else
            {
                Response.Write("<script>alert('Kindly Enter the Barcode Number');</script>");
                return;
            }
            DataSet ds = new DataSet();
            ds = objcTran.GetBookListBarcode();
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    Response.Write("<script>alert('All the BOOKS was Already Issued to Some Other Employee, Kindly Contact after some time/You Enter Wrong Details');</script>");
                    return;
                }
                else
                {
                    int days = 0;
                    days = Convert.ToInt32(ds.Tables[0].Rows[0]["issued_days"].ToString());
                    gvBookList.DataSource = ds;
                    gvBookList.DataBind();
                    txtIssuedFrom.Value = DateTime.Today.ToString("dd/MM/yyyy");
                    txtIssuedTo.Value = DateTime.Today.AddDays(days).ToString("dd/MM/yyyy");
                    Session["BookID"] = ds.Tables[0].Rows[0]["BOOK_ID"].ToString();
                    Session["BOOKCATID"] = ds.Tables[0].Rows[0]["book_cat_id"].ToString();
                }
            }
            else
            {
                Response.Write("<script>alert('This Barcode does not exist, kindly check the Barcode');</script>");
            }
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }
    }
}