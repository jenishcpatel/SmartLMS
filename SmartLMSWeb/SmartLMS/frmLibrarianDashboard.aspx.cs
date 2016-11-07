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
    public partial class frmLibrarianDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER_NAME"] != null && Session["RoleName"] != null)
            {
                lblUser.Text = Session["USER_NAME"].ToString();
                lblRole.Text = Session["RoleName"].ToString();
                getDashBoardCount();
                getcountMail();
            }
            else
            {
                Response.Redirect("~/SmartLMS/frmLogin.aspx");
            }
        }

        private void getDashBoardCount()
        {
            try { 
            csBook objbook = new csBook();
            DataSet ds = new DataSet();
            ds = objbook.GetDashBoardCount();
            lblBookIssued.Text = ds.Tables[0].Rows[0]["TotalBookIssued"].ToString();
            lblReturnBook.Text = ds.Tables[0].Rows[0]["TotalBookReturn"].ToString();
            lblFine.Text = ds.Tables[0].Rows[0]["FINEAMOUNT"].ToString();
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
        private void getcountMail()
        {
            try { 
            csBook objbook = new csBook();
            DataSet ds = new DataSet();
            ds = objbook.GetMailCount();
            lblMail.Text = ds.Tables[0].Rows[0]["COUNTMAIL"].ToString();
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmGetOnlineRequest.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmLibInbox.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmAddCategory.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmBookEntry.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmTransactions.aspx");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmReturnBook.aspx");
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmReport.aspx");
        }
    }
}