<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" ToolTip="Enter User Name"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit"  />
        </p>
    </form>

</body>
</html>
