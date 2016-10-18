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
    public partial class frmGetOnlineRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUser.Text = Session["USER_NAME"].ToString();
                lblRole.Text = Session["RoleName"].ToString();
               
                bindgrid();

            }
        }


        private void bindgrid()
        {
            cTransactionIssue objcTran = new cTransactionIssue();
            DataSet ds1 = new DataSet();
            ds1 = objcTran.GetOnlineBookReq();
            if (ds1.Tables[0].Rows.Count > 0)
            {
                gvAlredayIssued.DataSource = ds1;
                gvAlredayIssued.DataBind();
                DivAlreadyIssued.Visible = true;

            }
            else
            {
                lblMsg.Text = "No Request Available";
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
                if (e.CommandName == "SELECT")
                {
                    cTransactionIssue objcTran = new cTransactionIssue();

                    int rowIndex = Convert.ToInt32(e.CommandArgument);
                    string Issuetype = gvAlredayIssued.DataKeys[rowIndex].Values[1].ToString();

                    if (Issuetype == "NEW")
                    {
                        int rval;
                        objcTran.EmployeeId = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[2].ToString());
                        objcTran.BookID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[3].ToString());
                        objcTran.Barcode = gvAlredayIssued.DataKeys[rowIndex].Values[4].ToString();
                        objcTran.BookCatID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[0].ToString());
                        DateTime frmdate = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[5].ToString());
                        DateTime todate = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[6].ToString());
                        objcTran.FromIssuedDate = frmdate;
                        objcTran.ToIssuedDate = todate;
                        objcTran.Flag = 1;
                        objcTran.OnlineFlag = 1;
                        rval = objcTran.insertIssueBook();
                       
                        gvAlredayIssued.DataSource = null;
                        gvAlredayIssued.DataBind();
                        DataBind();
                        bindgrid();
                        
                        if (rval == 1)
                        {
                            Response.Write("<script>alert('Book Already Issued Can't Issue Book Again kindly Extend it');</script>");
                        }
                        else if (rval == 3)
                        {
                            Response.Write("<script>alert('Book Already Issued and Have fine kindly return book and Pay fine');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Sucessfully Issued');</script>");
                            
                        }

                    }
                    else if (Issuetype == "EXTEND")
                    {
                        int rval;
                        objcTran.EmployeeId = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[2].ToString());
                        objcTran.BookID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[3].ToString());
                        objcTran.Barcode = gvAlredayIssued.DataKeys[rowIndex].Values[4].ToString();
                        objcTran.BookCatID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[0].ToString());
                        DateTime frmdate = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[5].ToString());
                        DateTime todate = Convert.ToDateTime(gvAlredayIssued.DataKeys[rowIndex].Values[6].ToString());
                        objcTran.FromIssuedDate = frmdate;
                        objcTran.ToIssuedDate = todate;
                        objcTran.IssueID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[8].ToString());
                        objcTran.Flag = 2;
                        objcTran.OnlineFlag = 2;

                        rval = objcTran.insertIssueBook();
                        gvAlredayIssued.DataSource = null;
                        gvAlredayIssued.DataBind();
                        DataBind();
                        bindgrid();
                        if (rval == 1)
                        {
                            Response.Write("<script>alert('Book Already Issued Can't Issue Book Again kindly Extend it');</script>");
                        }
                        else if  (rval == 2)
                        {
                            Response.Write("<script>alert('YOU ARE ALRAEDY HAVING FINE ON THIS BOOK PLEASE RETURN THE BOOK AND PAY FINE');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Sucessfully Issued');</script>");
                        }


                    }

                }
                //else if (e.CommandName == "select")
                //{
                //    cTransactionIssue objcTran = new cTransactionIssue();
                //    int rowIndex = Convert.ToInt32(e.CommandArgument);
                //    objcTran.REQ_ID = Convert.ToInt32(gvAlredayIssued.DataKeys[rowIndex].Values[7].ToString());
                //    objcTran.RejectRequest();
                //    Response.Write("<script>alert('Sucessfully Reject');</script>");
                //    bindgrid();
                //}


            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('Error in Issue Book Issued');</script>");
                
            }
           

        }

        protected void gvAlredayIssued_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            cTransactionIssue objcTran = new cTransactionIssue();
            GridViewRow row = (GridViewRow)gvAlredayIssued.Rows[e.RowIndex];
            objcTran.REQ_ID = Convert.ToInt32(gvAlredayIssued.DataKeys[e.RowIndex].Values["REQ_ID"].ToString());
            objcTran.RejectRequest();
            Response.Write("<script>alert('Sucessfully Reject');</script>");
            bindgrid();


        }

        protected void gvAlredayIssued_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAlredayIssued.PageIndex = e.NewPageIndex;
            bindgrid();
        }

       
        

    }
}