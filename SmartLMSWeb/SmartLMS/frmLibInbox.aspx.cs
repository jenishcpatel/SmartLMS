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
    public partial class frmLibInbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["USER_NAME"] != null && Session["RoleName"] != null)
                {
                    lblUser.Text = Session["USER_NAME"].ToString();
                    lblRole.Text = Session["RoleName"].ToString();
                    Maillist();
                }
                else
                {
                    Response.Redirect("~/SmartLMS/frmLogin.aspx");
                }
            }
        }

        private void Maillist()
        {
            try {
                csBook objbook = new csBook();
                DataSet ds = new DataSet();
                ds = objbook.GetMailList();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gvMail.DataSource = ds;
                    gvMail.DataBind();
                }
                else
                {
                    lblMsg.Text = "No Mail Available in the Inbox";
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void gvMail_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    csBook objbook = new csBook();
                    int rowIndex = Convert.ToInt32(e.CommandArgument);
                    objbook.MailId = Convert.ToInt32(gvMail.DataKeys[rowIndex].Values[0]);
                    objbook.UpdateMail();
                    gvMail.DataSource = null;
                    gvMail.DataBind();
                    Maillist();
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Error in Mail Delete');</script>");
            }
        }

        protected void lnkSingOut_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/SmartLMS/frmLogin.aspx");
                Session["USER_NAME"] = "";
                Session["RoleName"] = "";
                Session["EmpId"] = "";
            }
            catch (Exception ex) {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void gvMail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gvMail.PageIndex = e.NewPageIndex;
                Maillist();
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }
    }
}