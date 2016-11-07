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
    public partial class frmAddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["USER_NAME"] !=null && Session["RoleName"] !=null)
                {
                    lblUser.Text = Session["USER_NAME"].ToString();
                    lblRole.Text = Session["RoleName"].ToString();
                    BINDGRID();
                }else
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
                if (txtcategory.Text.Length > 0)
                {
                    objbook.CategoryName = txtcategory.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Category Name');</script>");
                    return;
                }
                objbook.IsActive =chkisActive.Checked?"Y":"N";
                objbook.insertCategory();
                BINDGRID();
                clear();
                Response.Write("<script>alert('Category Added Sucessfully');</script>");
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
                DS = OBJBOOK.GetCategoryList();
                gvDisplay.DataSource = DS;
                gvDisplay.DataBind();
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
                Int32 CAT = Convert.ToInt32(gvDisplay.DataKeys[e.RowIndex].Value);
                OBJBOOK.DeleteCategory(CAT);
                BINDGRID();
                Response.Write("<script>alert('Category Deleted Sucessfully');</script>");
                Update.Visible = false;
                SaveAccountInfo.Visible = true;
                clear();
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void gvDisplay_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try { 
            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                //Get the value of column from the DataKeys using the RowIndex.
                Session["Cat_ID"] = Convert.ToInt32(gvDisplay.DataKeys[rowIndex].Values[0]);
                txtcategory.Text = gvDisplay.DataKeys[rowIndex].Values[1].ToString();
                SaveAccountInfo.Visible = false;
                Update.Visible = true;
                chkisActive.Checked = gvDisplay.DataKeys[rowIndex].Values[2].ToString() == "Y"?true:false;
            }
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void Update_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                csBook objbook = new csBook();

                if (txtcategory.Text.Length > 0)
                {
                    objbook.CategoryName = txtcategory.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Category Name');</script>");
                    return;
                }

                objbook.IsActive = chkisActive.Checked ? "Y" : "N";

                Int32 CatId = Convert.ToInt32(Session["Cat_ID"].ToString());
                objbook.UpdateCategory(CatId);
                BINDGRID();
                clear();
                Update.Visible = false;
                SaveAccountInfo.Visible = true;
                Session["Cat_ID"] = "";
                Response.Write("<script>alert('Category Updated Sucessfully');</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Error In Update');</script>");
            }
         }


        private void clear()
        {
            txtcategory.Text = "";
            chkisActive.Checked = false;
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