<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="KibistaManagement.Views.Customer.Verify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Selection section -->
    <div class="row" style="padding-top:40px;">

        <div class="col-md-6 col-md-offset-1">
            <asp:Label runat="server"> <b> Event: </b></asp:Label>
            <asp:DropDownList ID="eventsList" runat="server" OnSelectedIndexChanged="eventsList_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:Button ID="getTasks" Text="Get tasks" OnClick="getTasks_Click" runat="server" />
            <asp:DropDownList ID="tasksList" runat="server" OnSelectedIndexChanged="tasksList_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:Button ID="taskDetails" Text="Get task details" OnClick="taskDetails_Click" runat="server" />            
        </div>

    </div>

    <!--Event description and performing the check-->
    <div class="row" style="padding-top:20px;">

        <!--The task description-->
        <div class="col-md-5 col-md-offset-1">
            <asp:Panel runat="server"  ID="TaskDescriptionPanel" Visible="false">
                <b>Name:</b>
                <asp:Label ID="TaskName" runat="server"></asp:Label>
                <br />
                <b>Description: </b>
                <asp:Label ID="TaskDescription" runat="server"></asp:Label>
                <br />
                <asp:Button ID="checkButton" runat="server" Text="Perform check" OnClick="checkButton_Click"/>
            </asp:Panel>
           
        </div>

        <!--The check-->
        <div class="col-md-5 col-md-offset-1">
            <asp:Panel runat="server" ID="PerformCheckPanel" Visible="false">
                <asp:Label runat="server" Text="Has this particular task been completed?"></asp:Label>
                <br />
                <asp:Label runat="server" Text="Yes"></asp:Label>
                <asp:CheckBox runat="server" ID="yesCheck"/>
                <br />
                <asp:Label runat="server" Text="No"></asp:Label>
                <asp:CheckBox runat="server" ID="noCheck"/>
                <br />
                <asp:Label runat="server" Text="Only one check at a time" ForeColor="Red" Visible ="false" ID="twoChecks"></asp:Label>
                <br />
                <asp:Label runat="server" Text="Your comment:"></asp:Label>
                <br />
                <asp:TextBox runat="server" TextMode="multiline" ID="userCommentTextBox"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="completeCheck" Text="Complete check" OnClick="completeCheck_Click"/>
                <asp:Label runat="server" ID="warningCheck" Text="Please check either yes or no" ForeColor ="Red" Visible="false"></asp:Label>
            </asp:Panel>
        </div>
    </div>   
</asp:Content>
