<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssignDivisions.aspx.cs" Inherits="ChessManagement.Admin.AssignDivisions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Assign Members to Divisions</h2>
<p>
    Select a member from the dropdown box</p>
<p>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
</p>
<p>
    Select the division to place the member in:</p>
<p>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
</p>
</asp:Content>
