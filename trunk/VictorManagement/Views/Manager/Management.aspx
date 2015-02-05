<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="KibistaManagement.Views.Management.Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-md-6">
            <asp:Panel ID="CreateEventPanel" runat="server" DefaultButton ="btnCreate" Font-Size="Medium" Font-Name="Arial">
                <b> Name: </b>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="nameFieldValidator" runat="server" ErrorMessage="Please specify the name of the event" 
                    ControlToValidate="txtName" ValidationGroup="save" ForeColor="Red" />
                <br />

                <b> Description: </b>
                <asp:TextBox ID="txtDescrip" runat="server"></asp:TextBox>
                <br />

                <b> Start time: </b>
                <asp:TextBox ID ="txtStartTime" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="startTimeFieldValidator" runat="server" ErrorMessage="Please specify the start date and time"
                    ControlToValidate="txtStartTime" ValidationGroup="save" ForeColor="Red" />
                <br />
                <asp:Label Text="Model: YYYY-MM-DD HH:mm:ss" ForeColor="White" runat="server"/>
                <br />

                <b> End time: </b>
                <asp:TextBox ID ="txtEndTime" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="endTimeFieldValidator" runat="server" ErrorMessage="Please specify the end date and time" 
                    ControlToValidate="txtEndTime" ValidationGroup="save" ForeColor="Red" />
                <br />

                <b> Location: </b>
                <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                <br />

                <asp:Button runat="server" ValidationGroup="save" Text="Create" id="btnCreate" OnClick="btnCreate_Click" />
            </asp:Panel>
            <br />

            <asp:Panel ID="createTaskPanel" runat="server" Visible="false" DefaultButton ="btnTaskCreate" Font-Size="Medium" Font-Name="Arial">
                <asp:Label runat="server" text="Event succesfully created. You may now add tasks."></asp:Label>
                <asp:Button runat="server" Text="Add task" ID="btnTaskCreate" OnClick="btnTaskCreate_Click" />
            </asp:Panel>

            <asp:Panel ID="createTeamPanel" runat="server" Visible="false" DefaultButton ="btnAddTeam" Font-Size="Medium" Font-Name="Arial">
                <asp:Label runat="server" text="Event succesfully created. You may now add tasks."></asp:Label>
                <asp:Button runat="server" Text="Add team members" ID="btnAddTeam" OnClick="btnAddTeam_Click" />
            </asp:Panel>
        </div> 

    </div>
</asp:Content>
