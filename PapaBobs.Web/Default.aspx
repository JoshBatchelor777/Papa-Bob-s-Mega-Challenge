<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobs.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <a href="Order.aspx">Order Page</a>
    <a href="Default.aspx">Database Page</a>
    <a href="Success.aspx">Success Page</a><b />
    <br />
    <br />
    <form id="form1" runat="server">
    
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Width="55px"/>
    
        <br />
&nbsp;<div>
    
        <asp:GridView ID="ordersGridView" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
    
        <br />
        <br />

    </div>
    </form>
</body>
</html>
