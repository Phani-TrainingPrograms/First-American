<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="QueryStringPage.aspx.cs" Inherits="SampleWebApp.QueryStringPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <div>
        <h2>QueryString Example</h2>
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
            <asp:Button Text="Submit" OnClick="Unnamed_Click" runat="server" />
        </p>
    </div>
</asp:Content>
