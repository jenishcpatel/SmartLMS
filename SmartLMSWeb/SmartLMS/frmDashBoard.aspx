<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDashBoard.aspx.cs" Inherits="SmartLMSWeb.SmartLMS.frmDashBoard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico"/>
    <title>DashBoard</title>
    <style type="text/css">
        .style1
        {
            height: 30px;
        }
        .style2
        {
            width: 55%;
            height: 23px;
        }
        .style3
        {
            width: 45%;
            height: 23px;
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
            <table width="100%">
                <tr>
                    <td class="style1">
                        <h2>
                            Welcome to Dashboard</h2>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <%--<div style="background-image: url(../IMAGES/BookBackground.jpg); background-repeat:no-repeat; ">--%>
        <div>
            <table width="100%">
                <tr>
                    <td style="width: 33%;">
                        <div id="dvAdmin" runat="server" visible="false">
                            <table width="100%">
                                <tr>
                                    <td style="width: 100%;" align="center">
                                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/IMAGES/1443213515_Profile.png"
                                            OnClick="ImageButton1_Click" />
                                        <br />
                                        Create User
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton2" runat="server" Height="48px" ImageUrl="~/IMAGES/1443213717_user-group-new.png"
                                        Width="67px" OnClick="ImageButton2_Click" />
                                    <br />
                                    Inbox
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton3" runat="server" Height="48px" ImageUrl="~/IMAGES/1443214151_edit.png"
                                        Width="67px" OnClick="ImageButton3_Click" />
                                    <br />
                                    Add Books Categories
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div>
            <table width="100%">
                <tr>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/IMAGES/1453158897_book.png"
                                        OnClick="ImageButton4_Click" />
                                    <br />
                                    Book Entry
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton5" runat="server" Height="48px" ImageUrl="~/IMAGES/1453159257_address-book-alt.png"
                                        Width="67px" OnClick="ImageButton5_Click" />
                                    <br />
                                    Issue Book
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton6" runat="server" Height="48px" ImageUrl="~/IMAGES/1453159544_architecture-interior-13.png"
                                        Width="67px" OnClick="ImageButton6_Click" />
                                    <br />
                                    Return Book
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div>
            <table width="100%">
                <tr>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/IMAGES/1453159902_library.png"
                                        OnClick="ImageButton7_Click" />
                                    <br />
                                    Deposite Bank
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/IMAGES/OnlineApplication.png"
                                        Height="46px" Width="68px" OnClick="ImageButton10_Click" />
                                    <br />
                                    Online Book Issue Request
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton9" runat="server" Height="48px" ImageUrl="~/IMAGES/1453160287_checked-checklist-notepad.png"
                                        Width="67px" OnClick="ImageButton9_Click" />
                                    <br />
                                    Daily Reports
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div>
            <table width="100%">
                <tr>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="btnAddDep" runat="server" ImageUrl="~/IMAGES/department.png"
                                        Height="42px" onclick="btnAddDep_Click" />
                                    <br />
                                    Add Department
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="btnAddDesignation" runat="server" ImageUrl="~/IMAGES/designation.png"
                                        Height="41px" Width="67px" onclick="btnAddDesignation_Click"  />
                                    <br />
                                    Add Designation</td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <div>
            <table width="100%">
                <tr>
                    <td align="right" class="style2">
                        Today&#39;s Total Number Of Book Issued :
                    </td>
                    <td align="left" class="style3">
                        <asp:Label ID="lblBookIssued" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 55%;" align="right">
                        Today&#39;s Total Number Of Book Return:
                    </td>
                    <td style="width: 45%;" align="left">
                        <asp:Label ID="lblReturnBook" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 55%;" align="right">
                        Today&#39;s Total Fine Collection:
                    </td>
                    <td style="width: 45%;" align="left">
                        <asp:Label ID="lblFine" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 55%;" align="right">
                        Pending Mail:
                    </td>
                    <td style="width: 45%;" align="left">
                        <asp:Label ID="lblMail" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/IMAGES/footer.png" Width="100%" />
        </div>
    </div>
    </form>
</body>
</html>
