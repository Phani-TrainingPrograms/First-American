<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="SampleWebApp.Validation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <div>
        <p>
            Enter the Name : 
            <asp:TextBox runat="server" ID="txtName"/>
            <span>
                <asp:RequiredFieldValidator ErrorMessage="Name is mandatory"      ControlToValidate="txtName" ForeColor="IndianRed" runat="server" />
            </span>
        </p>
        <p>
            Enter the Email : 
            <asp:TextBox runat="server" ID="txtEmail"/>
            <span>
                <asp:RegularExpressionValidator ErrorMessage="Email is not in a proper Format" ControlToValidate="txtEmail" runat="server" ForeColor="IndianRed" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
            </span>
        </p>
        <p>
            Enter the Password : 
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"/>
            <span>
                <asp:RequiredFieldValidator ErrorMessage="Password is must" ControlToValidate="txtPassword" runat="server"  ForeColor="IndianRed"/>
            </span>
        </p>
        <p>
            Retype Password : 
            <asp:TextBox runat="server" ID="txtRetype"/>
            <span>
                <asp:CompareValidator ErrorMessage="Password Mismatch" ControlToValidate="txtRetype" ControlToCompare="txtPassword" Type="String" runat="server"  ForeColor="IndianRed"/>
            </span>
        </p>
        <p>
            Enter the Age : 
            <asp:TextBox runat="server" ID="txtAge"/>
            <span>
                <asp:RangeValidator ErrorMessage="Age should b/w 18 to 45" ControlToValidate="txtAge" MinimumValue="18" MaximumValue="45" Type="Integer" runat="server" ForeColor="IndianRed" />
            </span>
        </p>
        <p>
            Enter the  Job U want to Apply: 
            <asp:TextBox runat="server" ID="txtJob"/>
            <span>
                <asp:CustomValidator ErrorMessage="Job is not available with Us" ControlToValidate="txtJob" runat="server" ForeColor="IndianRed" OnServerValidate="Unnamed_ServerValidate" />
            </span>
        </p>
        <p>
            <asp:Button Text="Submit" ID="btnSubmit" runat="server" />
        </p>
    </div>
</asp:Content>
