<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmReturnBook.aspx.cs"
    Inherits="SmartLMSWeb.SmartLMS.frmReturnBook" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ReturnBook</title>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
     <link type="text/css" href="../css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="../js/jquery-ui-1.8.19.custom.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#txtReturn").datepicker({ dateFormat: "dd/mm/yy" });

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
                                                                                    Return Book
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr style="background-color: #313D53;">
                                                                                            <td>
                                                                                                <asp:Label ID="Label1" runat="server" Text="Employee Details" ForeColor="White"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td align="right">
                                                                                             <asp:Label ID="lblEmp" runat="server" Font-Size="14px" ForeColor="#848484"  Text="Enter Employee ID:"  ></asp:Label>   
                                                                                            </td>
                                                                                            <td style="width: 100px">
                                                                                                <asp:TextBox ID="txtSearchEmp" runat="server" Height="30px" Width="130px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td align="left" style="width: 32%">
                                                                                                <asp:ImageButton ID="btnEmp" runat="server" BorderWidth="0" ImageUrl="~/IMAGES/1453648662_button_45.png"
                                                                                                    Height="31px" Width="34px" ToolTip="Search Book " OnClick="btnEmp_Click" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 100%;" align="center">
                                                                                                <asp:GridView ID="gvDisplay" runat="server" AutoGenerateColumns="False" Width="100%" Font-Size="14px"
                                                                                                    DataKeyNames="EMPLOYEE_ID" AllowPaging="True" PageSize="5">
                                                                                                    <Columns>
                                                                                                        <asp:BoundField HeaderText="Employee ID" DataField="EMPLOYEE_ID">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Employee Name" DataField="Emp_Name">
                                                                                                            <ItemStyle HorizontalAlign="Center" />
                                                                                                        </asp:BoundField>
                                                                                                        <asp:BoundField HeaderText="Joining Date" DataField="joining_date" DataFormatString="{0:d}">
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
                                                                                                    </Columns>
                                                                                                </asp:GridView>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <div runat="server" id="DivAlreadyIssued" visible="false">
                                                                                        <table width="100%">
                                                                                            <tr style="background-color: #313D53;">
                                                                                                <td>
                                                                                                    <asp:Label ID="Label2" runat="server" Text="Already Issued Book to Thie Employee"
                                                                                                        ForeColor="White"></asp:Label>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                        <table width="100%">
                                                                                            <tr>
                                                                                                <td style="width: 100%;" align="center">
                                                                                                    <asp:GridView ID="gvAlredayIssued" runat="server" AutoGenerateColumns="False" Width="100%" Font-Size="14px"
                                                                                                        DataKeyNames="ISSUED_ID,BOOK_ID" AllowPaging="True" PageSize="5" OnRowCommand="gvAlredayIssued_RowCommand">
                                                                                                        <Columns>
                                                                                                            <asp:BoundField HeaderText="Book Name" DataField="book_name">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Category Name" DataField="CATEGORIE_NAME">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Issued Date" DataField="created_on" DataFormatString="{0:d}">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Author" DataField="author_name">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="BarCode" DataField="bar_code">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Price" DataField="book_price">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="issueid" DataField="ISSUED_ID" Visible="false">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:ButtonField CommandName="Select" Text="Select" HeaderText="Select For Return"
                                                                                                                ItemStyle-HorizontalAlign="Center" />
                                                                                                        </Columns>
                                                                                                    </asp:GridView>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </div>
                                                                                    <br />
                                                                                    <div runat="server" id="divFine" visible="false">
                                                                                        <table width="100%">
                                                                                            <tr style="background-color: #313D53;">
                                                                                                <td>
                                                                                                    <asp:Label ID="lblFine" runat="server" Text="Fine Summary" ForeColor="White"></asp:Label>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                        <table width="100%">
                                                                                            <tr>
                                                                                                <td style="width: 100%;" align="center">
                                                                                                    <asp:GridView ID="gvFine" runat="server" AutoGenerateColumns="False" Width="100%"
                                                                                                        AllowPaging="True" PageSize="5" Font-Size="14px">
                                                                                                        <Columns>
                                                                                                            <asp:BoundField HeaderText="Book Name" DataField="book_name">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Delayed Days" DataField="DelayedDays">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Fine Amount" DataField="fineAmount">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                        </Columns>
                                                                                                    </asp:GridView>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </div>
                                                                                    <br />
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 50%" align="right">
                                                                                                <asp:Label ID="lblReturndate" runat="server" Font-Size="14px" ForeColor="#848484"  Text="Return Date:"  ></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 50%">
                                                                                                <%--<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>--%>
                                                                                                <input id="txtReturn" runat="server" maxlength="12" name="txtDobb" tabindex="4" type="text" style="height: 30px; width: 130px" />
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="width: 50%" align="right">
                                                                                               <asp:Label ID="lblFineAmount" runat="server" Font-Size="14px" ForeColor="#848484"  Text="Fine Amount:"  ></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 50%">
                                                                                                <asp:TextBox ID="txtFineAmount" runat="server" Height="30px" Width="130px"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                         <tr>
                                                                                            <td style="width: 50%" align="right">
                                                                                               <asp:Label ID="lblRemarks" runat="server" Font-Size="14px" ForeColor="#848484"  Text="Remarks:"  ></asp:Label>
                                                                                            </td>
                                                                                            <td style="width: 50%">
                                                                                                <asp:TextBox ID="txtRemarks" runat="server" Height="30px" Width="130px"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table width="100%">
                                                                                        <tr>
                                                                                            <td style="width: 50%" align="center">
                                                                                                <asp:ImageButton ID="SaveAccountInfo" runat="server" BorderWidth="0" ImageUrl="~/IMAGES/Return.png"
                                                                                                    Height="28px" OnClick="SaveAccountInfo_Click" />
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
