<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnterScores.aspx.cs" Inherits="ChessManagement.Admin.EnterScores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Enter Match Results</h2>
    <p>
        Select week of tournament:</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Week 1</asp:ListItem>
            <asp:ListItem>Week 2</asp:ListItem>
            <asp:ListItem>Week 3</asp:ListItem>
            <asp:ListItem>Week 4</asp:ListItem>
            <asp:ListItem>Week 5</asp:ListItem>
            <asp:ListItem>Week 6</asp:ListItem>
            <asp:ListItem>Week 7</asp:ListItem>
            <asp:ListItem>Week 8</asp:ListItem>
            <asp:ListItem>Week 9</asp:ListItem>
            <asp:ListItem>Week 10</asp:ListItem>
            <asp:ListItem>Week 11</asp:ListItem>
            <asp:ListItem>Week 12</asp:ListItem>
            <asp:ListItem>Week 13</asp:ListItem>
            <asp:ListItem>Week 14</asp:ListItem>
            <asp:ListItem>Week 15</asp:ListItem>
            <asp:ListItem>Week 1 - Rescheduled Matches</asp:ListItem>
            <asp:ListItem>Week 2 - Rescheduled Matches</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Load Matches" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Select Match:</p>
    <p>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Edit Match Results" />
    </p>
    <p>
        &nbsp;</p>
    <h3>Edit Match Results:</h3>
    <p>
        Select White player:</p>
    <p>
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>N/A - Forfeit</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Select match winner:</p>
    <p>
        <asp:DropDownList ID="DropDownList5" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Was match won or forfeit?</p>
    <p>
        <asp:DropDownList ID="DropDownList6" runat="server">
            <asp:ListItem>Won</asp:ListItem>
            <asp:ListItem>Forfeit</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Enter number of moves: (enter 0 if match was forfeit)</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" Text="Save" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
