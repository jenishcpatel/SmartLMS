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
    public partial class frmRequestForBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUser.Text = Session["USER_NAME"].ToString();
                lblRole.Text = Session["RoleName"].ToString();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {



                csBook objbook = new csBook();


                if (txtBookName.Text.Length < 1)
                {
                    Response.Write("<script>alert('Kindly Enter the book name ');</script>");
                    return;
                }

                if (txtAuthorname.Text.Length < 1)
                {
                    Response.Write("<script>alert('Kindly Enter the Author name ');</script>");
                    return;
                }


                objbook.EmpId = Convert.ToInt32(Session["EMPLOYEEID"].ToString()); 

                if (txtBookName.Text.Length > 0)
                {
                    objbook.BookName = txtBookName.Text;

                }
                else
                {
                    objbook.BookName = "";

                }

                if (txtAuthorname.Text.Length > 0)
                {
                    objbook.AuthorName = txtAuthorname.Text;
                }
                else
                {
                    objbook.AuthorName = "";
                }

                objbook.ReqForNewBook();
                Response.Write("<script>alert('Request Sent');</script>");


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error');</script>");

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