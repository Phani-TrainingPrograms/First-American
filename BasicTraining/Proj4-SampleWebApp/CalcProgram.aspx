<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="CalcProgram.aspx.cs" Inherits="SampleWebApp.CalcProgram" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <div>
        <h2>Calc Program in ASP.NET</h2>
        <hr />
        <p>
            Enter the First Value :
            <asp:TextBox runat="server" ID ="txtFirstValue" TextMode="Number"/>
        </p>
        <p>
            Enter the Second Value :
            <asp:TextBox runat="server" ID ="txtSecondValue" TextMode="Number"/>
        </p>
        <p>
            Select the operation:
            <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="btnAnswer_Click" runat="server" ID="dpOptions">
                <asp:ListItem Text="Select an option" />
                <asp:ListItem Text="+" />
                <asp:ListItem Text="-" />
                <asp:ListItem Text="X" />
                <asp:ListItem Text="/" />
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label Text="" ID="lblDisplay" runat="server" />
        </p>
    </div>
</asp:Content>
