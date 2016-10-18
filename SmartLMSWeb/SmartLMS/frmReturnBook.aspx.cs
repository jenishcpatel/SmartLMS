using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LibApp;

namespace SmartLMSWeb.SmartLMS
{
    public partial class frmReturnBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUser.Text = Session["USER_NAME"].ToString();
                lblRole.Text = Session["RoleName"].ToString();
                
            }
        }

        protected void btnEmp_Click(object sender, ImageClickEventArgs e)
        {
            cTransactionIssue objcTran = new cTransactionIssue();

            if (txtSearchEmp.Text.Length > 0)
            {
                objcTran.EmployeeId = Convert.ToInt32(txtSearchEmp.Text);
                Session["EMPID"] = txtSearchEmp.Text;

            }
            else
            {
                Response.Write("<script>alert('Kindly Enter the Employee Id');</script>");
                return;
            }

            DataSet ds = new DataSet();
            ds = objcTran.GetEmpList();
            gvDisplay.DataSource = ds;
            gvDisplay.DataBind();


            DataSet ds1 = new DataSet();
            ds1 = objcTran.GetIssuedEmpList();
            if (ds1.Tables[0].Rows.Count > 0)
            {
                gvAlredayIssued.DataSource = ds1;
                gvAlredayIssued.DataBind();
                DivAlreadyIssued.Visible = true;
            }


            DataSet ds2 = new DataSet();
            ds2 = objcTran.GetFineSummary();
            if (ds2.Tables[0].Rows.Count > 0)
            {
                gvFine.DataSource = ds2;
                gvFine.DataBind();
                divFine.Visible = true;

            }
            

           


        }

        protected void SaveAccountInfo_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                if (txtFineAmount.Text == "0" && txtRemarks.Text == "")
                {
                    Response.Write("<script>alert('Kindly Enter the Remarks');</script>");
                    return;
                }



                cTransactionIssue objcTran = new cTransactionIssue();
                objcTran.EmployeeId = Convert.ToInt32(Session["EMPID"].ToString());
                objcTran.BookID = Convert.ToInt32(Session["BookID"].ToString());
                objcTran.FinePaid = Convert.ToInt32(txtFineAmount.Text.ToString());
                objcTran.ReturnDate = DateTime.ParseExact(txtReturn.Value, "dd/MM/yyyy", null);
                objcTran.Remarks = txtRemarks.Text;
                objcTran.insertReturnBook();
                //DataSet ds1 = new DataSet();
                //ds1 = objcTran.GetIssuedEmpList();
                //if (ds1.Tables[0].Rows.Count > 0)
                //{
                //    gvAlredayIssued.DataSource = ds1;
                //    gvAlredayIssued.DataBind();
                //    DivAlreadyIssued.Visible = true;
                //}
                Response.Write("<script>alert('Book Returned Sucessfully');</script>");
                gvAlredayIssued.DataSource = null;
                gvAlredayIssued.DataBind();
                databindforall();
            }
            catch
            {
                Response.Write("<script>alert('Error in Book Returned');</script>");
            }
        }

        protected void gvAlredayIssued_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                cTransactionIssue objcTran = new cTransactionIssue();
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                Session["IssuedId"] = gvAlredayIssued.DataKeys[rowIndex].Values[0];
                Session["BookID"] = gvAlredayIssued.DataKeys[rowIndex].Values[1];
                DataSet ds2 = new DataSet();
                objcTran.EmployeeId = Convert.ToInt32(Session["EMPID"].ToString());
                ds2 = objcTran.GetFineSummary();
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    gvFine.DataSource = ds2;
                    txtReturn.Value = DateTime.Now.ToString("dd/MM/yyyy");
                    txtFineAmount.Text = (ds2.Tables[0].Rows[0]["fineAmount"].ToString());
                    txtReturn.Value = Convert.ToString(DateTime.Today.ToString("dd/MM/yyyy"));

                }
                else
                {
                    txtReturn.Value = DateTime.Now.ToString("dd/MM/yyyy");
                    txtFineAmount.Text = "0";
                }
            }
                
        }

        protected void lnkSingOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmLogin.aspx");
            Session["USER_NAME"] = "";
            Session["RoleName"] = "";
            Session["EmpId"] = "";
        }

        protected void gvAlredayIssued_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAlredayIssued.PageIndex = e.NewPageIndex;
            databindforall();
        }


        private void databind()
        {
            cTransactionIssue objcTran = new cTransactionIssue();
            DataSet ds1 = new DataSet();
            objcTran.EmployeeId=Convert.ToInt32(Session["EMPID"]);
            DataSet ds2 = new DataSet();
            ds2 = objcTran.GetFineSummaryAll();
            if (ds2.Tables[0].Rows.Count > 0)
            {
                gvFine.DataSource = ds2;
                gvFine.DataBind();
                divFine.Visible = true;

            }
        }


        private void databindforall()
        {
            cTransactionIssue objcTran = new cTransactionIssue();
            objcTran.EmployeeId = Convert.ToInt32(Session["EMPID"]);
            DataSet ds2 = new DataSet();
            ds2 = objcTran.GetIssuedEmpList();
            if (ds2.Tables[0].Rows.Count > 0)
            {
                gvAlredayIssued.DataSource = ds2;
                gvAlredayIssued.DataBind();
                DivAlreadyIssued.Visible = true;
            }
           
        }
    }
}