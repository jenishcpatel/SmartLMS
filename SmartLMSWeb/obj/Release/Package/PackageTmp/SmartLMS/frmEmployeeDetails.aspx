<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEmployeeDetails.aspx.cs"
    Inherits="SmartLMSWeb.SmartLMS.frmEmployeeDetails" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Entry</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <script src="../js/bootstrap.js" type="text/javascript"></script>
    <script src="../js/bootstrap.min.js" type="text/javascript"></script>
    <script src="../js/jquery.js" type="text/javascript"></script>
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
                                                                                Employee Details
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                <table width="100%">
                                                                                    <tr style="background-color: #313D53;">
                                                                                        <td>
                                                                                            <asp:Label ID="lblDisplay" runat="server" Text="Employee Details" ForeColor="White"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <table width="100%">
                                                                                    <tr>
                                                                                        <td style="width: 17%" align="right">
                                                                                            First Name:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtFirstName" runat="server" MaxLength="20"></asp:TextBox>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Midlle Name:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtMidlleName" runat="server" MaxLength="20"></asp:TextBox>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Last Name:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtLastname" runat="server" MaxLength="20"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="width: 14%" align="right">
                                                                                            Date of Birth:
                                                                                        </td>
                                                                                        <td style="width: 20%">
                                                                                            <%--<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>--%>
                                                                                            <input id="txtDOB" runat="server" maxlength="12" name="txtDobb" tabindex="4" type="text" />
                                                                                            &nbsp;
                                                                                            <input id="but_tio_dtd" class="buttonRann" name="but_tio_dtd" style="width: 20px"
                                                                                                type="button" value="..." />
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Gender:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:DropDownList ID="drpSex" runat="server" Width="140px" AutoPostBack="True">
                                                                                                <asp:ListItem Value="1">MALE</asp:ListItem>
                                                                                                <asp:ListItem Value="2">FEMALE</asp:ListItem>
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Mobile Number:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtMobile" runat="server" MaxLength="10"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Email:
                                                                                        </td>
                                                                                        <td style="width: 17%" colspan="5">
                                                                                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <table width="100%">
                                                                                    <tr style="background-color: #313D53;">
                                                                                        <td>
                                                                                            <asp:Label ID="Label1" runat="server" Text="Current Address" ForeColor="White"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <table width="100%">
                                                                                    <tr>
                                                                                        <td align="right" class="style1">
                                                                                            House/Flat No:
                                                                                        </td>
                                                                                        <td class="style1">
                                                                                            <asp:TextBox ID="txtCurHouseNo" runat="server" MaxLength="100"></asp:TextBox>
                                                                                        </td>
                                                                                        <td align="right" class="style1">
                                                                                            Street/Landmark:
                                                                                        </td>
                                                                                        <td class="style1">
                                                                                            <asp:TextBox ID="txtCurLandMark" runat="server" MaxLength="50"></asp:TextBox>
                                                                                        </td>
                                                                                        <td align="right" class="style1">
                                                                                            Pincode:
                                                                                        </td>
                                                                                        <td class="style1">
                                                                                            <asp:TextBox ID="txtCurPincode" runat="server" MaxLength="6"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="width: 17%" align="right">
                                                                                            State:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:DropDownList ID="drpCurState" runat="server" Width="140px" AutoPostBack="True">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            District:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:DropDownList ID="drpCurDistrict" runat="server" Width="140px" 
                                                                                                AutoPostBack="True" 
                                                                                                onselectedindexchanged="drpCurDistrict_SelectedIndexChanged">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            City:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtCurCity" runat="server"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <table width="100%">
                                                                                    <tr style="background-color: #313D53;">
                                                                                        <td style="height: 100%">
                                                                                            <asp:Label ID="Label2" runat="server" Text="Permanent Address" ForeColor="White"></asp:Label>
                                                                                            &nbsp; &nbsp;&nbsp;
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <table width="100%">
                                                                                    <tr>
                                                                                        <td colspan="6" align="center">
                                                                                            <asp:CheckBox ID="chkIsper" runat="server" Text="Is Permanent same as Current" 
                                                                                                AutoPostBack="true" oncheckedchanged="chkIsper_CheckedChanged"  />
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="width: 17%" align="right">
                                                                                            House/Flat No:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtPerHouse" runat="server"></asp:TextBox>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Street/Landmark:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtPerStreet" runat="server"></asp:TextBox>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Pincode:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtPerPincode" runat="server"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="width: 17%" align="right">
                                                                                            State:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:DropDownList ID="drpPerState" runat="server" Width="140px">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            District:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:DropDownList ID="drpPerDist" runat="server" Width="140px" 
                                                                                                onselectedindexchanged="drpPerDist_SelectedIndexChanged">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            City:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtPerCity" runat="server"></asp:TextBox>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <table width="100%">
                                                                                    <tr style="background-color: #313D53;">
                                                                                        <td>
                                                                                            <asp:Label ID="Label4" runat="server" Text="Joining Details" ForeColor="White"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <table width="100%">
                                                                                    <tr>
                                                                                        <td style="width: 14%" align="right">
                                                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Joining Date:
                                                                                        </td>
                                                                                        <td style="width: 20%">
                                                                                            <%--<asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>--%>
                                                                                            <input id="txtDOJ" runat="server" maxlength="12" name="txtDOJ" tabindex="4" type="text" />
                                                                                            &nbsp;
                                                                                            <input id="btnDOJ" class="buttonRann" name="but_tio_dtd" style="width: 23px" type="button"
                                                                                                value="..." />
                                                                                        </td>
                                                                                        <td style="width: 15%" align="right">
                                                                                            Releving Date:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <%--<asp:TextBox ID="txtRelvDate" runat="server"></asp:TextBox>--%>
                                                                                            <input id="txtDOR" runat="server" maxlength="12" name="txtDOR" tabindex="4" type="text" />
                                                                                            &nbsp;
                                                                                            <input id="btnDOR" class="buttonRann" name="DOR" style="width: 18px" type="button"
                                                                                                value="..." />
                                                                                        </td>
                                                                                        <td style="width: 14%" align="right">
                                                                                            EmployeeID:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:TextBox ID="txtmployeeId" runat="server" MaxLength="10"></asp:TextBox>
                                                                                            &nbsp;
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Department:
                                                                                        </td>
                                                                                        <td style="width: 17%">
                                                                                            <asp:DropDownList ID="drpDepartment" runat="server" Width="140px" AutoPostBack="True">
                                                                                            </asp:DropDownList>
                                                                                        </td>
                                                                                        <td style="width: 17%" align="right">
                                                                                            Designation:
                                                                                        </td>
                                                                                        <td style="width: 17%" colspan="2">
                                                                                            <asp:DropDownList ID="drpDesignation" runat="server" Width="140px" AutoPostBack="True">
                                                                                            </asp:DropDownList>
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
                                                                                            <asp:ImageButton ID="Update" runat="server" BorderWidth="0" 
                                                                                                ImageUrl="~/IMAGES/update.gif" Visible="false" />
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
