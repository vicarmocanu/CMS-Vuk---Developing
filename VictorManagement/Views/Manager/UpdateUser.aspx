<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="KibistaManagement.Views.Manager.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <!-- Original -->
        <div class="col-md-6">
            <b> Original </b>
            <br />
            <asp:Repeater ID="UserRepeater" runat="server">
                <ItemTemplate>
                    <div id="userManager">
                        <b>User Name: </b>
                        <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("Name")%>'></asp:Label>
                        <br />
                        <b>Email: </b>
                        <asp:Label ID="UserEmailLabel" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                        <br />
                        <b>Type: </b>
                        <asp:Label ID="UserTypeLabel" runat="server" Text='<%# Eval("Type") %>'></asp:Label>
                        <br />
                        <b>Phone Number: </b>
                        <asp:Label ID="UserPhoneNumber" runat="server" Text='<%# Eval("PhoneNr") %>'></asp:Label>
                        <br />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <!-- Update -->
        <div class="col-md-6">
            <b> Update </b>
            <br />
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
            <asp:Button runat="server" Text="Update" id="updateButton" OnClick="updateButton_Click" />
        </div>
    </div>
</asp:Content>
