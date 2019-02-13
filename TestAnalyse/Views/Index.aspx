<%@ Page Title="" Language="C#" MasterPageFile="~/Views/TestMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TestAnalyse.Views.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Kies een test:</h1>
        <asp:BulletedList runat="server" ID="IndexBulletedList" DisplayMode="LinkButton" OnClick="IndexBulletedList_Click">
            <asp:ListItem Value="Views/ChatTest">Chat</asp:ListItem>
            <asp:ListItem Value="Views/UF01">UF01</asp:ListItem>
        </asp:BulletedList>
    </div>
</asp:Content>
