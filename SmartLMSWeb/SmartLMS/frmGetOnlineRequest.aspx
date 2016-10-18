<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGetOnlineRequest.aspx.cs"
    Inherits="SmartLMSWeb.SmartLMS.frmGetOnlineRequest" %>

<%@ Register Src="~/usercontrol/left.ascx" TagName="left" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/simple-sidebar.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../IMAGES/icon_aNT_icon.ico"/>
</head>
<body>
    <form id="form1" runat="server" class="table-font">
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
                                                                                    Online Request for Issue Book
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td align="left" valign="top" class="boxgraybg" style="height: 100%;">
                                                                                    <div runat="server" id="DivAlreadyIssued" visible="false">
                                                                                        <table width="100%">
                                                                                            <tr style="background-color: #313D53;">
                                                                                                <td>
                                                                                                    <asp:Label ID="Label2" runat="server" Text="Pending List for the approval" ForeColor="White"></asp:Label>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                        <table width="100%">
                                                                                                <tr>
                                                                                                    <td align="center">
                                                                                                        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <td style="width: 100%;" align="center">
                                                                                                    <asp:GridView ID="gvAlredayIssued" runat="server" AutoGenerateColumns="False" Width="100%"
                                                                                                        DataKeyNames="BOOK_CAT_ID,ISSUE_TYPE,EMPLOYEE_ID,BOOK_ID,BARCODE,ISSUE_FROM_DATE,ISSUE_DATE,REQ_ID"
                                                                                                        AllowPaging="True" PageSize="5" OnRowCommand="gvAlredayIssued_RowCommand" 
                                                                                                        OnRowDeleting="gvAlredayIssued_RowDeleting" 
                                                                                                        onpageindexchanging="gvAlredayIssued_PageIndexChanging">
                                                                                                        <Columns>
                                                                                                            <asp:BoundField HeaderText="Employee Code" DataField="EMPLOYEE_ID">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Employee Name" DataField="EMPNAME">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Book Name" DataField="BOOK_NAME">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Barcode" DataField="BARCODE">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Issue From Date" DataField="ISSUE_FROM_DATE" DataFormatString="{0:d}">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Issue To Date" DataField="ISSUE_DATE" DataFormatString="{0:d}">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Approval Type" DataField="ISSUE_TYPE">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Issue_ID" DataField="ISSUE_ID" Visible="false">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <%--<asp:BoundField HeaderText="Issued From Date" DataFormatString="{0:dd/MM/yyyy}" DataField="created_on">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>
                                                                                                            <asp:BoundField HeaderText="Issued To Date" DataField="isue_to_date" DataFormatString="{0:dd/MM/yyyy}">
                                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                                            </asp:BoundField>--%>
                                                                                                            <asp:ButtonField CommandName="SELECT" Text="Approve" HeaderText="Approve" ItemStyle-HorizontalAlign="Center">
                                                                                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                                                                            </asp:ButtonField>
                                                                                                            <%--<asp:ButtonField CommandName="select" Text="Reject" HeaderText="Reject" ItemStyle-HorizontalAlign="Center">
                                                                                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                                                                            </asp:ButtonField>--%>
                                                                                                            <asp:CommandField ShowDeleteButton="true" HeaderText="Reject" ItemStyle-HorizontalAlign="Center"
                                                                                                                DeleteText="Reject">
                                                                                                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                                                                                            </asp:CommandField>
                                                                                                        </Columns>
                                                                                                    </asp:GridView>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </div>
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
