<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aStaff.aspx.cs" Inherits="aStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Salary
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            FirstName
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            LastName
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
