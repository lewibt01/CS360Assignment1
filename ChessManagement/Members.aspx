<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="ChessManagement.Members" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Member List</h2>
    <p>
        &nbsp;</p>
    <p>
        Select the division to view members of:</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </p>
    <p>
        <asp:TextBox ID="TextBox1" ReadOnly="true" runat="server"></asp:TextBox>
    </p>
</asp:Content>
