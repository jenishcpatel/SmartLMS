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
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUserName.Focus();
            }
        }

        protected void btnlofin_Click(object sender, EventArgs e)
        {
            cLogin objlogin = new cLogin();
            if ( txtUserName.Text.Length < 1)
            {
                string Display = "Enter User Name";
                txtUserName.Focus();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);
                return;
            }

            if (txtPassword.Text.Length < 1)
            {
                string Display = "Enter Password";
                txtPassword.Focus();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);
                return;
            }

            DataSet ds = null;
            ds = new DataSet();
            objlogin.EmpId = Convert.ToInt32 (txtUserName.Text);
            objlogin.Password = txtPassword.Text;
            //objlogin.Role_ID = Convert.ToInt16(drpRole.SelectedValue.ToString());
            ds = objlogin.executedatatable();


            if (ds.Tables[0].Rows.Count > 0)
            {
                if ((ds.Tables[0].Rows[0]["ROLE"].ToString() == "Librarian,Employee,Admin"))
                {
                    
                if ((ds.Tables[0].Rows[0]["employee_id"].ToString() == txtUserName.Text) && (ds.Tables[0].Rows[0]["PASSWORD"].ToString() == txtPassword.Text.ToString()))
                {
                    Session["USER_NAME"] = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                    Session["Role"] = ds.Tables[0].Rows[0]["ROLE"].ToString();
                    Session["EMPLOYEEID"] = ds.Tables[0].Rows[0]["employee_id"].ToString();
                    Response.Redirect("~/SmartLMS/frmRoleSelection.aspx");

                }
                else
                {
                    string Display = "User Id /Password/Role is Incorrect";
                    txtUserName.Focus();
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);

                }
                }

                else if ((ds.Tables[0].Rows[0]["ROLE"].ToString() == "Librarian,Employee"))
                {

                    if ((ds.Tables[0].Rows[0]["employee_id"].ToString() == txtUserName.Text) && (ds.Tables[0].Rows[0]["PASSWORD"].ToString() == txtPassword.Text.ToString()))
                    {
                        Session["USER_NAME"] = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                        Session["Role"] = ds.Tables[0].Rows[0]["ROLE"].ToString();
                        Session["EMPLOYEEID"] = ds.Tables[0].Rows[0]["employee_id"].ToString();
                        Response.Redirect("~/SmartLMS/frmRoleSelection.aspx");

                    }
                    else
                    {
                        string Display = "User Id /Password/Role is Incorrect";
                        txtUserName.Focus();
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);

                    }
                }
                else if ((ds.Tables[0].Rows[0]["ROLE"].ToString() == "Employee,Admin"))
                {

                    if ((ds.Tables[0].Rows[0]["employee_id"].ToString() == txtUserName.Text) && (ds.Tables[0].Rows[0]["PASSWORD"].ToString() == txtPassword.Text.ToString()))
                    {
                        Session["Role"] = ds.Tables[0].Rows[0]["ROLE"].ToString();
                        Session["USER_NAME"] = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                        Session["EMPLOYEEID"] = ds.Tables[0].Rows[0]["employee_id"].ToString();
                        Response.Redirect("~/SmartLMS/frmRoleSelection.aspx");

                    }
                    else
                    {
                        string Display = "User Id /Password/Role is Incorrect";
                        txtUserName.Focus();
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);

                    }
                }

                else if ((ds.Tables[0].Rows[0]["ROLE"].ToString() == "Employee"))
                {
                     if ((ds.Tables[0].Rows[0]["employee_id"].ToString() == txtUserName.Text) && (ds.Tables[0].Rows[0]["PASSWORD"].ToString() == txtPassword.Text.ToString()))
                {
                    Session["USER_NAME"] = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                    Session["RoleName"] = ds.Tables[0].Rows[0]["ROLE"].ToString();
                    Session["EmpId"] = ds.Tables[0].Rows[0]["employee_id"].ToString();
                    Response.Redirect("~/SmartLMS/frmEmployeeDashboard.aspx");

                }



                else
                {
                    string Display = "User Id /Password/Role is Incorrect";
                    txtUserName.Focus();
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);

                }

                }

                else if ((ds.Tables[0].Rows[0]["ROLE"].ToString() == "Admin"))
                {
                    if ((ds.Tables[0].Rows[0]["employee_id"].ToString() == txtUserName.Text) && (ds.Tables[0].Rows[0]["PASSWORD"].ToString() == txtPassword.Text.ToString()))
                    {
                        Session["USER_NAME"] = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                        Session["Role"] = ds.Tables[0].Rows[0]["ROLE"].ToString();
                        Session["EMPLOYEEID"] = ds.Tables[0].Rows[0]["employee_id"].ToString();
                        Response.Redirect("~/SmartLMS/frmRoleSelection.aspx");

                    }



                    else
                    {
                        string Display = "User Id /Password/Role is Incorrect";
                        txtUserName.Focus();
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);

                    }

                }

                else if ((ds.Tables[0].Rows[0]["ROLE"].ToString() == "Librarian"))
                {
                    if ((ds.Tables[0].Rows[0]["employee_id"].ToString() == txtUserName.Text) && (ds.Tables[0].Rows[0]["PASSWORD"].ToString() == txtPassword.Text.ToString()))
                    {
                        Session["USER_NAME"] = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                        Session["Role"] = ds.Tables[0].Rows[0]["ROLE"].ToString();
                        Session["EMPLOYEEID"] = ds.Tables[0].Rows[0]["employee_id"].ToString();
                        Response.Redirect("~/SmartLMS/frmLibrarianDashboard.aspx");

                    }



                    else
                    {
                        string Display = "User Id /Password/Role is Incorrect";
                        txtUserName.Focus();
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);

                    }

                }


            }
            else
            {
                string Display = "User Id /Password/Role is Incorrect";
                txtUserName.Focus();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Display + "');", true);

            }

        }

        
    }
}