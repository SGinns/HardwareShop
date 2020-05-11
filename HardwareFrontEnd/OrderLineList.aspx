<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderLinesList" runat="server" Height="492px" Width="592px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" Text="Add" />
            <asp:Button ID="DeleteBtn" runat="server" OnClick="DeleteBtn_Click" Text="Delete" />
            <asp:Button ID="EditBtn" runat="server" OnClick="EditBtn_Click" Text="Edit" />
            <br />
            <asp:Label ID="ErrorLbl" runat="server" />
        </p>
    </form>
</body>
</html>
