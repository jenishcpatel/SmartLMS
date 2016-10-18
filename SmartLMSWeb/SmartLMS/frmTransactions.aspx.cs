using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibApp;
using System.Data;


namespace SmartLMSWeb.SmartLMS
{
    public partial class frmTransactions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUser.Text = Session["USER_NAME"].ToString();
                lblRole.Text = Session["RoleName"].ToString();
                txtIssuedTo.Disabled = true;
                txtIssuedFrom.Disabled = true;
                btnBook.Enabled = false;

            }
        }

        

        protected void btnEmp_Click(object sender, ImageClickEventArgs e)
        {
            cTransactionIssue objcTran = new cTransactionIssue();

            if (txtSearchEmp.Text.Length > 0)
            {
                objcTran.EmployeeId = Convert.ToInt32(txtSearchEmp.Text);

            }
            else
            {
                Response.Write("<script>alert('Kindly Enter the Employee Id');</script>");
                return;
            }

            DataSet ds = new DataSet();
            ds = objcTran.GetEmpData();
            gvDisplay.DataSource = ds;
            gvDisplay.DataBind();

            if (gvDisplay.Rows.Count > 0)
            {
                Session["EMPID"] = gvDisplay.Rows[0].Cells[0].Text;
                btnBook.Enabled = true;


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
                txtBarcode.Enabled = false;
                txtIssuedFrom.Disabled = true;
                txtIssuedTo.Disabled = true;
                SaveAccountInfo.Enabled = false;
                return;

            }
                

        }

       

        protected void btnBook_Click(object sender, ImageClickEventArgs e)
        {
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
                    Response.Write("<script>alert('This Book is Already Issued to Some Other Employee, Kindly Contact after some time');</script>");
                    SaveAccountInfo.Enabled = false;
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
                    Session["BookID"] = ds.Tables[0].Rows[0][2].ToString();
                    Session["BOOKCATID"] = ds.Tables[0].Rows[0][5].ToString();


                }
            }
            else
            {
                Response.Write("<script>alert('This Barcode does not exist, kindly check the Barcode');</script>");
            }
        }

        protected void SaveAccountInfo_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (txtSearchEmp.Text == "")
                {
                    Response.Write("<script>alert('Kindly enter EmployeeCode');</script>");
                    return;
                }
                if (txtBarcode.Text == "")
                {
                    Response.Write("<script>alert('Kindly enter Barcode');</script>");
                    return;
                }

                int rval;
                cTransactionIssue objcTran = new cTransactionIssue();
                objcTran.EmployeeId = Convert.ToInt32(Session["EMPID"]);
                objcTran.BookID = Convert.ToInt32(Session["BookID"]);
                objcTran.Barcode = txtBarcode.Text;
                objcTran.BookCatID = Convert.ToInt32(Session["BOOKCATID"]);
                objcTran.FromIssuedDate = DateTime.ParseExact(txtIssuedFrom.Value, "dd/MM/yyyy", null);
                objcTran.ToIssuedDate = DateTime.ParseExact(txtIssuedTo.Value, "dd/MM/yyyy", null);
                objcTran.Flag = 1;
                rval=objcTran.insertIssueBook();
                if (rval == 1)
                {
                    Response.Write("<script>alert('Book Already Issued Can't Issue Book Again kindly Extend it');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Sucessfully Issued');</script>");
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
            catch
            {
                Response.Write("<script>alert('Error in Issue Book Issued');</script>");
            }

        }

        protected void gvAlredayIssued_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                cTransactionIssue objcTran = new cTransactionIssue();
                int rowIndex = Convert.ToInt32(e.CommandArgument);
               
                objcTran.IssueID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[0]);

                string  fromdate = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[1]).ToString("dd/MM/yyyy");
                string todate =Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[2]).ToString("dd/MM/yyyy");
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
                    int ExtendValue=0;
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        ExtendValue = Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString());
                        Session["EXTVAL"] = ExtendValue;

                    }
                    else
                    {
                        Session["EXTVAL"] = 0;
                    }
                   // ExtendValue = Convert.ToInt32(ds2.Tables[0].Rows[0][0].ToString());
                                     

                    int bookextend=Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[3]);
                    int EXTVAL = Convert.ToInt32(Session["EXTVAL"].ToString());

                    if (bookextend == EXTVAL)
                    {
                        Response.Write("<script>alert('Book Cant Extended, Extended Time Exceed');</script>");
                        
                    }

                    else
                    {
                        objcTran.Flag = 2;
                        int extdays = 0;
                        int rval;
                        DateTime to_date;
                        int days = 1;
                        string ExtFromDate;
                        string ExtTodate;
                        objcTran.EmployeeId = Convert.ToInt32(Session["EMPID"]);
                        extdays = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[4]);
                        to_date = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[2].ToString());
                        ExtFromDate = to_date.AddDays(days).ToString("dd/MM/yyyyy");
                        ExtTodate = to_date.AddDays(extdays).ToString("dd/MM/yyyyy");
                        objcTran.FromIssuedDate = Convert.ToDateTime(ExtFromDate);
                        objcTran.ToIssuedDate = Convert.ToDateTime(ExtTodate);
                        rval = objcTran.insertIssueBook();

                        if (rval == 3)
                        {
                            Response.Write("<script>alert('YOU ARE ALRAEDY HAVING FINE ON THIS BOOK PLEASE RETURN THE BOOK AND PAY FINE');</script>");
                        }
                       else
                        {
                            Response.Write("<script>alert('Book Issue Extended');</script>");
                        }



                        DataSet ds1 = new DataSet();
                        ds1 = objcTran.GetIssuedEmpList();
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            gvAlredayIssued.DataSource = ds1;
                            gvAlredayIssued.DataBind();




                        }

                      
                       
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Error in Issue Book Issued');</script>");
            }
           
        }

        protected void lnkSingOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmLogin.aspx");
            Session["USER_NAME"] = "";
            Session["RoleName"] = "";
            Session["EmpId"] = "";
        }
    }
}