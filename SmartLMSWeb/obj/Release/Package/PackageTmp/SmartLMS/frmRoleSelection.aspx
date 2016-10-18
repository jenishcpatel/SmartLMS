<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRoleSelection.aspx.cs"
    Inherits="SmartLMSWeb.SmartLMS.frmRoleSelection" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Role Selection</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/IMAGES/logo1.png" Width="100%"
            Height="100px" />
    </div>
    <div style="height: 60%;">
        <table width="100%">
            <tr>
                <td style="width: 40%;">
                    <table width="100%">
                        <tr>
                            <td width="30%" align="right" valign="middle" scope="col">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/IMAGES/login_icon_administrator.png" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="width: 60%;">
                    <table width="100%">
                        <tr>
                            <td colspan="2" align="center" valign="top" scope="col">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td height="32" align="left" valign="middle">
                                <span class="inputloginText">Role:&nbsp; </span>
                            </td>
                            <td height="32" align="left" valign="middle">
                                <asp:DropDownList ID="drpRole" runat="server" Width="185px" TabIndex="3" ToolTip="Role">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td height="32" align="center" valign="middle">
                            </td>
                            <td height="32" align="left" valign="middle">
                                <asp:Button ID="btnGo" runat="server" Text="Go To Page" TabIndex="4" OnClick="btnGo_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/IMAGES/footer.png" Width="100%" />
    </div>
    </form>
</body>
</html>
