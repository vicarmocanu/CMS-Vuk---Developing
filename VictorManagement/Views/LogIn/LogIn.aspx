<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="KibistaManagement.Views.LogIn.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 379px; margin-bottom: 280px">
    <form id="form1" runat="server">
    <div>
        
    </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
             <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox> 
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="LogIn" OnClick="Button1_Click" style="height: 26px" />
        </div>
    </form>
</body>
</html>
