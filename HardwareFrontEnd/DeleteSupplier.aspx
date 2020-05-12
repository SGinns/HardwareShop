<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteSupplier.aspx.cs" Inherits="DeleteSupplier" %>

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
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" Text="No" />
    </form>
</body>
</html>
