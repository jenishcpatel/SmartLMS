﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAddDepartment.aspx.cs"
    Inherits="SmartLMSWeb.SmartLMS.frmAddDepartment" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Department</title>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
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
                                                                                Department Details
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                <table width="100%">
                                                                                    <tr style="background-color: #313D53;">
                                                                                        <td>
                                                                                            <asp:Label ID="lblDisplay" runat="server" Text="Department Name" ForeColor="White"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <table width="100%">
                                                                                    <tr>
                                                                                        <td style="width: 50%" align="right">
                                                                                            <asp:Label ID="lblDep" runat="server" Text="Department Name:" Font-Size="14px" ForeColor="#848484"></asp:Label>
                                                                                        </td>
                                                                                        <td style="width: 50%" colspan="5">
                                                                                            <asp:TextBox ID="txtDepartment" runat="server" Height="30px" Width="130px"></asp:TextBox>
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
                                                                                            <asp:ImageButton ID="Update" runat="server" BorderWidth="0" ImageUrl="~/IMAGES/update.gif"
                                                                                                Visible="false" OnClick="Update_Click" />
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <br />
                                                                                <table width="100%">
                                                                                    <tr style="background-color: #313D53;">
                                                                                        <td>
                                                                                            <asp:Label ID="Label1" runat="server" Text="Department List" ForeColor="White"></asp:Label>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                                <br />
                                                                                <table width="100%">
                                                                                    <tr>
                                                                                        <td style="width: 100%;" align="center">
                                                                                            <asp:GridView ID="gvDisplay" runat="server" AutoGenerateColumns="False" Width="100%"
                                                                                                Font-Size="14px" AllowPaging="True" PageSize="5" OnRowDeleting="gvDisplay_RowDeleting"
                                                                                                DataKeyNames="DEPART_ID,DEPART_NAME" OnRowCommand="gvDisplay_RowCommand">
                                                                                                <Columns>
                                                                                                    <asp:BoundField HeaderText="Department Name" DataField="DEPART_NAME">
                                                                                                        <ItemStyle HorizontalAlign="Center" />
                                                                                                    </asp:BoundField>
                                                                                                    <asp:BoundField HeaderText="CateID" DataField="DEPART_ID" Visible="false">
                                                                                                        <ItemStyle HorizontalAlign="Center" />
                                                                                                    </asp:BoundField>
                                                                                                    <asp:ButtonField CommandName="Select" Text="Edit" HeaderText="Edit" ItemStyle-HorizontalAlign="Center" />
                                                                                                    <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" ItemStyle-HorizontalAlign="Center" />
                                                                                                </Columns>
                                                                                            </asp:GridView>
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
