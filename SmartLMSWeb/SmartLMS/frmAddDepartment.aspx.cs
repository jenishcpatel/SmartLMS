﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibApp;
using System.Data;

namespace SmartLMS.SmartLMS
{
    public partial class frmAddDepartment : System.Web.UI.Page
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

                if (txtDepartment.Text.Length > 0)
                {
                    objbook.DepartmentName = txtDepartment.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Department Name');</script>");
                    return;
                }
                objbook.insertDepartment();
                BINDGRID();
                clear();
                Response.Write("<script>alert('Department Added Sucessfully');</script>");
            }
            catch(Exception ex)
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
                DS = OBJBOOK.GetDepartment();
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
            txtDepartment.Text = "";
        }

        protected void Update_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                csBook objbook = new csBook();
                if (txtDepartment.Text.Length > 0)
                {
                    objbook.DepartmentName = txtDepartment.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Department Name');</script>");
                    return;
                }
                Int32 DepId = Convert.ToInt32(Session["Dep_ID"].ToString());
                objbook.UpdateDepartment(DepId);
                BINDGRID();
                clear();
                Update.Visible = false;
                SaveAccountInfo.Visible = true;
                Session["Dep_ID"] = "";
                Response.Write("<script>alert('Department Updated Sucessfully');</script>");
            }
            catch(Exception ex)
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
                    Session["Dep_ID"] = Convert.ToInt32(gvDisplay.DataKeys[rowIndex].Values[0]);
                    txtDepartment.Text = gvDisplay.DataKeys[rowIndex].Values[1].ToString();
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
                Int32 DEP = Convert.ToInt32(gvDisplay.DataKeys[e.RowIndex].Value);
                OBJBOOK.DeleteDepartment(DEP);
                BINDGRID();
                Response.Write("<script>alert('Department Deleted Sucessfully');</script>");
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