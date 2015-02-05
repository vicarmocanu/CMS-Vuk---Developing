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
        <asp:Panel ID="UpdateUserPanel" runat="server" DefaultButton ="btnUpdateUser" Font-Size="Medium" Font-Name="Arial">

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
            <asp:RequiredFieldValidator ID="emailFieldValidator" runat="server" ErrorMessage="Please specify your email" 
                    ControlToValidate="txtEmail" ValidationGroup="save" ForeColor="Red" />
            <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1"
                    SetFocusOnError="true" Text="Example: username@gmail.com" ControlToValidate="txtEmail"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"
                ValidationGroup="save" ForeColor="Red"/>
            <br />

            <b>Type:</b>
            <asp:DropDownList ID ="typesDropdown" runat="server">
                <asp:ListItem Text="Manager" Value="0"></asp:ListItem>
                <asp:ListItem Text="Customer" Value="1"></asp:ListItem>
                <asp:ListItem Text="Employee" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <br />

            <b>Phone Number:</b>
            <asp:TextBox ID="txtPhoneNr" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="phoneNrFieldValidator" runat="server" ErrorMessage="Please specify your phone number" 
                    ControlToValidate="txtPhoneNr" ValidationGroup="save" ForeColor="Red" />
            <br />
            <br />

            <asp:Button ID="btnUpdateUser" Text="Update" runat="server" OnClick="updateButton_Click" ValidationGroup="save"/>

        </asp:Panel>            
        </div>

    </div>
</asp:Content>
