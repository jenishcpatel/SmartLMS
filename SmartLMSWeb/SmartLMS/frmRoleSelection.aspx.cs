using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibApp;
using System.Data;

namespace SmartLMSWeb.SmartLMS
{
    public partial class frmRoleSelection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string str = Session["Role"].ToString();
                //Declare a arraylist for getting comma separated string
                ArrayList arr = new ArrayList();
                //check wether the re is comma in the end of the string
                if (str.Trim().EndsWith(","))
                {
                    str = str.Substring(0, str.Length - 1);
                }
                //split the comma separated string into arraylist
                arr.AddRange(str.Split(','));
                //loop through the arraylist items & add the item to Dropdownlist
                for (int i = 0; i < arr.Count; i++)
                {
                    drpRole.Items.Insert(i, new ListItem(arr[i].ToString(), (i + 1).ToString()));
                }

                               
            }
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            Session["EmpId"] = Session["USER_NAME"].ToString();
            if (drpRole.SelectedItem.Text == "Employee")
            {
                Session["RoleName"] = "Employee";
                Session["EMPID"] = Session["EMPLOYEEID"].ToString();
                Response.Redirect("~/SmartLMS/frmEmployeeDashboard.aspx");
               
            }

            else if (drpRole.SelectedItem.Text == "Librarian")
            {
               
                Session["RoleKey"] = "1";
                Session["RoleName"] = "Librarian";
                Session["EMPID"] = Session["EMPLOYEEID"].ToString();
                Response.Redirect("~/SmartLMS/frmLibrarianDashboard.aspx");
            }

            else if (drpRole.SelectedItem.Text == "Admin")
            {
               
                Session["RoleKey"] = "2";
                Session["RoleName"] = "Admin";
                Session["EMPID"] = Session["EMPLOYEEID"].ToString();
                Response.Redirect("~/SmartLMS/frmDashBoard.aspx");
            }
        }

       
    }
}