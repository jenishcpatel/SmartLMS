<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmReport.aspx.cs" Inherits="SmartLMSWeb.SmartLMS.frmReport" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="../css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="../js/jquery-ui-1.8.19.custom.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#txtfrom").datepicker({ dateFormat: "dd/mm/yy" });
            $("#txtTo").datepicker({ dateFormat: "dd/mm/yy" });
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
                                                                                Reports
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                <table align="left" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                                    <tr>
                                                                                        <td style="width: 14%" align="right" height="40">
                                                                                           <asp:Label ID="lblFrmDate" runat="server" Font-Size="14px" ForeColor="#848484"  Text=" From Date:"  ></asp:Label>
                                                                                        </td>
                                                                                        <td style="width: 20%">
                                                                                            <asp:UpdatePanel ID="UpdatePanel8" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    <%--<asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>--%>
                                                                                                    &nbsp;&nbsp<input id="txtfrom" runat="server" maxlength="12" name="txtDOJ" tabindex="4"
                                                                                                        type="text" value="dd/MM/yyyy" style="height: 30px; width: 130px"/>
                                                                                                    &nbsp;
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                        <td style="width: 15%" align="right">
                                                                                            <asp:Label ID="lblTodate" runat="server" Font-Size="14px" ForeColor="#848484"  Text=" To Date:"  ></asp:Label>
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:UpdatePanel ID="UpdatePanel9" runat="server" UpdateMode="Always">
                                                                                                <ContentTemplate>
                                                                                                    <%--<asp:TextBox ID="txtRelvDate" runat="server"></asp:TextBox>--%>
                                                                                                    &nbsp;&nbsp<input id="txtTo" value="dd/MM/yyyy" runat="server" maxlength="12" name="txtDOR"
                                                                                                        tabindex="4" type="text" style="height: 30px; width: 130px" />
                                                                                                    &nbsp;&nbsp;
                                                                                                </ContentTemplate>
                                                                                            </asp:UpdatePanel>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                <table align="left" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                                    <tr>
                                                                                        <td align="center">
                                                                                            <asp:Button ID="btnFineCol" runat="server" Text="Fine Collection" Font-Bold="true"
                                                                                                ForeColor="Black" Height="40
                                                                                            px" Width="200px" onclick="btnFineCol_Click" />
                                                                                        </td>
                                                                                    </tr>
                                                                                  
                                                                                    <tr>
                                                                                        <td align="center">
                                                                                            <asp:Button ID="btnListActivePaidUser" runat="server" Text="Active Paid User" Font-Bold="true"
                                                                                                ForeColor="Black" Height="40
                                                                                            px" Width="200px" onclick="btnListActivePaidUser_Click" />
                                                                                        </td>
                                                                                    </tr>

                                                                                     <tr>
                                                                                        <td align="center">
                                                                                            <asp:Button ID="btnBookIssued" runat="server" Text="Book Issued" Font-Bold="true"
                                                                                                ForeColor="Black" Height="40
                                                                                            px" Width="200px" onclick="btnBookIssued_Click" />
                                                                                        </td>
                                                                                    </tr>

                                                                                    <tr>
                                                                                        <td align="center">
                                                                                            <asp:Button ID="btnreturn" runat="server" Text="Book Return" Font-Bold="true"
                                                                                                ForeColor="Black" Height="40
                                                                                            px" Width="200px" onclick="btnreturn_Click" />
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
