<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Views/LogIn/LogIn.Master" CodeBehind="LogIn.aspx.cs" Inherits="KibistaManagement.Views.LogIn.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
            <div>
           <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            </div>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <div>
            &nbsp<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </div>
            <br />
        <div>
            &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp &nbsp&nbsp<asp:Button ID="Button1" runat="server" Text="LogIn" OnClick="Button1_Click" style="height: 26px"  />
        </div>
    </div>
        </div>
</asp:Content>

