<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="KibistaManagement.Views.Manager.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <b>Name:</b>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <b>Password:</b>
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <br />
    <b>Email:</b>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br />
    <b>Type:</b>
    <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
    <br />
    <b>Phone Number:</b>
    <asp:TextBox ID="txtPhoneNr" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnCreateUser" Text="Create" runat="server" OnClick="btnCreateUser_Click" />
</asp:Content>
