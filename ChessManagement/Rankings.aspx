<%@ Page Title="Rankings" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rankings.aspx.cs" Inherits="ChessManagement.Rankings" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Rankings by Division</h2>
    <p>The rankings are determined by the total score of each member. They are updated for each division after the scores for the weekly matches have been recorded.</p>
    <p>Please select a division from the following dropdown box:</p>

    <address>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </address>
    <address>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </address>
    <address>
        <asp:TextBox ID="TextBox1" ReadOnly="true" runat="server"></asp:TextBox>
    </address>
</asp:Content>