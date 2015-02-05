<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="KibistaManagement.Views.Management.Verify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Selection section !-->
    <div class="row" style="padding:40px;">
        <div class="col-md-10 col-md-offset-1">
            <asp:Label runat="server"> <b> Event: </b></asp:Label>
            <asp:DropDownList ID="eventsList" runat="server" OnSelectedIndexChanged="eventsList_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:Button ID ="taskSearch" Text="Get tasks" OnClick="tasksSearch_Click" runat="server" />
            <asp:DropDownList ID="tasksList" runat="server" OnSelectedIndexChanged="taskList_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:Button ID="checksSearch" Text="Get checks" OnClick="checksSearch_Click" runat="server" />
        </div>
    </div>

    <!-- Checks section !-->
    <div class="row" style="padding:40px;">
        <!-- Customer checks repeater !-->
        <div class="col-md-6" id="verifyCheckLeft"> 
            <div style="text-align:center;">
                <asp:Label runat="server">
                    <b> Customer checks </b>
                </asp:Label>
            </div>
            <br />       
            <asp:Repeater runat="server" ID="CustomerTasksCheckRepeater">
                <ItemTemplate>
                    <div id="verifyCustomerCheck">
                        <b> Task name: </b>
                        <asp:Label ID="TaskName" runat="server" Text='<% #Eval("TaskName") %>'></asp:Label>
                        <br />
                        <b> User name: </b>
                        <asp:Label ID="UserNameLabel" runat="server" Text='<% #Eval("UserName") %>'></asp:Label>
                        <br />
                        <b> User type: </b>
                        <asp:Label ID="UserTypeLabel" runat="server" Text='<% #Eval("UserType") %>'></asp:Label>
                        <br />
                        <b> Check date-time: </b>
                        <asp:Label ID="UserCheckTime" runat="server" Text='<% #Eval("CheckTime") %>'></asp:Label>
                        <br />
                        <b> Check value: </b>
                        <asp:Label ID="UserActualCheck" runat="server" Text='<% #Eval("CheckValue") %>'></asp:Label>
                        <br />
                        <b> Description: </b>
                        <asp:Label ID="UserDescription" runat="server" Text='<% #Eval("Description") %>'></asp:Label>
                    </div>                    
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <!-- Employee checks repeater !-->
        <div class="col-md-6" id="verifyCheckRight"> 
            <div style="text-align:center;">
                <asp:Label runat="server">
                    <b> Employee checks </b>
                </asp:Label>
            </div>
            <br />       
            <asp:Repeater runat="server" ID="EmployeeTaskCheckRepeater">
                <ItemTemplate>
                    <div id="verifyEmployeeCheck">
                        <b> Task name: </b>
                        <asp:Label ID="TaskName" runat="server" Text='<% #Eval("TaskName") %>'></asp:Label>
                        <br />
                        <b> User name: </b>
                        <asp:Label ID="UserNameLabel" runat="server" Text='<% #Eval("UserName") %>'></asp:Label>
                        <br />
                        <b> User type: </b>
                        <asp:Label ID="UserTypeLabel" runat="server" Text='<% #Eval("UserType") %>'></asp:Label>
                        <br />
                        <b> Check date-time: </b>
                        <asp:Label ID="UserCheckTime" runat="server" Text='<% #Eval("CheckTime") %>'></asp:Label>
                        <br />
                        <b> Check value: </b>
                        <asp:Label ID="UserActualCheck" runat="server" Text='<% #Eval("CheckValue") %>'></asp:Label>
                        <br />
                        <b> Description: </b>
                        <asp:Label ID="UserDescription" runat="server" Text='<% #Eval("Description") %>'></asp:Label>
                    </div>                    
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
