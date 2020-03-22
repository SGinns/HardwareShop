<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="600px" Width="600px"></asp:ListBox>
        </div>
        <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" Text="Add" />
        <asp:Button ID="DeleteBtn" runat="server" OnClick="DeleteBtn_Click" Text="Delete" />
        <asp:Button ID="EditBtn" runat="server" OnClick="EditBtn_Click" Text="Edit" />
        <br />
        <asp:Label ID="DetailsLbl" runat="server" Text="Enter the details " />
        <asp:TextBox ID="txtBxDetails" runat="server" />
        <br />
        <asp:Button ID="ApplyBtn" runat="server" OnClick="ApplyBtn_Click" Text="Apply" />
        <asp:Button ID="ClearBtn" runat="server" OnClick="ClearBtn_Click" Text="Clear" />
        <br />
        <asp:Label ID="ErrorLbl" runat="server" />
    </form>
</body>
</html>
