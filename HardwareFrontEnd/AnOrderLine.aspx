<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderLine" runat="server" Text="Order Line" Width="200px"/>
            <asp:TextBox ID="txtBxOrderLineId" runat="server" />
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <br />
            <asp:Label ID="lblOrderId" runat="server" Text="Order Id" Width="200px"/>
            <asp:TextBox ID="txtBxOrderId" runat="server" />
            <br />
            <asp:Label ID="lblProductId" runat="server" Text="Product Id" Width="200px"/>
            <asp:TextBox ID="txtBxProductId" runat="server" />
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" Width="200px"/>
            <asp:TextBox ID="txtBxQuantity" runat="server" />
            <br />
            <asp:Button ID="btnOK" Text="OK" runat="server" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" Text="Cancel" runat="server" />
        </div>
    </form>
</body>
</html>
