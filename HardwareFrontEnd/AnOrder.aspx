<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label id="lblOrderId" Text="OrderId" Width="200px" runat="server"></asp:Label>
            <asp:TextBox ID="txtBxOrderId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <br />
            <asp:Label id="lblCustomerId" Text="CustomerId" Width="200px" runat="server"></asp:Label>
            <asp:TextBox ID="txtBxCustomerId" runat="server"></asp:TextBox>
            <br />
            <asp:Label id="lblStaffId" Text="StaffId" Width="200px" runat="server"></asp:Label>
            <asp:TextBox ID="txtBxStaffId" runat="server"></asp:TextBox>
            <br />
            <asp:Label id="lblDate" Text="Date" Width="200px" runat="server"></asp:Label>
            <asp:TextBox ID="txtBxDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label id="lblDetails" Text="Details" Width="200px" runat="server"></asp:Label>
            <asp:TextBox ID="txtBxDetails" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
        </form>
</body>
</html>
