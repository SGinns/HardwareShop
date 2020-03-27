<%@ Page Language="C#" AutoEventWireup="true" CodeFile="staffFinder.aspx.cs" Inherits="staffFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            EmployeeID&nbsp;
            <asp:TextBox ID="EmployeeIDBox" runat="server"></asp:TextBox>
            <asp:Button ID="FindBtn" runat="server" OnClick="FindBtn_On_click" Text="Find" />
            <br />
            FirstName&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="FirstNameBox" runat="server"></asp:TextBox>
            <br />
            LastName&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="LastNameBox" runat="server"></asp:TextBox>
            <br />
            Salary&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SalaryBox" runat="server"></asp:TextBox>
            <br />
            Date Added
            <asp:TextBox ID="DateAddedBox" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
