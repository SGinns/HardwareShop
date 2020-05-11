<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteAddress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Are you sure you want to delete this record?</p><br />
            <asp:Button ID="btnYes" Text="Yes" runat="server" OnClick="btnYes_onClick" />
            <asp:Button ID="btnNo" Text="No" runat="server" OnClick="btnNo_onClick" />
        </div>
    </form>
</body>
</html>
