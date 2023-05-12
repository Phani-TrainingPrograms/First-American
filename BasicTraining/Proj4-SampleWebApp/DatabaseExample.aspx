<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatabaseExample.aspx.cs" Inherits="SampleWebApp.DatabaseExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="h1">Disconnected Architecture</h1>
        <hr />
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <asp:ListBox ID="lstNames" runat="server" CssClass="list-group" Height="598px" AutoPostBack="True" OnSelectedIndexChanged="lstNames_SelectedIndexChanged"/>
                </div>
                <div class="col-md-6">
                    <h2 class="h2">Details of Employee</h2>
                    <div class="row">
                        <span class="col-md-5">Employee ID:</span>
                        <asp:TextBox Enabled="false" ID="txtId" runat="server" CssClass="col-md-6  my-3 form-control"  />
                    </div>
                    <div class="row">
                        <span class="col-md-5">Employee Name:</span>
                        <asp:TextBox runat="server" ID="txtName" CssClass="col-md-6 my-3 form-control "  />
                    </div>
                    <div class="row">
                        <span class="col-md-5">Employee Phone:</span>
                        <asp:TextBox runat="server" ID="txtPhone" CssClass="col-md-6  my-3 form-control"  />
                    </div>
                    <div class="row">
                        <span class="col-md-5">Employee Salary:</span>
                        <asp:TextBox runat="server" ID="txtSalary" CssClass="col-md-6  my-3 form-control" />
                    </div>

                    <div class="row">
                        <asp:Button Text="Save Changes" CssClass="btn btn-success" runat="server" ID="btnSave" OnClick="btnSave_Click"/>
                        <asp:Button Text="Add Employee" CssClass="btn btn-success" runat="server" ID="btnAdd" OnClick="btnAdd_Click"/>
                    </div>
                    <div class="row">
                        <asp:Label Text="" CssClass="text-danger" runat="server" ID="lblError"/>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
