﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibApp;
using System.Data;

namespace SmartLMSWeb.SmartLMS
{
    public partial class frmReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUser.Text = Session["USER_NAME"].ToString();
                lblRole.Text = Session["RoleName"].ToString();
                if (Session["RoleName"].ToString() == "Librarian")
                {
                    btnListActivePaidUser.Visible = false;
                }
            }
        }

        protected void btnFineCol_Click(object sender, EventArgs e)
        {
            if (txtfrom.Value == "" || txtTo.Value == "")
            {
                Response.Write("<script>alert('Enter the From Date & To Date');</script>");
                return;
            }
            Session["FromDate"] = txtfrom.Value;
            Session["ToDate"] = txtTo.Value;
            Session["Key"] = "4";
            Response.Redirect("~/RDLC/frmReportViewer.aspx");
        }

        protected void btnListActivePaidUser_Click(object sender, EventArgs e)
        {
            if (txtfrom.Value=="" || txtTo.Value=="")
            {
                Response.Write("<script>alert('Enter the From Date & To Date');</script>");
                return;
            }
            //DateTime dtfrom;
            //DateTime dtTo;

            //dtfrom = Convert.ToDateTime(txtfrom.Value);
            //dtTo = Convert.ToDateTime(txtTo.Value);

            //string  dt = dtfrom.ToString("dd/MM/yyyy");
            //Session["FromDate"] = dtfrom.ToString("dd/MM/yyyy");
            //Session["ToDate"] = dtTo.ToString("dd/MM/yyyy");

            Session["FromDate"] = txtfrom.Value;
            Session["ToDate"] = txtTo.Value;
            Session["Key"] = "1";
            Response.Redirect("~/RDLC/frmReportViewer.aspx");
        }

        protected void lnkSingOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmLogin.aspx");
            Session["USER_NAME"] = "";
            Session["RoleName"] = "";
            Session["EmpId"] = "";
        }

        protected void btnBookIssued_Click(object sender, EventArgs e)
        {
            if (txtfrom.Value == "" || txtTo.Value == "")
            {
                Response.Write("<script>alert('Enter the From Date & To Date');</script>");
                return;
            }
            Session["FromDate"] = txtfrom.Value;
            Session["ToDate"] = txtTo.Value;
            Session["Key"] = "2";
            string url = "~/RDLC/frmReportViewer.aspx";
            Response.Redirect(url);
        }

        protected void btnreturn_Click(object sender, EventArgs e)
        {
            if (txtfrom.Value == "" || txtTo.Value == "")
            {
                Response.Write("<script>alert('Enter the From Date & To Date');</script>");
                return;
            }
            Session["FromDate"] = txtfrom.Value;
            Session["ToDate"] = txtTo.Value;
            Session["Key"] = "3";
            Response.Redirect("~/RDLC/frmReportViewer.aspx");
        }
    }
}