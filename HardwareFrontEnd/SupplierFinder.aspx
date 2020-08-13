<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierFinder.aspx.cs" Inherits="SupplierFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SupplierId&nbsp;
            <asp:TextBox ID="SupplierIdBox" runat="server"></asp:TextBox>
            <asp:Button ID="FindBtn" runat="server" OnClick="FindBtn_On_click" Text="Find" />
            <br />
            CompanyName&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="CompanyName" runat="server"></asp:TextBox>
            <br />
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Address" runat="server"></asp:TextBox>
            <br />
            PostalCode&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="PostalCode" runat="server"></asp:TextBox>
            <br />
            Phone&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
            <br />
            StockAvaliablity&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="StockAvaliablity" runat="server"></asp:TextBox>
            <br />
            Date Added
            <asp:TextBox ID="DateAddedBox" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>