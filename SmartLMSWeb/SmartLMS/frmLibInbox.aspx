<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLibInbox.aspx.cs" Inherits="SmartLMSWeb.SmartLMS.frmLibInbox" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mail Box</title>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico"/>
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
                                                                                    Mail Box
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                    <br />
                                                                                    <div runat="server" id="DivAlreadyIssued">
                                                                                        <table width="100%">
                                                                                            <tr style="background-color: #313D53;">
                                                                                                <td>
                                                                                                    <asp:Label ID="Label2" runat="server" Text="Mail Box" ForeColor="White"></asp:Label>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                        <table width="100%">
                                                                                            <tr>
                                                                                                <td style="width: 100%;" align="center">
                                                                                                    <asp:GridView ID="gvMail" runat="server" AutoGenerateColumns="False" Width="100%"
                                                                                                        DataKeyNames="MAIL_ID" Font-Size="14px" AllowPaging="True" PageSize="5" OnRowCommand="gvMail_RowCommand"
                                                                                                        EnableTheming="True" OnPageIndexChanging="gvMail_PageIndexChanging">
                                                                                                        <Columns>
                                                                                                            <asp:BoundField HeaderText="From User" DataField="USER_NAME">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Book Name" DataField="BOOK_NAME">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Author Name" DataField="AUTHORNAME">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Date" DataField="CREATED_ON" DataFormatString="{0:d}">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:ButtonField CommandName="Select" Text="Delete" HeaderText="Delete Mail" ItemStyle-HorizontalAlign="Center">
                                                                                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                                                                            </asp:ButtonField>
                                                                                                        </Columns>
                                                                                                    </asp:GridView>
                                                                                                    &nbsp;
                                                                                                    <asp:Label ID="lblMsg" Font-Size="14px" runat="server" ForeColor="Red"></asp:Label>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </div>
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
