<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmOnlineBookIssue.aspx.cs" Inherits="SmartLMS.SmartLMS.frmOnlineBookIssue" %>
<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
       <link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico"/>
</head>
<body>
    <form id="form1" runat="server" class="table-record">
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
                        <asp:LinkButton ID="lnkSingOut" runat="server" onclick="lnkSingOut_Click" >LOGOUT</asp:LinkButton>
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
                                                                                    Online Request for Issue Book
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                    
                                                                                    
                                                                                    
                                                                                    <div runat="server" id="DivAlreadyIssued" visible="false">
                                                                                        <table width="100%">
                                                                                            <tr style="background-color: #313D53;">
                                                                                                <td>
                                                                                                    <asp:Label ID="Label2" runat="server" Text="Already Issued Book to This Employee"
                                                                                                        ForeColor="White"></asp:Label>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                        <table width="100%">
                                                                                            <tr>
                                                                                                <td style="width: 100%;" align="center">
                                                                                                    <asp:GridView ID="gvAlredayIssued" runat="server" AutoGenerateColumns="False" Width="100%" Font-Size="14px"
                                                                                                        DataKeyNames="ISSUED_ID,created_on,isue_to_date,EXTEND_TIME,EXTEND_DAYS,bar_code,BOOK_ID,BOOK_CAT_ID"
                                                                                                        AllowPaging="True" PageSize="5" onrowcommand="gvAlredayIssued_RowCommand" >
                                                                                                        <Columns>
                                                                                                            <asp:BoundField HeaderText="Book Name" DataField="book_name">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Category Name" DataField="CATEGORIE_NAME">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Issued Date" DataField="created_on" DataFormatString="{0:d}">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Author" DataField="author_name">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="BarCode" DataField="bar_code">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Price" DataField="book_price">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="issueid" DataField="ISSUED_ID" Visible="false">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Issued From Date" DataFormatString="{0:dd/MM/yyyy}" DataField="created_on">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Issued To Date" DataField="isue_to_date" DataFormatString="{0:dd/MM/yyyy}">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:ButtonField CommandName="Select" Text="Extend" HeaderText="Extend" ItemStyle-HorizontalAlign="Center" />
                                                                                                        </Columns>
                                                                                                    </asp:GridView>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </div>
                                                                                    <table width="100%">
                                                                                        <tr style="background-color: #313D53;">
                                                                                            <td>
                                                                                                <asp:Label ID="lblDisplay" runat="server" Text="Book Details" ForeColor="White"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td align="right">
                                                                                                <asp:Label ID="lblBarcode" runat="server" Font-Size="14px" ForeColor="#848484"  Text="Enter Barcode No:"  ></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 100px">
                                                                                                <asp:TextBox ID="txtBarcode" runat="server" Height="30px" Width="130px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td align="left" style="width: 32%">
                                                                                                <asp:ImageButton ID="btnBook" runat="server" BorderWidth="0" ImageUrl="~/IMAGES/1453648662_button_45.png"
                                                                                                    Height="31px" Width="34px" ToolTip="Search Book " 
                                                                                                    onclick="btnBook_Click"  />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 100%;" align="center">
                                                                                                <asp:GridView ID="gvBookList" runat="server" AutoGenerateColumns="False" Width="100%" Font-Size="14px"
                                                                                                    DataKeyNames="book_name" AllowPaging="True" PageSize="5">
                                                                                                    <Columns>
                                                                                                        <asp:BoundField HeaderText="Book Name" DataField="book_name">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Category Name" DataField="CATEGORIE_NAME">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Book Price" DataField="book_price">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="BookID" DataField="BOOK_ID" Visible="false">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="CatID" DataField="book_cat_id" Visible="false">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Issued Days" DataField="issued_days">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Extended Days" DataField="extend_days">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Extended Time" DataField="extend_time">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                    </Columns>
                                                                                                </asp:GridView>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 20%" align="right">
                                                                                                <asp:Label ID="lblIssuedFrm" runat="server" Font-Size="14px" ForeColor="#848484"  Text="Issued From:"  ></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 25%">
                                                                                                <%--<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>--%>
                                                                                                <input id="txtIssuedFrom" runat="server" maxlength="12" name="txtDobb" tabindex="4"
                                                                                                    type="text"  style="height: 30px; width: 130px"/>
                                                                                                
                                                                                            </td>
                                                                                            <td style="width: 20%" align="right">
                                                                                                <asp:Label ID="lblIssuedto" runat="server" Font-Size="14px" ForeColor="#848484"  Text="Issued To:"  ></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 25%">
                                                                                                <%--<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>--%>
                                                                                                <input id="txtIssuedTo" runat="server" maxlength="12" name="txtDobb" tabindex="4"
                                                                                                    type="text" style="height: 30px; width: 130px" />
                                                                                               
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 50%" align="center">
                                                                                                <asp:ImageButton ID="SaveAccountInfo" runat="server" BorderWidth="0" ImageUrl="~/IMAGES/issue.png"
                                                                                                    Height="28px" onclick="SaveAccountInfo_Click"  />
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
