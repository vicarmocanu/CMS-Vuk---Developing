<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="KibistaManagement.Views.Management.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../Style/StyleSheet.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-7">
            <asp:Repeater ID="UserRepeater" runat="server" OnItemCommand="UserRepeater_ItemCommand">
                <ItemTemplate>
                    <div id="userManager">
                        <b>User Name:</b>
                        <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("Name")%>'></asp:Label>
                        <br />
                        <b>Email:</b>
                        <asp:Label ID="UserEmailLabel" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                        <br />
                        <b>Type</b>
                        <asp:Label ID="UserTypeLabel" runat="server" Text='<%# Eval("Type") %>'></asp:Label>
                        <br />
                        <b>Phone Number:</b>
                        <asp:Label ID="UserPhoneNumber" runat="server" Text='<%# Eval("PhoneNr") %>'></asp:Label>
                        <br />
                        <asp:Button ID="updateUser" Text="Update User" runat="server" CommandName="userUpdate" CommandArgument='<%# Eval("Id") %>'/>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-2 col-md-offset-1">
            <asp:Button Text="Create user" runat="server" ID="createButton" OnClick="createButton_Click"/>
        </div>          
    </div>
</asp:Content>
