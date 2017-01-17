<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnterDivisions.aspx.cs" Inherits="ChessManagement.Admin.EnterDivisions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Members to Divisions</h2>
    <p>
        Select a division from the dropdown list:</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Check all members to add or transfer to this division. Remember that each 
        division must have at least 3 members and no more than 12.</p>
    <p>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
    </p>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save" />
    <br />
</asp:Content>
