<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrderLine.aspx.cs" Inherits="DeleteOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
        </div>
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="BtnNo" runat="server" Text="No" />
    </form>
</body>
</html>
