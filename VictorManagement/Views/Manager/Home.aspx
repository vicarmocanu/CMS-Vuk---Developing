<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Management/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KibistaManagement.Views.Management.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="EventList" runat="server">
        <ItemTemplate>
            <div>
                <asp:Label ID="EventNameLabel" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                <asp:Label ID="EventStartLabel" runat="server" Text='<%# Eval("StartTime") %>'></asp:Label>
                <asp:Label ID="EventEndLabel" runat="server" Text='<%# Eval("EndTime") %>'></asp:Label>
                <asp:Label ID="EventDescription" runat="server" Text='<%# Eval("Descrip") %>'></asp:Label>
                <asp:Label ID="EventLocation" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
