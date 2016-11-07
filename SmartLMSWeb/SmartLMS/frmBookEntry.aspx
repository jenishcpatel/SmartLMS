<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBookEntry.aspx.cs" Inherits="SmartLMS.SmartLMS.frmBookEntry" MaintainScrollPositionOnPostback="true" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Details</title>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="../css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="../js/jquery-ui-1.8.19.custom.min.js"></script>
    <link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico"/>
    <script type="text/javascript">
        $(function () {
            $("#txtPurchaseD").datepicker({ dateFormat: "dd/mm/yy" });

        });
    </script>
    <style type="text/css">
        .ui-datepicker
        {
            font-size: 8pt !important;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/IMAGES/logo1.png" Width="100%"
                Height="100px" />
        </div>
        <div>
            <table width="100%">
                <tr style="background-color: Silver;">
                    <td style="width: 10%;">
                        UserName:
                    </td>
                    <td style="width: 40%;">
                        <asp:Label ID="lblUser" runat="server"></asp:Label>
                    </td>
                    <td align="right" style="width: 10%;">
                        Role:
                    </td>
                    <td style="width: 30%;">
                        <asp:Label ID="lblRole" runat="server"></asp:Label>
                    </td>
                    <td style="width: 10%;">
                        <asp:LinkButton ID="lnkSingOut" runat="server" OnClick="lnkSingOut_Click">LOGOUT</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <table width="100%" style="height: 100%" border="0" cellspacing="0" cellpadding="0"
                align="center">
                <tr>
                    <td align="center" valign="top" class="bodybg">
                        <table width="100%" style="height: 100%" border="0" align="center" cellpadding="0"
                            cellspacing="0">
                            <tr>
                                <td height="20" align="left" valign="top">
                                    <img src="../images/sedow_top_inner.png" width="100%" height="80%" />
                                </td>
                            </tr>
                            <tr>
                                <td align="left" valign="top">
                                    <table width="100%" style="height: 100%" border="0" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td width="30" align="left" valign="top">
                                                <img src="../images/sedow_left.png" width="30" height="221" />
                                            </td>
                                            <td align="left" valign="top" class="tdmain">
                                                <table width="100%" style="height: 100%" border="0" cellspacing="0" cellpadding="0">
                                                    <tr>
                                                        <td width="214" align="left" valign="top" style="height: 100%;">
                                                            <uc3:left ID="left1" runat="server" />
                                                        </td>
                                                        <td width="50" align="left" valign="top">
                                                            &nbsp;
                                                        </td>
                                                        <td align="left" valign="top">
                                                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                                <tr>
                                                                    <td align="left" valign="top">
                                                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraytitle">
                                                                                    Enter Book Details
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                    <table width="100%">
                                                                                        <tr style="background-color: #313D53;">
                                                                                            <td>
                                                                                                <asp:Label ID="lblDisplay" runat="server" Text="Book Details" ForeColor="White"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblBookName" runat="server" Font-Size="14px" ForeColor="#848484" Text="Book Name:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtBookName" runat="server" MaxLength="20" Height="30px" Width="130px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblBarcode" runat="server" Font-Size="14px" ForeColor="#848484" Text="Barcode No:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtBarcodeNo" runat="server" MaxLength="20" Height="30px" 
                                                                                                    Width="130px" TextMode="Number"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="width: 20%" align="right">
                                                                                                <asp:Label ID="lblDateofPurchase" runat="server" Font-Size="14px" ForeColor="#848484"
                                                                                                    Text="Date of Purchase:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 20%">
                                                                                                <%--<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>--%>
                                                                                                <input id="txtPurchaseD" runat="server" maxlength="12" name="txtDobb" tabindex="4"
                                                                                                    type="text" style="height: 30px; width: 130px" />
                                                                                            </td>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblBookCategory" runat="server" Font-Size="14px" ForeColor="#848484"
                                                                                                    Text="Book Category:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:DropDownList ID="drpCate" runat="server" Width="140px" AutoPostBack="True">
                                                                                                </asp:DropDownList>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblAuthorname" runat="server" Font-Size="14px" ForeColor="#848484"
                                                                                                    Text="Author Name:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtAuthorName" runat="server" MaxLength="20" Height="30px" Width="130px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblPurchaseAmt" runat="server" Font-Size="14px" ForeColor="#848484"
                                                                                                    Text="Purchase Amount:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtPurchaseAmount" runat="server" MaxLength="20" Height="30px" 
                                                                                                    Width="130px" TextMode="Number"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblIssuedForDays" runat="server" Font-Size="14px" ForeColor="#848484"
                                                                                                    Text="Issued for Day's:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtIssuedDays" runat="server" MaxLength="20" Height="30px" 
                                                                                                    Width="130px" TextMode="Number"></asp:TextBox>
                                                                                            </td>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblExtendeddays" runat="server" Font-Size="14px" ForeColor="#848484"
                                                                                                    Text="Extended Days:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtExtend" runat="server" MaxLength="20" Height="30px" 
                                                                                                    Width="130px" TextMode="Number"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblNoofExtends" runat="server" Font-Size="14px" ForeColor="#848484"
                                                                                                    Text="No of Extends:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtNoofExtends" runat="server" MaxLength="20" Height="30px" 
                                                                                                    Width="130px" TextMode="Number"></asp:TextBox>
                                                                                            </td>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblNoofCopies" runat="server" Font-Size="14px" ForeColor="#848484"
                                                                                                    Text="No of Copies:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtNoofCopies" runat="server" MaxLength="20" Height="30px" 
                                                                                                    Width="130px" TextMode="Number"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 50%" align="center">
                                                                                                <asp:ImageButton ID="SaveAccountInfo" runat="server" BorderWidth="0" ImageUrl="../IMAGES/submit.png"
                                                                                                    OnClick="SaveAccountInfo_Click" />
                                                                                                &nbsp
                                                                                                <asp:ImageButton ID="Update" runat="server" BorderWidth="0" ImageUrl="~/IMAGES/update.gif"
                                                                                                    Visible="false" OnClick="Update_Click" Style="height: 28px" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr style="background-color: #313D53;">
                                                                                            <td>
                                                                                                <asp:Label ID="Label1" runat="server" Text="Book List" ForeColor="White"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td align="right">
                                                                                                <asp:Label ID="lblSBarcode" runat="server" Font-Size="14px" ForeColor="#848484" Text="Enter Barcode Number:"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 100px">
                                                                                                <asp:TextBox ID="txtSearchBarcode" runat="server" Height="30px" Width="130px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td align="left" style="width: 32%">
                                                                                                <asp:ImageButton ID="ImageButton1" runat="server" BorderWidth="0" ImageUrl="~/IMAGES/1453648662_button_45.png"
                                                                                                    Height="31px" Width="34px" ToolTip="Search Book " OnClick="ImageButton1_Click" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 100%;" align="center">
                                                                                                <asp:GridView ID="gvDisplay" runat="server" AutoGenerateColumns="False" Width="100%"
                                                                                                    Font-Size="14px" DataKeyNames="BOOK_ID,purchase_date,author_name,bar_code,book_cat_id,book_name,book_price,NO_OF_COPIES,ISSUED_DAYS,EXTEND_DAYS,EXTEND_TIME"
                                                                                                    AllowPaging="True" PageSize="5" OnRowDeleting="gvDisplay_RowDeleting" 
                                                                                                    OnRowCommand="gvDisplay_RowCommand" 
                                                                                                    onpageindexchanging="gvDisplay_PageIndexChanging">
                                                                                                    <Columns>
                                                                                                        <asp:BoundField HeaderText="Book Name" DataField="book_name">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Category Name" DataField="CATEGORIE_NAME">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Purchase Date" DataField="purchase_date" DataFormatString="{0:d}">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Author" DataField="author_name">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="BarCode" DataField="bar_code">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="CatID" DataField="book_cat_id" Visible="false">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="BookID" DataField="BOOK_ID" Visible="false">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Price" DataField="book_price">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="No Of Copies" DataField="NO_OF_COPIES">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Remaning Copies" DataField="REMAINIGBOOKS">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Issue for Day's" DataField="ISSUED_DAYS">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Extended Days" DataField="EXTEND_DAYS">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="No of Extends" DataField="EXTEND_TIME">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:ButtonField CommandName="Select" Text="Edit" HeaderText="Edit" ItemStyle-HorizontalAlign="Center" />
                                                                                                        <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" ItemStyle-HorizontalAlign="Center" />
                                                                                                    </Columns>
                                                                                                </asp:GridView>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="left" valign="top">
                                                                                    &nbsp;
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td width="30" align="left" valign="top">
                                                <img src="../IMAGES/sedow_right.png" alt="RightImg" width="30" height="221" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/IMAGES/footer.png" Width="100%" />
        </div>
    </div>
    </form>
</body>
</html>
