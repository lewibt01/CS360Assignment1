<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditMembers.aspx.cs" Inherits="ChessManagement.Admin.EditMembers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit or Remove Members</h2>
    <br />
    <p>
        Please select a member:</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </p>
    <h3>
        <br />
        Edit Member Information:<br />
    </h3>
    <p>
        Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Phone Number:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Email Address:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Reset Password?
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Division:
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Save" />
    </p>
    <h3>
        <br />
        Remove Member:</h3>
    <p>
        Removing a member cannot be undone.</p>
    <p>
        <asp:Button ID="Button3" runat="server" Text="Remove Member from Chess Club" />
    </p>
<p>
        &nbsp;</p>
</asp:Content>
