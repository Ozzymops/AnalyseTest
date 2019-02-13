<%@ Page Title="" Theme="DefaultTheme" Language="C#" MasterPageFile="~/Views/TestMaster.Master" AutoEventWireup="true" CodeBehind="UF01.aspx.cs" Inherits="TestAnalyse.Views.UF01" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
        <h1>UF-01</h1>
    </div>
    <div id="body">
        <div runat="server" id="client">
            <h1 class="centered_header">Welk artikel deel je?</h1>
            <!-- Antwoorden -->
            <div style="display: block; margin-left: auto; margin-right: auto; width: 670px">
                <div id="article_1" class="article">
                    <asp:Label runat="server" ID="ArticleName_1" Text=""></asp:Label>
                </div>
                <div id="article_2" class="article">
                    <asp:Label runat="server" ID="ArticleName_2" Text=""></asp:Label>
                </div>
                <div id="article_3" class="article">
                    <asp:Label runat="server" ID="ArticleName_3" Text=""></asp:Label>
                </div>
            </div>
            <div style="display: block; margin-left: auto; margin-right: auto; width: 670px">
                <div id="article_4" class="article">
                    <asp:Label runat="server" ID="ArticleName_4" Text=""></asp:Label>
                </div>
                <div id="article_5" class="article">
                    <asp:Label runat="server" ID="ArticleName_5" Text=""></asp:Label>
                </div>
                <div id="article_6" class="article">
                    <asp:Label runat="server" ID="ArticleName_6" Text=""></asp:Label>
                </div>
            </div>
        </div>
        <!-- Timer stuff -->
        <div>
            <asp:ScriptManager runat="server" ID="ScriptManager" />
            <asp:Timer runat="server" ID="Timer" Interval="250" OnTick="Timer_Tick" />
            <asp:UpdatePanel runat="server" ID="Update_1">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer" EventName="Tick" />
                </Triggers>
                <ContentTemplate>
                    <div runat="server" id="TimerBar" class="timer_bar" title="800"></div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="timer_bar" style="background-color: orangered; opacity: 0.5; margin-top: -100px;"></div>
        </div>     
    </div>
</asp:Content>
