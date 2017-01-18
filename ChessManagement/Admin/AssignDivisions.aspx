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
        <asp:ListItem Value="1">Division 1</asp:ListItem>
        <asp:ListItem Value="2">Division 2</asp:ListItem>
        <asp:ListItem Value="3">Division 3</asp:ListItem>
    </asp:DropDownList>
</p>

<p>
    <asp:Button ID="submitButton" runat="server" OnClick="assignDivision" Text="Assign Member" visible=true/>
</p>
</asp:Content>
