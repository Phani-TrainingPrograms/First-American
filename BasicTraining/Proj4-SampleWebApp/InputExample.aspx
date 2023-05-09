<%@ Page Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="InputExample.aspx.cs" Inherits="SampleWebApp.InputExample" %>

<asp:Content ContentPlaceHolderID="childContent" runat="server">
    <div>
        <h2>Registration Page in ASP.NET</h2>
        <hr />
        <div>
            <p>
                <asp:Label Text="Enter the Name" runat="server" />
                <asp:TextBox runat="server" ID="txtName" />
            </p>
            <p>
                <asp:Label Text="Enter the Email" runat="server" />
                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" />
            </p>
            <p>
                <asp:Label Text="Enter the Date of Birth" runat="server" />
                <asp:TextBox runat="server" ID="txtDate" TextMode="Date" />
            </p>
            <p>
                <asp:Button Text="Submit" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click"/>
            </p>
        </div>
        <div>
            <asp:Label Text="" runat="server" ID="lblDisplay" />
        </div>
    </div>
</asp:Content>