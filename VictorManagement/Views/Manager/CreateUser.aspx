<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="KibistaManagement.Views.Manager.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="CreateUserPanel" runat="server" DefaultButton ="btnCreateUser" Font-Size="Medium" Font-Name="Arial">
        <b>Name:</b>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="nameFieldValidator" runat="server" ErrorMessage="Please specify your name" 
                    ControlToValidate="txtName" ValidationGroup="save" ForeColor="Red" />
        <br />

        <b>Password:</b>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="passFieldValidator" runat="server" ErrorMessage="Please specify your password" 
                    ControlToValidate="txtPassword" ValidationGroup="save" ForeColor="Red" />
        <br />

        <b>Email:</b>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />

    </asp:Panel>
    
    
    
    
    
    
    <b>Type:</b>
    <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
    <br />
    <b>Phone Number:</b>
    <asp:TextBox ID="txtPhoneNr" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnCreateUser" Text="Create" runat="server" OnClick="btnCreateUser_Click" />
</asp:Content>
