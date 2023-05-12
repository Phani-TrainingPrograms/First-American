<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="PreviousPageExample.aspx.cs" Inherits="SampleWebApp.PreviousPageExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <div>
        <h2>PreviousPage Example</h2>
        <p>
            Enter the Name: <asp:TextBox runat="server" ID ="txtName"/>
        </p>
        <p>
            Enter the Email: <asp:TextBox runat="server" ID ="txtEmail" TextMode="Email"/>
        </p>
        <p>
            Enter the Date of Birth: <asp:TextBox runat="server" ID ="txtDob" TextMode="Date"/>
        </p>
        <p>
            <asp:Button Text="Post Data" runat="server" PostBackUrl="~/RecipiantPage.aspx" />
        </p>
    </div>
</asp:Content>
