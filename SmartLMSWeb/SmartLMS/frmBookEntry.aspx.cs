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
    public partial class frmBookEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["USER_NAME"] != null && Session["RoleName"] != null)
                {
                    lblUser.Text = Session["USER_NAME"].ToString();
                    lblRole.Text = Session["RoleName"].ToString();
                    fillBookCategory();
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
         
                if (txtBookName.Text.Length > 0)
                {
                    objbook.BookName = txtBookName.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Book Name');</script>");
                    return;
                }

                if (txtBarcodeNo.Text.Length > 0)
                {
                    objbook.Barcode = txtBarcodeNo.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Barcode Number');</script>");
                    return;
                }

                objbook.AuthorName =txtAuthorName.Text.Length > 0?txtAuthorName.Text:"";

                if (txtPurchaseD.Value.Length > 0)
                {
                    //objbook.PurchaseDate = Convert.ToDateTime(txtPurchaseD.Value);
                    objbook.PurchaseDate = DateTime.ParseExact(txtPurchaseD.Value,"dd/MM/yyyy",null);
                }
                else
                {
                    objbook.PurchaseDate = null;
                }
                if (Convert.ToInt32(drpCate.SelectedValue) == 0)
                {
                    Response.Write("<script>alert('Kindly Select Category');</script>");
                    return;
                }
                else
                {
                    objbook.BookCatID = Convert.ToInt32(drpCate.SelectedValue);
                }
                objbook.PUrchaseRate = txtPurchaseAmount.Text.Length > 0 ? Convert.ToInt32(txtPurchaseAmount.Text) : 0;
                objbook.IssueDays = txtIssuedDays.Text.Length > 0 ? Convert.ToInt32(txtIssuedDays.Text) : 0;
                objbook.ExtendDays = txtExtend.Text.Length > 0?Convert.ToInt32(txtExtend.Text):0;
                objbook.ExtendTime = txtNoofExtends.Text.Length > 0? Convert.ToInt32(txtNoofExtends.Text):0;
                objbook.NoofCopies = txtNoofCopies.Text.Length > 0?Convert.ToInt32(txtNoofCopies.Text):0;
                objbook.insertBook();
                BINDGRID();
                clear();
                Response.Write("<script>alert('Book Enter Sucessfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }


        private void fillBookCategory()
        {
            try
            {
                csBook objbook = new csBook();
                DataSet ds = new DataSet();
                ds = objbook.GetBookCat();
                drpCate.DataSource = ds.Tables[0];
                drpCate.DataTextField = "categorie_name";
                drpCate.DataValueField = "book_cat_id";
                drpCate.DataBind();
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }


        public void BINDGRID()
        {
            try
            {
                csBook OBJBOOK = new csBook();
                DataSet DS = new DataSet();
                DS = OBJBOOK.GetBookList();
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
                Int32 BOOKID = Convert.ToInt32(gvDisplay.DataKeys[e.RowIndex].Value);
                OBJBOOK.DeleteBook(BOOKID);
                BINDGRID();
                clear();
                Response.Write("<script>alert('Book Deleted Sucessfully');</script>");
                Update.Visible = false;
                SaveAccountInfo.Visible = true;
            }
            catch (Exception ex)
            {
                Console.Write("Error:" + ex.ToString());
            }
        }

        protected void gvDisplay_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    int rowIndex = Convert.ToInt32(e.CommandArgument);
                    Session["BookID"] = Convert.ToInt32(gvDisplay.DataKeys[rowIndex].Values[0]);
                    txtPurchaseD.Value = gvDisplay.DataKeys[rowIndex].Values[1].ToString();
                    txtAuthorName.Text = gvDisplay.DataKeys[rowIndex].Values[2].ToString();
                    txtBarcodeNo.Text = gvDisplay.DataKeys[rowIndex].Values[3].ToString();
                    txtBookName.Text = gvDisplay.DataKeys[rowIndex].Values[5].ToString();
                    fillBookCategory();
                    drpCate.SelectedValue = gvDisplay.DataKeys[rowIndex].Values[4].ToString();
                    txtPurchaseAmount.Text = gvDisplay.DataKeys[rowIndex].Values[6].ToString();
                    txtNoofCopies.Text = gvDisplay.DataKeys[rowIndex].Values[7].ToString();
                    txtIssuedDays.Text = gvDisplay.DataKeys[rowIndex].Values[8].ToString();
                    txtExtend.Text = gvDisplay.DataKeys[rowIndex].Values[9].ToString();
                    txtNoofExtends.Text = gvDisplay.DataKeys[rowIndex].Values[10].ToString();
                    SaveAccountInfo.Visible = false;
                    Update.Visible = true;
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
                if (txtBookName.Text.Length > 0)
                {
                    objbook.BookName = txtBookName.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Book Name');</script>");
                    return;
                }

                if (txtBarcodeNo.Text.Length > 0)
                {
                    objbook.Barcode = txtBarcodeNo.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Barcode Number');</script>");
                    return;
                }
                objbook.AuthorName = txtAuthorName.Text.Length > 0?txtAuthorName.Text:"";
               
                if (txtPurchaseD.Value.Length > 0)
                {
                    objbook.PurchaseDate = Convert.ToDateTime(txtPurchaseD.Value);
                }
                else
                {
                    objbook.PurchaseDate = null;

                }
                if (Convert.ToInt32(drpCate.SelectedValue) == 0)
                {
                    Response.Write("<script>alert('Kindly Select Category');</script>");
                    return;
                }
                else
                {
                    objbook.BookCatID = Convert.ToInt32(drpCate.SelectedValue);
                }
                objbook.PUrchaseRate =txtPurchaseAmount.Text.Length > 0? Convert.ToInt32 (txtPurchaseAmount.Text):0;
                objbook.IssueDays =txtIssuedDays.Text.Length > 0? Convert.ToInt32(txtIssuedDays.Text): 0;
                objbook.ExtendDays =txtExtend.Text.Length > 0? Convert.ToInt32(txtExtend.Text):0;
                objbook.ExtendTime =txtNoofExtends.Text.Length > 0? Convert.ToInt32(txtNoofExtends.Text): 0;
                objbook.NoofCopies =txtNoofCopies.Text.Length > 0? Convert.ToInt32(txtNoofCopies.Text): 0;
                Int32 BookID = Convert.ToInt32(Session["BookID"].ToString());
                objbook.UpdateBook(BookID);
                BINDGRID();
                clear();
                Update.Visible = false;
                SaveAccountInfo.Visible = true;
                Session["BookID"] = "";
                Response.Write("<script>alert('Book Updated Sucessfully');</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Error In Updated');</script>");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                csBook objbook = new csBook();
                if (txtSearchBarcode.Text.Length > 0)
                {
                    objbook.Barcode = txtSearchBarcode.Text;
                }
                else
                {
                    Response.Write("<script>alert('Kindly Enter the Barcode Number');</script>");
                    return;
                }

                DataSet ds = new DataSet();
                ds = objbook.GetBookListBarcode();
                gvDisplay.DataSource = ds;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        gvDisplay.DataSource = null;
                        gvDisplay.DataBind();
                        clear();
                        Response.Write("<script>alert('This Book Is Not available');</script>");
                    }
                    else
                    {
                        gvDisplay.DataBind();
                    }
                }
                else
                {
                    Response.Write("<script>alert('This Book Is Not available');</script>");
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

        private void clear()
        {
            txtBarcodeNo.Text = "";
            txtAuthorName.Text = "";
            txtBookName.Text = "";
            txtExtend.Text = "";
            txtIssuedDays.Text = "";
            txtNoofCopies.Text = "";
            txtNoofExtends.Text = "";
            txtPurchaseAmount.Text = "";
            txtPurchaseD.Value = "";
            txtSearchBarcode.Text = "";
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