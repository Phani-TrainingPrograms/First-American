<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="RecipiantPage.aspx.cs" Inherits="SampleWebApp.RecipiantPage" %>
<%@ PreviousPageType VirtualPath="~/PreviousPageExample.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <div>
        <h1>The Data provided by the Previous Page</h1>
        <asp:Label Text="" ID="lblDisplay" runat="server" ForeColor="Black" BorderStyle="Dotted" BorderColor="DarkRed" Width="100%" Height="350px" />
    </div>
</asp:Content>
