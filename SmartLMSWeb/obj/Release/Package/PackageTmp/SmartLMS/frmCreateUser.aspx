<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCreateUser.aspx.cs"
    Inherits="SmartLMSWeb.SmartLMS.frmCreateUser" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create User</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <script src="../js/bootstrap.js" type="text/javascript"></script>
    <script src="../js/bootstrap.min.js" type="text/javascript"></script>
    <script src="../js/jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#maincontent > div:gt(0)").hide();
            $("#menu a").on("click", function (e) {
                var href = $(this).attr("href");
                $("#maincontent > " + href).show();
                $("#maincontent > :not(" + href + ")").hide();
            });
        });
    
    </script>

     <script type="text/javascript">
         function validate() {

             var Email = document.getElementById('<%=txtemail.ClientID %>').value;
             var emailPat = /^(\".*\"|[A-Za-z]\w*)@(\[\d{1,3}(\.\d{1,3}){3}]|[A-Za-z]\w*(\.[A-Za-z]\w*)+)$/
             var EmailmatchArray = Email.match(emailPat);
                         
             if (Email == "") {
                 alert("Enter Email Id");
                 return false;
             }

             if (EmailmatchArray == null) {
                 alert("Your email address seems incorrect. Please try again.");
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
                    <asp:LinkButton ID="lnkSingOut" runat="server" onclick="lnkSingOut_Click">LOGOUT</asp:LinkButton>
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
                                                                                Create User/Change Password
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                <table align="left" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="center" valign="middle" colspan="4">
                                                                                            <asp:RadioButtonList ID="rdbList" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="rdbList_SelectedIndexChanged"
                                                                                                AutoPostBack="True" Height="23px" Width="228px">
                                                                                                <asp:ListItem Value="0">Create User</asp:ListItem>
                                                                                                <asp:ListItem Value="1">Change Password</asp:ListItem>
                                                                                            </asp:RadioButtonList>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            Employee Id:
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            &nbsp<asp:TextBox ID="txtEmployeeId" runat="server" class="inputbig"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            <asp:Label ID="lblUserName" runat="server" Text="User Name:"></asp:Label>
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            &nbsp<asp:TextBox ID="txtUserName" runat="server" class="inputbig"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                     <tr valign="top">
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            <asp:Label ID="lblEmail" runat="server" Text="Email Id:"></asp:Label>
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            &nbsp<asp:TextBox ID="txtemail" runat="server" class="inputbig"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            <asp:Label ID="lblRoleId" runat="server" Text="Role:"></asp:Label>
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            &nbsp<asp:DropDownList ID="drpRole" runat="server" TabIndex="3" ToolTip="Role">
                                                                                                <asp:ListItem Value="1">ADMIN</asp:ListItem>
                                                                                                <asp:ListItem Value="2">LIB INCHARGE</asp:ListItem>
                                                                                                <asp:ListItem Value="3">EMPLOYEES</asp:ListItem>
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            &nbsp<asp:TextBox 
                                                                                                ID="txtpassword" runat="server" class="inputbig" TextMode="Password"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            Confirm Password:
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            &nbsp<asp:TextBox 
                                                                                                ID="txtCPassword" runat="server" class="inputbig" TextMode="Password"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr align="left" valign="middle">
                                                                                        <td height="40" align="right" valign="middle" nowrap="nowrap">
                                                                                            &nbsp;
                                                                                        </td>
                                                                                        <td height="30" align="left" valign="middle" class="paddingleft10" class="bluebtn">
                                                                                            <asp:ImageButton ID="SaveAccountInfo" runat="server" BorderWidth="0" ImageUrl="../IMAGES/submit.png"
                                                                                                OnClick="SaveAccountInfo_Click" OnClientClick="return validate();"/>
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
    </form>
</body>
</html>
