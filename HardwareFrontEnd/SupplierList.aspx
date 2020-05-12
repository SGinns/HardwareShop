﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="SupplierList" %>

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
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="26px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_onClick" Text="Delete" Height="26px" />
        </p>

        <asp:Label ID="lblError" runat="server" />

        <asp:Label ID="lblFilter" runat="server">Enter a first name</asp:Label>
        <asp:TextBox runat="server" ID="filterBox" Width="125px" /> <br /> <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_click" Text="Apply" Height="26px" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_click" Text="Clear" Height="26px" />
    </form>
</body>
</html>
