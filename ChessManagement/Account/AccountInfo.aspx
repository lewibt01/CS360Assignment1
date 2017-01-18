<%@ Page Title="AccountInfo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AccountInfo.aspx.cs" Inherits="ChessManagement.Account.AccountInfo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Account Information</h2>
    <p class="row">My Chess profile:</p>
    <p><span class="h4">Name: </span></p>
    <p class="h4">Username:
        <asp:LoginName ID="LoginName1" runat="server" />
    </p>
    <p class="h4">E-mail: 
        <asp:Label ID="labelEmail" runat="server"></asp:Label>
    </p>
    <p class="h4">Division:
        <asp:Label ID="labelDivision" runat="server" Text="Unknown"></asp:Label>
    </p>
    <p class="h4">Points:
        <asp:Label ID="labelPoints" runat="server" Text="0"></asp:Label>
    </p>
    <p class="h4">Ranking:
        <asp:Label ID="labelRanking" runat="server" Text="#1 out of 10"></asp:Label>
    </p>
    <p class="h4">Match History:</p>
    <p class="h3">
        <asp:Table ID="tableMatches" runat="server" HorizontalAlign="Left">
        </asp:Table>
    </p>
</asp:Content>
