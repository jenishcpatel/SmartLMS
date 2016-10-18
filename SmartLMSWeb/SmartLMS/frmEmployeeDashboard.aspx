<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEmployeeDashboard.aspx.cs"
    Inherits="SmartLMSWeb.SmartLMS.frmEmployeeDashboard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Dashboard</title>
    <link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico" />
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
                    <td style="width: 100%;" align="center" >
                        <marquee><asp:Label ID="lblRejectBook" ForeColor="Red" runat="server" ></asp:Label></marquee>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <table width="100%">
                <tr>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/IMAGES/1443213515_Profile.png"
                                        OnClick="ImageButton1_Click" />
                                    <br />
                                    Change Password
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton2" runat="server" Height="48px" ImageUrl="~/IMAGES/1443213717_user-group-new.png"
                                        Width="67px" OnClick="ImageButton2_Click" />
                                    <br />
                                    Request to Librarian for Add New Book in Library
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 100%;" align="center">
                                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/IMAGES/1453158897_book.png"
                                        OnClick="ImageButton4_Click" />
                                    <br />
                                    Search Book Availability
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
                                    <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/IMAGES/OnlineApplication.png"
                                        Height="46px" Width="68px" OnClick="ImageButton10_Click" />
                                    <br />
                                    Online Book Issue Request
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 33%;">
                    </td>
                    <td style="width: 33%;">
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div>
            <table width="100%">
                <tr>
                    <td style="width: 55%;" align="right">
                        Total Number Of Book Issued :
                    </td>
                    <td style="width: 45%;" align="left">
                        <asp:Label ID="lblIssuedBook" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 55%;" align="right">
                        Total Number Of Book Return:
                    </td>
                    <td style="width: 45%;" align="left">
                        <asp:Label ID="lblReturnedBook" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 55%;" align="right">
                        Total Fine Due:
                    </td>
                    <td style="width: 45%;" align="left">
                        <asp:Label ID="lblFine" runat="server"></asp:Label>
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
