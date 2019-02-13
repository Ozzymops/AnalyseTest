<%@ Page Title="" Language="C#" MasterPageFile="~/Views/TestMaster.Master" Theme="ChatTheme" AutoEventWireup="true" CodeBehind="ChatTest.aspx.cs" Inherits="TestAnalyse.Views.ChatTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Top -->
    <div>
        <h1>Chatteke</h1>
        <h3>Room:</h3>
        <asp:TextBox runat="server" ID="RoomBox" Width="50" CssClass="textbox"></asp:TextBox>
        <asp:Button runat="server" ID="RoomBoxBut" Text="Join" OnClick="RoomBoxBut_Click" CssClass="button" />
    </div>
    <!-- Left -->
    <div id="general">
        <h3>Username:</h3>
        <asp:TextBox runat="server" ID="UsernameBox" CssClass="textbox"></asp:TextBox>
        <asp:Button runat="server" ID="UsernameBoxBut" Text="Change" OnClick="UsernameBoxBut_Click" CssClass="button" />
        <h3>Message:</h3>
        <asp:TextBox runat="server" ID="MessageBox" CssClass="textbox"></asp:TextBox>
        <asp:Button runat="server" ID="MessageBoxBut" Text="Send" OnClick="MessageBoxBut_Click" CssClass="button" />
    </div>
    <!-- Right -->
    <div id="chat">
        <asp:ListBox runat="server" ID="MessagesBox" Width="200" Height="200" CssClass="listbox"></asp:ListBox>
    </div>
</asp:Content>
