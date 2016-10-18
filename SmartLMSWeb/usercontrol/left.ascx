<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="left.ascx.cs" Inherits="SmartLMSWeb.usercontrol.left" %>
<table width="100%" height="100%" border="0" cellspacing="0" cellpadding="0">
    <tr>
        <td align="left" valign="top" class="boxgraytitle">
            Dash Board
        </td>
    </tr>
    <tr>
        <td align="left" valign="top" class="boxgraybg">
            <div runat="server" id="divVisible">
                <a href="../SmartLMS/frmUserCreation.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="CreateUser" />&nbsp;&nbsp;Create
                    User</a><br />
                <a href="../SmartLMS/frmAddCategory.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="addBookCat" />&nbsp;&nbsp;Add
                    Book Categories </a>
                <br />
                <a href="../SmartLMS/frmBookEntry.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="bookentry" />&nbsp;&nbsp;Book
                    Entry </a>
                <br />
                <a href="../SmartLMS/frmTransactions.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="issuebook" />&nbsp;&nbsp;Issue
                    Book </a>
                <br />
                <a href="../SmartLMS/frmReturnBook.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="returnBook" />&nbsp;&nbsp;Return
                    Book </a>
                <br />
                <a href="../SmartLMS/frmDeposite.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="depositebank" />&nbsp;&nbsp;Deposite
                    Bank </a>
                <br />
                <a href="../SmartLMS/frmReport.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dailyreport" />&nbsp;&nbsp;Daily
                    Reports </a>
                <br />
                 <a href="../SmartLMS/frmLibInbox.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dailyreport" />&nbsp;&nbsp;Mail Box </a>
                <br />
                 <a href="../SmartLMS/frmGetOnlineRequest.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dailyreport" />&nbsp;&nbsp;Online Book Request
                     </a>
                <br />
                <a href="../SmartLMS/frmAddDepartment.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dailyreport" />&nbsp;&nbsp;Add Department
                     </a>
                <br />
                <a href="../SmartLMS/frmAddDesignation.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dailyreport" />&nbsp;&nbsp;Add Designation
                     </a>
                <br />
                <a href="../SmartLMS/frmDashBoard.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dabacktodashboardilyreport" />&nbsp;&nbsp;Back
                    To DashBoard </a>
                <br />
            </div>
            <div id="divEmp" runat="server" visible="false">
                <a href="../SmartLMS/frmRequestForBook.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dabacktodashboardilyreport" />&nbsp;&nbsp;Request
                    For New Book </a>
                <br />
                <a href="../SmartLMS/frmSearchBook.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dabacktodashboardilyreport" />&nbsp;&nbsp;Search
                    Book </a>
                <br />
                <a href="../SmartLMS/frmOnlineBookIssue.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dabacktodashboardilyreport" />&nbsp;&nbsp;Request
                    Issue New Book </a>
                <br />
                <a href="../SmartLMS/frmEmployeeDashboard.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dabacktodashboardilyreport" />&nbsp;&nbsp;Back
                    To DashBoard </a>
            </div>
            <div runat="server" id="divLibVisible">
                <a href="../SmartLMS/frmGetOnlineRequest.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="EmployeeEntry" />&nbsp;&nbsp;Online
                    Issue Request</a>
                <br />
                <a href="../SmartLMS/frmAddCategory.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="addBookCat" />&nbsp;&nbsp;Add
                    Book Categories </a>
                <br />
                <a href="../SmartLMS/frmBookEntry.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="bookentry" />&nbsp;&nbsp;Book
                    Entry </a>
                <br />
                <a href="../SmartLMS/frmTransactions.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="issuebook" />&nbsp;&nbsp;Issue
                    Book </a>
                <br />
                <a href="../SmartLMS/frmReturnBook.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="returnBook" />&nbsp;&nbsp;Return
                    Book </a>
                <br />
                <a href="../SmartLMS/frmReport.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dailyreport" />&nbsp;&nbsp;Daily
                    Reports </a>
                <br />
                <a href="../SmartLMS/frmLibrarianDashboard.aspx" class="leftlink">
                    <img src="../IMAGES/arrow_left_link.png" border="0" alt="dabacktodashboardilyreport" />&nbsp;&nbsp;Back
                    To DashBoard </a>
                <br />
            </div>
            <br />
            <a href="../SmartLMS/frmLogin.aspx" class="leftlink">
                <img src="../IMAGES/arrow_left_link.png" border="0" alt="logOut" />&nbsp;&nbsp;Logout</a>
        </td>
    </tr>
</table>
