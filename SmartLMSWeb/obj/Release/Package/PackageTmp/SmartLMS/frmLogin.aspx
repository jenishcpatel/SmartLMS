<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="SmartLMSWeb.SmartLMS.frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SmartLMS</title>
    <script type="text/javascript">
        function validate() {
            var UserName = document.getElementById('<%=txtUserName.ClientID %>').value;
            var Password = document.getElementById('<%=txtPassword.ClientID %>').value;

            if (UserName == "") {
                alert("Enter User Name");
                return false;
            }

            if (Password == "") {
                alert("Enter Password");
                return false;
            }
        }
</script>
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
                            <td height="32" align="left" valign="middle" scope="col">
                                <span class="inputloginText">Employee ID:&nbsp;</span>
                            </td>
                            <td align="left" valign="middle" scope="col">
                                <asp:TextBox ID="txtUserName" runat="server" name="txtUserName" CssClass="inputlogin"
                                    MaxLength="25" Width="180" TabIndex="1" ToolTip="UserName" 
                                    ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td height="32" align="left" valign="middle">
                                <span class="inputloginText">Password:&nbsp; </span>
                            </td>
                            <td height="32" align="left" valign="middle">
                                <asp:TextBox ID="txtPassword" runat="server" name="txtPassword" CssClass="inputlogin"
                                    MaxLength="20" TextMode="Password" Width="180" Text="Password" ToolTip="Password"
                                    TabIndex="2"></asp:TextBox>
                            </td>
                        </tr>
                        
                        <tr>
                            <td height="32" align="center" valign="middle">
                                
                            </td>
                            <td height="32" align="left" valign="middle">
                                <asp:Button ID="btnlofin" runat="server" Text="Login" TabIndex="4" 
                                    OnClientClick="return validate();" onclick="btnlofin_Click" />
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
