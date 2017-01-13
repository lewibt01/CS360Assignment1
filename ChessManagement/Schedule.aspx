<%@ Page Title="Schedule" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="ChessManagement.Schedule" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Schedule</h2>
    <p>This schedule will display matches by division.</p>
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
        BorderColor="Black" font-family= "Helvetica Neue, Helvetica,Arial, sans-serif" 
        Font-Size="12pt" ForeColor="Black" Height="450px" NextPrevFormat="ShortMonth" 
        Width="1000px"  BorderStyle="Solid" 
        CellSpacing="1" ToolTip="Event Calendar">
        <DayHeaderStyle Font-Bold="True" Font-Size="10pt" ForeColor="#003879" BackColor="#d8d8da"
            Height="10pt" />
        <DayStyle BackColor="#9b9b9c" />
        <NextPrevStyle Font-Bold="True" Font-Size="10pt" ForeColor="White" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#003879" ForeColor="White" />
        <TitleStyle BackColor="#003879" Font-Bold="True" 
            Font-Size="14pt" ForeColor="White" BorderStyle="Solid" Height="14pt" />
        <TodayDayStyle BackColor="#58585a" ForeColor="White" />
    </asp:Calendar>
</asp:Content>
