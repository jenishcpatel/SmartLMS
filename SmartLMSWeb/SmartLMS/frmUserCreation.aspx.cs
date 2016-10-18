using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibApp;
using System.Data;
using System.Net.Mail;


namespace SmartLMSWeb.SmartLMS
{
    public partial class frmUserCreation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               

                lblUser.Text = Session["USER_NAME"].ToString();
                lblRole.Text = Session["RoleName"].ToString();

                if (Session["EmpLogin"].ToString() == "EmpLogin")
                {
                    fillDepartment();
                    fillDesignation();

                    rdbList.SelectedValue = "1";
                    btnSearch.Visible = false;
                    lblPassword.Text = "New Password:";
                    rdbList.Enabled = false;
                    Session["RdbRole"] = "UpdateUser";
                    txtUserName.Enabled = false;
                    btnSave.Text = "Update";

                    rdbCheckFreeUser.Enabled = false;
                    rdbCheckPaidUser.Enabled = false;
                    chkIsper.Enabled = false;
                    txtMobile.Enabled = false;
                    txtEmail.Enabled = false;
                    txtDOJ.Disabled = true;
                    txtDOR.Disabled = true;
                    txtFirstName.Enabled = false;
                    txtLastname.Enabled = false;

                    drpDepartment.Enabled = false;
                    drpDesignation.Enabled = false;


                    cLogin objlogin = new cLogin();
                    DataSet ds = null;
                    ds = new DataSet();
                    objlogin.EmpId = Convert.ToInt32(Session["EMPID"].ToString());
                    ds = objlogin.GetUserData();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEmployeeId.Enabled = false;
                        txtEmployeeId.Text = Session["EMPID"].ToString();
                        txtUserName.Text = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                        txtFirstName.Text = ds.Tables[0].Rows[0]["FIRST_NAME"].ToString();
                        txtLastname.Text = ds.Tables[0].Rows[0]["LAST_NAME"].ToString();


                        if (ds.Tables[0].Rows[0]["JOINING_DATE"].ToString() == "")
                        {
                            txtDOJ.Value = "";
                        }
                        else
                        {
                            DateTime dtjoing = Convert.ToDateTime(ds.Tables[0].Rows[0]["JOINING_DATE"].ToString());
                            txtDOJ.Value = dtjoing.ToString("dd/MM/yyyy");
                        }


                        
                        if (ds.Tables[0].Rows[0]["RELEVING_DATE"].ToString() == "")
                        {
                            txtDOR.Value = "";
                        }
                        else
                        {
                            DateTime dtreleving = Convert.ToDateTime(ds.Tables[0].Rows[0]["RELEVING_DATE"].ToString());
                            txtDOR.Value = dtreleving.ToString("dd/MM/yyyy");
                        }





                        //DateTime dtjoing = Convert.ToDateTime(ds.Tables[0].Rows[0]["JOINING_DATE"].ToString());
                        //DateTime dtreleving = Convert.ToDateTime(ds.Tables[0].Rows[0]["RELEVING_DATE"].ToString());
                        //txtDOJ.Value = dtjoing.ToString("dd/MM/yyyy");
                        
                        drpDepartment.SelectedValue = ds.Tables[0].Rows[0]["DEPARTMENT_ID"].ToString();
                        drpDesignation.SelectedValue = ds.Tables[0].Rows[0]["DESIGNATION_ID"].ToString();
                        txtMobile.Text = ds.Tables[0].Rows[0]["MOBILE_NO"].ToString();
                        txtEmail.Text = ds.Tables[0].Rows[0]["EMAIL"].ToString();

                        string[] abcd;

                        abcd = ds.Tables[0].Rows[0]["ROLE"].ToString().Split(',');

                        for (int i = 0; i < abcd.Length; i++)
                        {
                            foreach (ListItem lists1 in chkIsper.Items)
                            {
                                if (Convert.ToString(lists1.Text.ToString().Trim()) == abcd[i].Trim().ToString())
                                {
                                    lists1.Selected = true;

                                }

                            }

                        }


                        if (ds.Tables[0].Rows[0]["IS_PAID_USER"].ToString() == "Y")
                        {
                            rdbCheckPaidUser.Checked = true;
                        }
                        else if (ds.Tables[0].Rows[0]["IS_FREE_USER"].ToString() == "Y")
                        {
                            rdbCheckFreeUser.Checked = true;
                        }

                        

                    }
                    Session["EmpLogin"] = "";
                }
                else
                {

                    btnSearch.Visible = false;
                    btnSave.Text = "Submit";
                    fillDepartment();
                    fillDesignation();
                    rdbList.SelectedValue = "0";
                    Session["RdbRole"] = "CreateUser";
                }

            }

        }


        #region "Drop Down To bind the Department & Designation"
        private void fillDepartment()
        {
            cEmployee objemp = new cEmployee();
            DataSet ds = new DataSet();
            ds = objemp.GetDepartment();
            drpDepartment.DataSource = ds.Tables[0];
            drpDepartment.DataTextField = "DEPART_NAME";
            drpDepartment.DataValueField = "DEPART_ID";
            drpDepartment.DataBind();

        }
        private void fillDesignation()
        {
            cEmployee objemp = new cEmployee();
            DataSet ds = new DataSet();
            ds = objemp.GetDesignation();
            drpDesignation.DataSource = ds.Tables[0];
            drpDesignation.DataTextField = "DESIG_NAME";
            drpDesignation.DataValueField = "DESIG_ID";
            drpDesignation.DataBind();

        }
        #endregion

        protected void lnkSingOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SmartLMS/frmLogin.aspx");
            Session["USER_NAME"] = "";
            Session["RoleName"] = "";
            Session["EmpId"] = "";
            Session["EmpLogin"] = "";
            Session.Clear();
        }

        protected void rdbList_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (rdbList.SelectedValue == "0")
            {
                txtUserName.Enabled = true;
                lblPassword.Text = "Password:";
                Session["RdbRole"] = "CreateUser";
                txtUserName.Enabled = true;
                txtEmployeeId.Enabled = true;
                btnSearch.Visible = false;
                btnSave.Text = "Submit";
                
                clear();

            }
            else if (rdbList.SelectedValue == "1")
            {
                btnSearch.Visible = true;
                lblPassword.Text = "New Password:";
                Session["RdbRole"] = "UpdateUser";
                txtUserName.Enabled = false;
                btnSave.Text = "Update";

            }

        }
             

        private void clear()
        {
            txtCPassword.Text = "";
            txtDOJ.Value = "";
            txtDOR.Value = "";
            txtEmail.Text = "";
            txtEmployeeId.Text = "";
            txtFirstName.Text = "";
            txtLastname.Text = "";
            txtMobile.Text = "";
            txtpassword.Text = "";
            txtUserName.Text = "";
            txtpassword.Text = "";
            

        }

        protected void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                cLogin objlogin = new cLogin();
            DataSet ds = null;
            ds = new DataSet();
            objlogin.EmpId = Convert.ToInt32(txtEmployeeId.Text);
            ds = objlogin.GetUserData();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtEmployeeId.Enabled = false;
                txtUserName.Text = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                txtFirstName.Text = ds.Tables[0].Rows[0]["FIRST_NAME"].ToString();
                txtLastname.Text = ds.Tables[0].Rows[0]["LAST_NAME"].ToString();
                txtDOJ.Value = ds.Tables[0].Rows[0]["JOINING_DATE"].ToString();
                txtDOR.Value = ds.Tables[0].Rows[0]["RELEVING_DATE"].ToString();
                drpDepartment.SelectedValue = ds.Tables[0].Rows[0]["DEPARTMENT_ID"].ToString();
                drpDesignation.SelectedValue = ds.Tables[0].Rows[0]["DESIGNATION_ID"].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0]["MOBILE_NO"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["EMAIL"].ToString();

                string[] abcd;

                abcd = ds.Tables[0].Rows[0]["ROLE"].ToString().Split(',');

                for (int i = 0; i < abcd.Length; i++)
                {
                    foreach (ListItem lists1 in chkIsper.Items)
                    {
                        if (Convert.ToString(lists1.Text.ToString().Trim()) == abcd[i].Trim().ToString())
                        {
                            lists1.Selected = true;

                        }

                    }

                }


                if (ds.Tables[0].Rows[0]["IS_PAID_USER"].ToString() == "Y")
                {
                    rdbCheckPaidUser.Checked = true;
                }
                else if (ds.Tables[0].Rows[0]["IS_FREE_USER"].ToString() == "Y")
                {
                    rdbCheckFreeUser.Checked = true;
                }
                

            }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Error');</script>");

            }



            

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (Session["RdbRole"].ToString() == "CreateUser")
                {

                    //MailMessage mailMessage = new MailMessage()
                    //{
                    //    Subject = txtSubject.Text,
                    //    Body = txtMessage.Text,
                    //    IsBodyHtml = false
                    //};




                    cLogin objlogin = new cLogin();

                    MailMessage mail = new MailMessage();
                   // SmtpClient SmtpServer = new SmtpClient("smtp.mail.yahoo.com");

                    string mailbody = "Your User ID is " + txtEmployeeId.Text + " & Password is " + txtpassword.Text;


                    //mail.From = new MailAddress("gauravlashkari@ymail.com");
                    //mail.To.Add(txtEmail.Text);
                    //mail.Subject = "You Intech Library User Name & Password";
                    //mail.Body = mailbody.ToString(); ;

                    //SmtpServer.Port = 587;

                    if (rdbList.SelectedValue == "")
                    {
                        Response.Write("<script>alert('Kindly Select one Categorie');</script>");
                        return;
                    }




                    if (txtEmployeeId.Text.Length > 0)
                    {
                        objlogin.EmpId = Convert.ToInt32(txtEmployeeId.Text);
                    }
                    else
                    {
                        Response.Write("<script>alert('Kindly Enter Employee Id');</script>");
                        return;
                    }

                    if (txtUserName.Text.Length > 0)
                    {
                        objlogin.User_Name = txtUserName.Text.ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('Kindly Enter User Name');</script>");
                        return;
                    }

                    if (txtpassword.Text.Length > 0)
                    {
                        objlogin.Password = txtpassword.Text.ToString();
                        txtpassword.Attributes.Add("value", objlogin.Password);
                    }
                    else
                    {
                        Response.Write("<script>alert('Kindly Enter the Password');</script>");
                        return;
                    }

                    if (txtpassword.Text != txtCPassword.Text)
                    {
                        Response.Write("<script>alert('Kindly Enter the confirm Password & password will same');</script>");
                        return;
                    }
                    else
                    {
                        objlogin.Password = txtpassword.Text;
                    }



                    if (txtFirstName.Text.Length > 0)
                    {
                        objlogin.FirstName = txtFirstName.Text;

                    }
                    else
                    {
                        objlogin.FirstName = "";
                    }


                    if (txtLastname.Text.Length > 0)
                    {
                        objlogin.Lastname = txtLastname.Text;
                    }
                    else
                    {
                        objlogin.Lastname = "";

                    }


                    if (txtDOJ.Value.Length > 0)
                    {
                        objlogin.Joining_Date = DateTime.ParseExact(txtDOJ.Value,"dd/MM/yyyy",null);
                    }
                    else
                    {
                        objlogin.Joining_Date = null;
                        //Response.Write("<script>alert('Kindly Enter the Joining Date');</script>");
                        //return;
                    }
                    

                    if (txtDOR.Value.Length > 0)
                    {
                        objlogin.Releving_Date = DateTime.ParseExact(txtDOR.Value, "dd/MM/yyyy", null);
                    }
                    else
                    {
                        objlogin.Releving_Date = null;

                    }

                    if (drpDepartment.SelectedValue == "0")
                    {
                        Response.Write("<script>alert('Kindly Select the Department');</script>");
                        return;
                    }
                    else
                    {
                        objlogin.Department_Id = Convert.ToInt32(drpDepartment.SelectedValue);
                    }

                    if (drpDesignation.SelectedValue == "0")
                    {
                        Response.Write("<script>alert('Kindly Select the Designation');</script>");
                        return;
                    }
                    else
                    {
                        objlogin.Designation = Convert.ToInt32(drpDesignation.SelectedValue);
                    }



                    if (txtEmail.Text.Length > 0)
                    {
                        objlogin.Email = txtEmail.Text;

                    }
                    else
                    {
                        txtEmail.Text = "";

                    }

                    if (txtMobile.Text.Length > 0)
                    {
                        objlogin.MobileNumber = Convert.ToInt64(txtMobile.Text);

                    }
                    else
                    {
                        Response.Write("<script>alert('Kindly Enter the Mobile Number');</script>");
                        return;
                    }

                    string lst = "";
                    string rolelist = "";

                    foreach (ListItem lists in chkIsper.Items)
                    {
                        if (lists.Selected == true)
                        {
                            lst = lists.ToString() + "," + lst;
                            string StringAdd = lst.ToString();
                            int comma = StringAdd.LastIndexOf(',');
                            rolelist = StringAdd.Substring(0, comma);
                        }
                    }
                    
                    objlogin.Role_ID = rolelist;


                    if (rdbCheckFreeUser.Checked == true)
                    {
                        objlogin.UserType = "FreeUser";
                    }
                    else if (rdbCheckPaidUser.Checked == true)
                    {
                        objlogin.UserType = "PaidUser";
                    }


                                        
                    objlogin.CreatedBy = Convert.ToInt32(Session["EMPID"].ToString());


                    string message;
                    message = objlogin.insertuser();

                    if (message == "Employee Id Already Exist")
                    {
                        Response.Write("<script>alert('Employee Id Already Exist');</script>");

                    }
                    else
                    {
                        
                        mail.To.Add(new MailAddress(txtEmail.Text));
                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.Send(mail);
                      

                        clear();

                        Response.Write("<script>alert('USER CREATED SUCESSFULLY');</script>");

                    }

                    
                }



                else if (Session["RdbRole"].ToString() == "UpdateUser")
                {

                    txtUserName.Enabled = false;

                     cLogin objlogin = new cLogin();

                     //MailMessage mailMessage = new MailMessage()
                     //{
                     //    Subject = "Your Updated Intech Library User Name & Password",
                     //    Body = "Your Changed Password is " + txtpassword.Text,
                     //    IsBodyHtml = false
                     //};


                    


                    //string mailbody = "Your Changed Password is " + txtpassword.Text;



                    // mail.To.Add(txtEmail.Text);
                    // mail.Subject = "Your Updated Intech Library User Name & Password";
                    // mail.Body = mailbody.ToString(); ;

                    

                    if (txtEmployeeId.Text.Length > 0)
                    {
                        objlogin.EmpId = Convert.ToInt32(txtEmployeeId.Text);
                    }
                    else
                    {
                        Response.Write("<script>alert('Kindly Enter Employee Id');</script>");
                        return;
                    }
                    if (txtpassword.Text.Length > 0)
                    {
                        objlogin.Password = txtpassword.Text.ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('Kindly Enter the Password');</script>");
                        return;
                    }

                    if (txtpassword.Text != txtCPassword.Text)
                    {
                        Response.Write("<script>alert('Kindly Enter the confirm Password & password will same');</script>");
                        return;
                    }
                    else
                    {
                        objlogin.Password = txtpassword.Text;
                    }
                    if (txtEmail.Text.Length > 0)
                    {
                        objlogin.Email = txtEmail.Text;

                    }
                    else
                    {
                        txtEmail.Text = "";

                    }

                    if (txtMobile.Text.Length > 0)
                    {
                        objlogin.MobileNumber = Convert.ToInt64(txtMobile.Text);

                    }
                    else
                    {
                        Response.Write("<script>alert('Kindly Enter the Mobile Number');</script>");
                        return;
                    }

                    string lst = "";
                    string rolelist = "";

                    foreach (ListItem lists in chkIsper.Items)
                    {
                        if (lists.Selected == true)
                        {
                            lst = lists.ToString() + "," + lst;
                            string StringAdd = lst.ToString();
                            int comma = StringAdd.LastIndexOf(',');
                            rolelist = StringAdd.Substring(0, comma);
                        }
                    }

                    
                    objlogin.Role_ID = rolelist;


                    if (rdbCheckFreeUser.Checked == true)
                    {
                        objlogin.UserType = "FreeUser";
                    }
                    else if (rdbCheckPaidUser.Checked == true)
                    {
                        objlogin.UserType = "PaidUser";
                    }

                    objlogin.updateuser();

                     //mail.To.Add(new MailAddress(txtEmail.Text));
                     //mailMessage.To.Add(new MailAddress(txtEmail.Text));
                     //SmtpClient smtpClient = new SmtpClient();
                     //smtpClient.SendAsync(mailMessage, null);
                      

                    Response.Write("<script>alert('USER PASSWORD CHANGED SUCESSFULLY');</script>");

                }

            }
            catch (Exception )
            {
                txtpassword.Text = "";

                Response.Write("<script>alert('ERROR');</script>");

            }


        }

        

        













    }
}