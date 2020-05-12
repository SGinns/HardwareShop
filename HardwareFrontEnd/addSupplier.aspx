<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addSupplier.aspx.cs" Inherits="addSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SupplierId
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            CompanyName
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            StockAvaliablity
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="Active" runat="server" />

            <br />
            <br />

            <asp:Label ID="lblError" runat="server"  />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
