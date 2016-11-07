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
    public partial class frmAddDesignation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["USER_NAME"] != null && Session["RoleName"] != null)
                {
                    lblUser.Text = Session["USER_NAME"].ToString();
                    lblRole.Text = Session["RoleName"].ToString();
                    BINDGRID();
                }
                else
                {
                    Response.Redirect("~/SmartLMS/frmLogin.aspx");
                }
            }
        }

        protected void SaveAccountInfo_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                csBook objbook = new csBook();
                if (txtDesignation.Text.Length > 0)
                {
                    objbook.DesignationName = txtDesignation.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Designation Name');</script>");
                    return;
                }
                objbook.insertDesignation();
                BINDGRID();
                clear();
                Response.Write("<script>alert('Designation Added Sucessfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error In Insert');</script>");
            }
        }

        public void BINDGRID()
        {
            try
            {
                csBook OBJBOOK = new csBook();
                DataSet DS = new DataSet();
                DS = OBJBOOK.GetDesignation();
                gvDisplay.DataSource = DS;
                gvDisplay.DataBind();
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        private void clear()
        {
            txtDesignation.Text = "";
        }

        protected void Update_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                csBook objbook = new csBook();

                if (txtDesignation.Text.Length > 0)
                {
                    objbook.DesignationName = txtDesignation.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Designation Name');</script>");
                    return;
                }
                Int32 desigid = Convert.ToInt32(Session["Desig_ID"].ToString());
                objbook.UpdateDesignation(desigid);
                BINDGRID();
                clear();
                Update.Visible = false;
                SaveAccountInfo.Visible = true;
                Session["Desig_ID"] = "";
                Response.Write("<script>alert('Designation Updated Sucessfully');</script>");
            }
            catch
            {
                Response.Write("<script>alert('Error In Update');</script>");
            }
        }

        protected void gvDisplay_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    int rowIndex = Convert.ToInt32(e.CommandArgument);
                    //Get the value of column from the DataKeys using the RowIndex.
                    Session["Desig_ID"] = Convert.ToInt32(gvDisplay.DataKeys[rowIndex].Values[0]);
                    txtDesignation.Text = gvDisplay.DataKeys[rowIndex].Values[1].ToString();
                    SaveAccountInfo.Visible = false;
                    Update.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void gvDisplay_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                csBook OBJBOOK = new csBook();
                GridViewRow row = (GridViewRow)gvDisplay.Rows[e.RowIndex];
                Int32 DESIG = Convert.ToInt32(gvDisplay.DataKeys[e.RowIndex].Value);
                OBJBOOK.DeleteDesignation(DESIG);
                BINDGRID();
                Response.Write("<script>alert('Designation Deleted Sucessfully');</script>");
                Update.Visible = false;
                SaveAccountInfo.Visible = true;
                clear();
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

        protected void gvDisplay_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gvDisplay.PageIndex = e.NewPageIndex;
                BINDGRID();
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }
    }
}