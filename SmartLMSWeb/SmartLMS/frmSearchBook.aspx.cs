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
    public partial class frmSearchBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["USER_NAME"] != null && Session["RoleName"] != null)
                {
                    lblUser.Text = Session["USER_NAME"].ToString();
                    lblRole.Text = Session["RoleName"].ToString();
                    getallbooks();
                }
                else {
                    Response.Redirect("~/SmartLMS/frmLogin.aspx");
                }
            }
        }

        protected void btnBook_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                cEmployee objcemp = new cEmployee();
                if (txtBarcode.Text.Length > 0)
                {
                    objcemp.BARCODE = txtBarcode.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Barcode Number/Book Name');</script>");
                    return;
                }

                DataSet ds = new DataSet();
                ds = objcemp.GetBookDetails();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    gvBookList.DataSource = ds;
                    gvBookList.DataBind();

                }
                else
                {
                    Response.Write("<script>alert('This Barcode does not exist, kindly check the Barcode/Book Name');</script>");
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

        private void getallbooks()
        {
            try {
            cEmployee objcemp = new cEmployee();
            DataSet ds = new DataSet();
            ds = objcemp.GetALLBookDetails();

            if (ds.Tables[0].Rows.Count > 0)
            {
                gvBookList.DataSource = ds;
                gvBookList.DataBind();

            }
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void gvBookList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try { 
            gvBookList.PageIndex = e.NewPageIndex;
            getallbooks();
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }
    }
}