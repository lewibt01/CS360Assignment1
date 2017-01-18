<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssignTournamentOfficials.aspx.cs" Inherits="ChessManagement.Admin.AssignTournamentOfficials" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Assign Tournament Officials</h2>
    <p>
        Select member(s) from the following list to be assigned Tournament Official 
        administrator permissions</p>
    <p>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Apply" OnClick="makeOfficial" />
    </p>
</asp:Content>
