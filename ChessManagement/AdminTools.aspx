<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminTools.aspx.cs" Inherits="ChessManagement.AdminTools" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Administrative Tools</h3>
    <br />
    The following tools are available to the Tournament Officials and the System Administrator
    <br />
    <br />
    <button onclick="location.href='Admin/EnterScores'" type="button">Enter Weekly Tournament Results</button>
    <br />
    <br />
    <button onclick="location.href='Admin/EnterDates'" type="button">Schedule Tournament Dates</button>
    <br />
    <br />
    <button onclick="location.href='Admin/CreateDivisions'" type="button">Create Divisions</button>
    <br />
    <br />
    <br />
    The following tools are only available for the System Administrator
    <br />
    <br />
    <button onclick="location.href='Admin/AssignDivisions'" type="button">Assign Members to Divisions</button>
    <br />
    <br />
    <button onclick="location.href='Admin/AssignTournamentOfficials'" type="button">Assign New Tournament Officials</button>
    <br />
    <br />
    <button onclick="location.href='Admin/EditMembers'" type="button">Edit or Remove Members</button>
    <br />
    </asp:Content>
