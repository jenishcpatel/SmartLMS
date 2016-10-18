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
    public partial class frmEmployeeDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUser.Text = Session["USER_NAME"].ToString();
                lblRole.Text = Session["RoleName"].ToString();

                //bindgrid();
                filltext();
                fillregejectMessage();


            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session["EmpLogin"] = "EmpLogin";
            Response.Redirect("~/SmartLMS/frmUserCreation.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmRequestForBook.aspx");
        }

        //private void bindgrid()
        //{
        //    cLogin objcTran = new cLogin();
        //    DataSet ds1 = new DataSet();
        //    objcTran.EmpId = Convert.ToInt32(Session["EmpId"].ToString());
        //    ds1 = objcTran.GetIssuedEmpList();
        //    if (ds1.Tables[0].Rows.Count > 0)
        //    {
        //        gvAlredayIssued.DataSource = ds1;
        //        gvAlredayIssued.DataBind();
                
        //    }
        //}


        private void filltext()
        {
            cLogin objcTran = new cLogin();
            DataSet ds1 = new DataSet();
            objcTran.EmpId = Convert.ToInt32(Session["EmpId"].ToString());
            ds1 = objcTran.GETEMPCOUNT();
            if (ds1.Tables[0].Rows.Count > 0)
            {
                lblIssuedBook.Text = ds1.Tables[0].Rows[0]["TotalBookIssued"].ToString();
                lblReturnedBook.Text = ds1.Tables[0].Rows[0]["TotalBookReturn"].ToString();
                lblFine.Text = ds1.Tables[0].Rows[0]["FINEAMOUNT"].ToString();

            }

        }


        private void fillregejectMessage()
        {
            cLogin objcTran = new cLogin();
            DataSet ds1 = new DataSet();
            objcTran.EmpId = Convert.ToInt32(Session["EmpId"].ToString());
            //ds1 = objcTran.RejectMessage();
            //if (ds1.Tables[0].Rows.Count > 0)
            //{
            //    lblRejectBook.Text = ds1.Tables[0].Rows[0]["Message"].ToString();
            //}
        }

        protected void lnkSingOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmLogin.aspx");
            Session["USER_NAME"] = "";
            Session["RoleName"] = "";
            Session["EmpId"] = "";
            Session["EmpLogin"] = "";
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmSearchBook.aspx");
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmOnlineBookIssue.aspx");
        }
    }
}