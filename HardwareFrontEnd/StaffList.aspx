<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="ListBox1" runat="server" Height="121px" Width="146px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btn_On_click_Add" Text="Add" Height="26px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_onClick" Text="Delete" Height="26px" />
        </p>

        <asp:Label ID="lblError" runat="server" />
    </form>
</body>
</html>
