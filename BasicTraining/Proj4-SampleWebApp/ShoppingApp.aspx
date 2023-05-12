<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingApp.aspx.cs" Inherits="SampleWebApp.ShoppingApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Common/mainStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>FAI Internal Shopping App!!!!</h1>
        <table style="height: 500px; width: 100%">
            <tr>
                <td>
                    <asp:Repeater runat="server" ID="rpProducts" OnItemCommand="rpProducts_ItemCommand">
                        <HeaderTemplate>
                            <table border="1" style="width:250px">
                                <tr>
                                    <th>Name</th>
                                    <th>Image</th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            
                                <tr>
                                    <td><%#Eval("ProductName") %></td>
                                    <td>
                                        <asp:Image ImageUrl='<%#Eval("ProductImage") %>' runat="server" alt='<%#Eval("ProductName")%>' Width="50px" Height="50px" />
                                    </td>
                                    <td>
                                        <asp:Button Text="Select" runat="server" CommandName="select" CommandArgument='<%#Eval("ProductId")%>' />
                                    </td>
                                </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </td>
                <td>
                    <div>
                        <h2>Selected Product Details</h2>
                        <hr />
                        <p>
                            Image:
                        </p>
                        <p>
                            Product ID:<asp:Label runat="server" ID="lblItemId" />
                        </p>
                        <p>
                            Product Name: <asp:TextBox runat="server" ID="txtName"/>
                        </p>
                        <p>
                            Product Price: <asp:TextBox runat="server" ID="txtPrice"/>
                        </p>
                        <p>
                            <asp:Button Text="Buy Now!!!" runat="server" OnClick="Unnamed1_Click" style="margin-top: 0px" />
                        </p>
                    </div>
                    <div>
                         <asp:DataList  runat="server" ID="dtRecent" RepeatColumns="5">
                        <ItemTemplate>
                            <div>
                                <h3><%#Eval("ProductName")%></h3>
                                <hr />
                                <asp:Image Width="100px" Height="100px" ImageUrl='<%#Eval("ProductImage")%>' runat="server" />
                            </div>
                        </ItemTemplate>
                        <ItemStyle BorderStyle="Solid" BackColor="Yellow" ForeColor="Blue" />
                        <AlternatingItemTemplate>
                            <div>
                                <h3><%#Eval("ProductName")%></h3>
                                <hr />
                                <asp:Image Width="100px" Height="100px" ImageUrl='<%#Eval("ProductImage")%>' runat="server" />
                            </div>
                        </AlternatingItemTemplate>
                        <AlternatingItemStyle BorderStyle="Dashed" BackColor="LightBlue" ForeColor="Yellow" />
                        <SeparatorTemplate>
                            <hr style="color: red" />
                        </SeparatorTemplate>
                    </asp:DataList>
                    </div>
                </td>
               
            </tr>
        </table>
    </form>
</body>
</html>
