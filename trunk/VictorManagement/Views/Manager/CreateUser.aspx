<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="KibistaManagement.Views.Manager.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="CreateUserPanel" runat="server" DefaultButton ="btnCreateUser" Font-Size="Medium" Font-Name="Arial">

        <b>Name: </b>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="nameFieldValidator" runat="server" ErrorMessage="Please specify your name" 
                    ControlToValidate="txtName" ValidationGroup="save" ForeColor="Red" />
        <br />

        <b>Password: </b>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="passFieldValidator" runat="server" ErrorMessage="Please specify your password" 
                    ControlToValidate="txtPassword" ValidationGroup="save" ForeColor="Red" />
        <br />

        <b>Email: </b>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="emailFieldValidator" runat="server" ErrorMessage="Please specify your email" 
                    ControlToValidate="txtEmail" ValidationGroup="save" ForeColor="Red" />
        <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1"
                    SetFocusOnError="true" Text="Example: username@gmail.com" ControlToValidate="txtEmail"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"
                ValidationGroup="save" ForeColor="Red"/>
        <br />

        <b>Type: </b>
        <asp:DropDownList ID ="typesDropdown" runat="server">
            <asp:ListItem Text="Manager" Value="0"></asp:ListItem>
            <asp:ListItem Text="Customer" Value="1"></asp:ListItem>
            <asp:ListItem Text="Employee" Value="2"></asp:ListItem>
        </asp:DropDownList>
        <br />

        <b>Phone Number: </b>
        <asp:TextBox ID="txtPhoneNr" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="phoneNrFieldValidator" runat="server" ErrorMessage="Please specify your phoneNumber" 
                    ControlToValidate="txtPhoneNr" ValidationGroup="save" ForeColor="Red" />
        <br />
        <br />

        <asp:Button ID="btnCreateUser" Text="Create" runat="server" OnClick="btnCreateUser_Click" ValidationGroup="save"/>
    </asp:Panel>   
</asp:Content>
