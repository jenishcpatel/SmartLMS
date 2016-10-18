using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartLMSWeb.usercontrol
{
    public partial class left : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleName"].ToString() == "Employee")
            {
                divVisible.Visible = false;
                divEmp.Visible = true;
                divLibVisible.Visible = false;
            }

            else if (Session["RoleName"].ToString() == "Librarian")
            {
                divVisible.Visible = false;
                divLibVisible.Visible = true;
                divEmp.Visible = false;
            }
            else if (Session["RoleName"].ToString() == "Admin")
            {
                divVisible.Visible = true;
                divLibVisible.Visible = false;
                divEmp.Visible = false;
            }
        }
    }
}