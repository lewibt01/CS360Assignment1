<%@ Page Title="EnterDates" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnterDates.aspx.cs" Inherits="ChessManagement.Admin.EnterDates" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Schedule Tournament Dates</h2>
    <p>Choose the scheduled date:</p>
    <p>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p>Select Player 1 from the following dropdown list:</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" 
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p>Select Player 2 from the following dropdown list:</p>
    <p>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </p>
    <p>
        &nbsp;</p>
    

</asp:Content>
