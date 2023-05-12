<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="SessionExample.aspx.cs" Inherits="SampleWebApp.SessionExample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <div>
        <h2>Storing Session Objects</h2>
        <p>
            Enter the Name: <asp:TextBox runat="server" ID="txtName" />
        </p>
        <p>
            Enter the Email: <asp:TextBox runat="server" ID="txtEmail" />
        </p>
        <p>
            Enter the Date of Birth: <asp:TextBox TextMode="Date" runat="server" ID="txtDob" />
        </p>
        <p>
            <asp:Button Text="Store in Session" runat="server" OnClick="Unnamed1_Click" />
        </p>
        <p style="color : orangered">
            <asp:Label Text="" ID="lblStatus" runat="server" />
        </p>
    </div>
</asp:Content>
