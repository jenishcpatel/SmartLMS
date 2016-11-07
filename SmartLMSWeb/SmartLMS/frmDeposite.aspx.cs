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
    public partial class frmDeposite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["USER_NAME"] == null && Session["RoleName"] == null)
                {
                    Response.Redirect("~/SmartLMS/frmLogin.aspx");
                }

            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                cDeposite objcdeposite = new cDeposite();

                if (txtSearchEmp.Text.Length > 0)
                {
                    objcdeposite.EmployeeId = Convert.ToInt32(txtSearchEmp.Text);
                    Session["EMPID"] = objcdeposite.EmployeeId;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Employee Id');</script>");
                    return;
                }
                DataSet ds = new DataSet();
                ds = objcdeposite.GetEmpList();
                gvDisplay.DataSource = ds;
                gvDisplay.DataBind();
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void SaveAccountInfo_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                cDeposite objcdeposite = new cDeposite();
                objcdeposite.EmployeeId = Convert.ToInt32(Session["EMPID"].ToString());
                if (txtDepositeAmt.Text.Length > 0)
                {
                    objcdeposite.DepositeAmount = Convert.ToInt32(txtDepositeAmt.Text);
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Deposite Amounnt');</script>");
                    return;
                }

                if (txtDepositeDate.Value.Length > 0)
                {
                    objcdeposite.DepositeDate = Convert.ToDateTime(txtDepositeDate.Value);
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Deposite Date');</script>");
                    return;
                }

                objcdeposite.UpdateDeposite();
                Response.Write("<script>alert('Deposited Sucessfully');</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Insert Unsucessfull');</script>");
                return;
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