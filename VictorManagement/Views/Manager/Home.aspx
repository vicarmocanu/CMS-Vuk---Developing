<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Manager/ManagementMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KibistaManagement.Views.Management.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../Style/StyleSheet.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-7">
            <asp:Repeater ID="EventList" runat="server">
            <ItemTemplate>
                <div id="managerHomeRepeater">
                    <b>Event name: </b>
                    <asp:Label ID="EventNameLabel" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    <br />
                    <b>Start time: </b>
                    <asp:Label ID="EventStartLabel" runat="server" Text='<%# Eval("StartTime") %>'></asp:Label>
                    <b>End time:</b>
                    <asp:Label ID="EventEndLabel" runat="server" Text='<%# Eval("EndTime") %>'></asp:Label>
                    <br />
                    <b>Description: </b>
                    <asp:Label ID="EventDescription" runat="server" Text='<%# Eval("Descrip") %>'></asp:Label>
                    <br />
                    <b>Location: </b>
                    <asp:Label ID="EventLocation" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
                    <div class="row">
                        <div class="col-md-1 col-md-offset-9">
                            <asp:Button Text="Tasks" runat="server" id="taskButton" ValidationGroup="save" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
            </asp:Repeater>
        </div>

        <div class="col-md-4" id="managerHomeTasks"  style="visibility: hidden;">

        </div>
    </div>
    
</asp:Content>
