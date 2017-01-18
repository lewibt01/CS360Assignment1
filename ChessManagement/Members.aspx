<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="ChessManagement.Members" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Member List</h2>
    <p>
        &nbsp;</p>
    <p>
        Select the division to view members of:</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="false">
            <asp:ListItem Value="1">Division 1</asp:ListItem>
            <asp:ListItem Value="2">Division 2</asp:ListItem>
            <asp:ListItem Value="3">Division 3</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </p>
    <p>
        <p class="h3">
        <asp:GridView ID="gridUsers" runat="server" HorizontalAlign="Left" AllowSorting="True" ToolTip="Users" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="fname" HeaderText="First Name" />
                <asp:BoundField DataField="lname" HeaderText="Last Name" />
                <asp:BoundField DataField="username" HeaderText="Username" />
                <asp:BoundField DataField="phoneNumber" HeaderText="Phone Number" />
            </Columns>
        </asp:GridView>
    </p>
    </p>
</asp:Content>
