<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUserCreation.aspx.cs"
    MaintainScrollPositionOnPostback="true" Inherits="SmartLMSWeb.SmartLMS.frmUserCreation" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Create User</title>
    <%--<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />--%>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="../css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="../js/jquery-ui-1.8.19.custom.min.js"></script>
    <link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico"/>
    <script type="text/javascript">
        $(function () {
            $("#txtDOJ").datepicker({ dateFormat: "dd/mm/yy" });
            $("#txtDOR").datepicker({ dateFormat: "dd/mm/yy" });
        });
    </script>
    <style type="text/css">
        .ui-datepicker
        {
            font-size: 8pt !important;
        }
    </style>
    <%--<script src="../js/bootstrap.js" type="text/javascript"></script>
    <script src="../js/bootstrap.min.js" type="text/javascript"></script>--%>
    <%--<script src="../js/jquery.js" type="text/javascript"></script>--%>
    <%--<script type="text/javascript">
        $(function () {
            $("#maincontent > div:gt(0)").hide();
            $("#menu a").on("click", function (e) {
                var href = $(this).attr("href");
                $("#maincontent > " + href).show();
                $("#maincontent > :not(" + href + ")").hide();
            });
        });
    
    </script>--%>
    <%-- <script type="text/javascript">
        function validate() {

            var Email = document.getElementById('<%=txtEmail.ClientID %>').value;
            var emailPat = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
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
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/IMAGES/logo1.png" Width="100%"
            Height="100px" />
    </div>
    <div>
        <table width="100%">
            <tr style="background-color: Silver; border: 0;">
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
                                                                                Create User/Change Password
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left" valign="top" style="height: 100%;">
                                                                                <table align="left" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="center" valign="middle" colspan="6">
                                                                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    <asp:RadioButtonList ID="rdbList" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="rdbList_SelectedIndexChanged"
                                                                                                        AutoPostBack="True" Height="23px">
                                                                                                        <asp:ListItem Value="0">Create User</asp:ListItem>
                                                                                                        <asp:ListItem Value="1">Change Password</asp:ListItem>
                                                                                                    </asp:RadioButtonList>
                                                                                                </ContentTemplate>
                                                                                                <Triggers>
                                                                                                    <asp:AsyncPostBackTrigger ControlID="rdbList"></asp:AsyncPostBackTrigger>
                                                                                                </Triggers>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            <asp:Label ID="lblEmpID" runat="server" Text="Employee Id:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td align="left" height="40" valign="bottom">
                                                                                            <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:TextBox ID="txtEmployeeId" runat="server" Height="30px" 
                                                                                                        Width="130px" TextMode="Number"></asp:TextBox>
                                                                                                    &nbsp;<asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/IMAGES/search1.png"
                                                                                                        OnClick="btnSearch_Click" />
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            <asp:Label ID="lblUserName" runat="server" Text="User Name:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:TextBox ID="txtUserName" runat="server" Height="30px" Width="130px"></asp:TextBox>
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr valign="top">
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            <asp:UpdatePanel ID="UpdatePanel14" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    <asp:Label ID="lblPassword" runat="server" Text="Password:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            <asp:UpdatePanel ID="UpdatePanel15" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Height="30px"
                                                                                                        Width="130px"></asp:TextBox>
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                        <td height="40" align="right" valign="middle">
                                                                                            <asp:Label ID="lblconfirm" runat="server" Text="Confirm Password:" Font-Size="14px"
                                                                                                ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td align="left" valign="middle">
                                                                                            <asp:UpdatePanel ID="UpdatePanel16" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:TextBox ID="txtCPassword" runat="server" TextMode="Password" Height="30px"
                                                                                                        Width="130px"></asp:TextBox>
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td height="40" align="right">
                                                                                            <asp:Label ID="lblFirstName" runat="server" Text="First Name:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td height="40">
                                                                                            <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:TextBox ID="txtFirstName" runat="server" MaxLength="20" Height="30px"
                                                                                                        Width="130px"></asp:TextBox>
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                        <td height="40" align="right">
                                                                                            <asp:Label ID="lblLastName" runat="server" Text=" Last Name:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td height="40">
                                                                                            <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:TextBox ID="txtLastname" runat="server" MaxLength="20" Height="30px"
                                                                                                        Width="130px"></asp:TextBox>
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="width: 14%" align="right" height="40">
                                                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                                            <asp:Label ID="lbljoin" runat="server" Text=" Joining Date:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td style="width: 20%">
                                                                                            <%--  <asp:UpdatePanel ID="UpdatePanel8" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>--%>
                                                                                            <%--<asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>--%>
                                                                                            &nbsp;&nbsp<input id="txtDOJ" runat="server" maxlength="12"  tabindex="4"
                                                                                                style="height: 30px; width: 130px" type="text"  />
                                                                                            &nbsp;
                                                                                            <%-- </ContentTemplate>
                                                                                            </asp:UpdatePanel>--%>
                                                                                        </td>
                                                                                        <td style="width: 15%" align="right">
                                                                                            <asp:Label ID="lblReleving" runat="server" Text="Releving Date:" Font-Size="14px"
                                                                                                ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <%-- <asp:UpdatePanel ID="UpdatePanel9" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>--%>
                                                                                            <%--<asp:TextBox ID="txtRelvDate" runat="server"></asp:TextBox>--%>
                                                                                            &nbsp;&nbsp<input id="txtDOR" runat="server" maxlength="12" name="txtDOR" tabindex="4"
                                                                                                type="text" style="height: 30px; width: 130px" />
                                                                                            &nbsp;&nbsp;
                                                                                            <%--    </ContentTemplate>
                                                                                            </asp:UpdatePanel>--%>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="width: 17%" height="40" align="right">
                                                                                            <asp:Label ID="lblDepartment" runat="server" Text="Department:" Font-Size="14px"
                                                                                                ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td height="40">
                                                                                            <asp:UpdatePanel ID="UpdatePanel10" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:DropDownList ID="drpDepartment" runat="server" Width="150px" AutoPostBack="True">
                                                                                                    </asp:DropDownList>
                                                                                                </ContentTemplate>
                                                                                                <Triggers>
                                                                                                    <asp:AsyncPostBackTrigger ControlID="drpDepartment"></asp:AsyncPostBackTrigger>
                                                                                                </Triggers>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                        <td height="40" align="right">
                                                                                            <asp:Label ID="lblDesignation" runat="server" Text="Designation:" Font-Size="14px"
                                                                                                ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td height="40" colspan="2px" valign="middle">
                                                                                            <asp:UpdatePanel ID="UpdatePanel11" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;
                                                                                                    <asp:DropDownList ID="drpDesignation" runat="server" Width="150px" AutoPostBack="True">
                                                                                                    </asp:DropDownList>
                                                                                                </ContentTemplate>
                                                                                                <Triggers>
                                                                                                    <asp:AsyncPostBackTrigger ControlID="drpDesignation"></asp:AsyncPostBackTrigger>
                                                                                                </Triggers>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td align="right" height="40">
                                                                                            <asp:Label ID="lblMobile" runat="server" Text="Mobile Number:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td height="40">
                                                                                            <asp:UpdatePanel ID="UpdatePanel12" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:TextBox ID="txtMobile" runat="server" MaxLength="10" TextMode="Phone"
                                                                                                        Height="30px" Width="130px"></asp:TextBox>
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                        <td align="right" height="40">
                                                                                            <asp:Label ID="lblEmail" runat="server" Text="Email:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td height="40">
                                                                                            <asp:UpdatePanel ID="UpdatePanel13" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    &nbsp;&nbsp<asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Height="30px"
                                                                                                        Width="130px"></asp:TextBox>
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td colspan="6" align="center" height="40">
                                                                                            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    <asp:CheckBoxList ID="chkIsper" runat="server" RepeatDirection="Horizontal" Font-Size="14px"
                                                                                                        ForeColor="#848484">
                                                                                                        <asp:ListItem Value="1">Admin</asp:ListItem>
                                                                                                        <asp:ListItem Value="2">Employee</asp:ListItem>
                                                                                                        <asp:ListItem Value="3">Librarian</asp:ListItem>
                                                                                                    </asp:CheckBoxList>
                                                                                                </ContentTemplate>
                                                                                                <Triggers>
                                                                                                    <asp:AsyncPostBackTrigger ControlID="chkIsper"></asp:AsyncPostBackTrigger>
                                                                                                </Triggers>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td colspan="6" align="center" height="40">
                                                                                            <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    <asp:RadioButton runat="server" ID="rdbCheckFreeUser" Text="FreeUser" GroupName="a"
                                                                                                        Font-Size="14px" ForeColor="#848484"></asp:RadioButton>
                                                                                                    <asp:RadioButton runat="server" ID="rdbCheckPaidUser" Text="PaidUser" GroupName="a"
                                                                                                        Font-Size="14px" ForeColor="#848484"></asp:RadioButton>
                                                                                                </ContentTemplate>
                                                                                                <Triggers>
                                                                                                    <asp:AsyncPostBackTrigger ControlID="rdbCheckFreeUser"></asp:AsyncPostBackTrigger>
                                                                                                    <asp:AsyncPostBackTrigger ControlID="rdbCheckPaidUser"></asp:AsyncPostBackTrigger>
                                                                                                </Triggers>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td height="30" align="center" valign="middle" colspan="4px">
                                                                                <asp:Button ID="btnSave" runat="server" BackColor="#0066ff" ForeColor="White" OnClick="btnSave_Click" />
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
