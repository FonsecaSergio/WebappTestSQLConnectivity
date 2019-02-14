<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebappTestSQLConnectivity._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Test SQL Connectivity</h1>
        <p class="lead">Just a test</p>
    </div>

    <div class="row">
        <div>
            Server Name:
            <asp:TextBox ID="tServer" runat="server" Width="318px">fonsecanet.database.windows.net</asp:TextBox>
            <br />
            User:
            <asp:TextBox ID="tUser" runat="server">fonsecasergio</asp:TextBox>
            <br />
            Password:
            <asp:TextBox ID="tPassword" runat="server" TextMode="Password" AutoPostBack="False"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bConnect" runat="server" Text="Connect" OnClick="bConnect_Click" />
            <br />
            <br />
            <asp:Label ID="tResult" runat="server" Text=""></asp:Label>
            <br />
            <br />
        </div>

    </div>

</asp:Content>
