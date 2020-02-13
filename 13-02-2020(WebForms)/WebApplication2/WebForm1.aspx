<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type=">
        .text1{
        width: 100%;
    }
    .text2{
        margin-left:0px;
    }
    .text3{
        width:121px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Provide the following details</h3>
            <table class="text1">
                <tr>
                    <td class="text3">
                        <asp:Label ID="lable1" runat="server" Text="UserName"></asp:Label>
                    </td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="text2"></asp:TextBox>
                </tr>
                <tr>
                    <td class="text3">
                        <asp:Label ID="Label1" runat="server" Text="Upload a file"></asp:Label>
                    </td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </tr>
            </table>            
        </div>
    </form>
</body>
</html>
