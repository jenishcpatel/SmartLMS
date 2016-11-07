<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRequestForBook.aspx.cs"
    Inherits="SmartLMS.SmartLMS.frmRequestForBook" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Request to Librarian for New Book</title>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico"/>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
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
                                                        <td valign="top">
                                                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                                <tr>
                                                                    <td align="left" valign="top">
                                                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraytitle">
                                                                                    Request to Librarian to Add Book in Library
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr style="background-color: #313D53;">
                                                                                            <td colspan="4">
                                                                                                <asp:Label ID="Label1" runat="server" Text="Book Details" ForeColor="White"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr valign="top">
                                                                                            <td height="40" align="right" valign="middle">
                                                                                                <asp:Label ID="lblBookName" runat="server" Font-Size="14px" ForeColor="#848484" Text="Book Name:"></asp:Label>
                                                                                            </td>
                                                                                            <td align="left" height="40" valign="bottom">
                                                                                                <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Always">
                                                                                                    <ContentTemplate>
                                                                                                        &nbsp;&nbsp<asp:TextBox ID="txtBookName" runat="server" class="inputbig" Height="30px"
                                                                                                            Width="130px"></asp:TextBox>
                                                                                                        &nbsp;
                                                                                                    </ContentTemplate>
                                                                                                </asp:UpdatePanel>
                                                                                            </td>
                                                                                            <td height="40" align="right" valign="middle">
                                                                                                <asp:Label ID="lblAuthorName" runat="server" Text="Author Name:" Font-Size="14px"
                                                                                                    ForeColor="#848484"></asp:Label>
                                                                                            </td>
                                                                                            <td align="left" valign="middle">
                                                                                                <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Always">
                                                                                                    <ContentTemplate>
                                                                                                        &nbsp;&nbsp<asp:TextBox ID="txtAuthorname" runat="server" class="inputbig" Height="30px"
                                                                                                            Width="130px"></asp:TextBox>
                                                                                                    </ContentTemplate>
                                                                                                </asp:UpdatePanel>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td height="30" align="center" valign="middle" colspan="4px">
                                                                                                <asp:Button ID="btnSave" runat="server" Text="Submit" BackColor="#0066ff" ForeColor="White"
                                                                                                    OnClientClick="return validate();" OnClick="btnSave_Click" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
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
