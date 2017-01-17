<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateDivisions.aspx.cs" Inherits="ChessManagement.Admin.CreateDivisions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Create New Divisions</h2>
    <p>
        Type the name of the new division:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Check the names of members you would like to add or transfer to this division. 
        Each division must have a minimum of three players to begin the tournament.</p>
    <p>
&nbsp;<asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </p>
</asp:Content>
