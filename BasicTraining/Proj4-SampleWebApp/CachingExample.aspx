<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="CachingExample.aspx.cs" Inherits="SampleWebApp.CachingExample" %>
<%@ Register Src="~/Controls/TimeControl.ascx" TagPrefix="fai" TagName="time" %>
<%--<%@ OutputCache  VaryByParam="City" Duration="60" %> --%>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <div>
        <h3>Caching Example</h3>
        <asp:Label text="" ID="lblTime" runat="server" />
    </div>

    <div>
        <h2>Caching Different Versions of the page</h2>
        <p>
            The Time in <asp:dropdownlist runat="server" ID="dpList" Height="28px" OnSelectedIndexChanged="dpList_SelectedIndexChanged" Width="185px" AutoPostBack="True">
                <asp:listitem text="New York" />
                <asp:listitem text="London" />
                <asp:listitem text="New Delhi" />
                <asp:listitem text="Tokyo" />
            </asp:dropdownlist>
            is :<asp:label text="" runat="server"  ID="lblCityTime"/>
        </p>
    </div>
    <div>
        <fai:time runat="server" />
    </div>

</asp:Content>
