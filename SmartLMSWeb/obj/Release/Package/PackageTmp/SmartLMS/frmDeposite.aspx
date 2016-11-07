<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDeposite.aspx.cs" Inherits="SmartLMSWeb.SmartLMS.frmDeposite" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Deposite</title>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="../css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="../js/jquery-ui-1.8.19.custom.min.js"></script>
    <link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico"/>
    <script type="text/javascript">
        $(function () {
            $("#txtDepositeDate").datepicker({ dateFormat: "dd/mm/yy" });

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
                                                                                    Deposite Advance Amount
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr style="background-color: #313D53;">
                                                                                            <td>
                                                                                                <asp:Label ID="Label1" runat="server" Text="Employee List" ForeColor="White"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td align="right">
                                                                                                <asp:Label ID="lblEmpID" runat="server" Text="Employee Id:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 100px">
                                                                                                <asp:TextBox ID="txtSearchEmp" runat="server" Height="30px" Width="130px"></asp:TextBox>
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
                                                                                                    Font-Size="14px" DataKeyNames="EMPLOYEE_ID" AllowPaging="True" PageSize="5">
                                                                                                    <Columns>
                                                                                                        <asp:BoundField HeaderText="Employee ID" DataField="employee_id">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Employee Name" DataField="Emp_Name">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Joining Date" DataField="JOINING_DATE" DataFormatString="{0:d}">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Designation" DataField="desig_name">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Department" DataField="depart_name">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Mobile No" DataField="mobile_no">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Payment Done" DataField="IS_PAYMENT_DONE">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                    </Columns>
                                                                                                </asp:GridView>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr style="background-color: #313D53;">
                                                                                            <td>
                                                                                                <asp:Label ID="lblDisplay" runat="server" Text="Deposite Details" ForeColor="White"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 17%" align="right">
                                                                                                <asp:Label ID="lblDepAmt" runat="server" Text="Deposite Amount:" Font-Size="14px"
                                                                                                    ForeColor="#848484"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 17%">
                                                                                                <asp:TextBox ID="txtDepositeAmt" runat="server" MaxLength="20" Height="30px" Width="130px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td style="width: 20%" align="right">
                                                                                                <asp:Label ID="lblDepositeDate" runat="server" Text="Date of Deposite:" Font-Size="14px"
                                                                                                    ForeColor="#848484"></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 20%">
                                                                                                <%--<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>--%>
                                                                                                <input id="txtDepositeDate" runat="server" maxlength="12" name="txtDobb" tabindex="4"
                                                                                                    type="text" style="height: 30px; width: 130px"  />
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="width: 100%" align="Center" colspan="4">
                                                                                                <asp:CheckBox ID="chkIsSurrendered" runat="server" Text="Is Deposite Surrendered" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 50%" align="center">
                                                                                                <asp:ImageButton ID="SaveAccountInfo" runat="server" BorderWidth="0" ImageUrl="../IMAGES/submit.png"
                                                                                                    OnClick="SaveAccountInfo_Click" />
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
