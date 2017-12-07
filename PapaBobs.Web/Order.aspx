<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="PapaBobs.Web.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <a href="Order.aspx">Order Page</a>
    <a href="Default.aspx">Database Page</a>
    <a href="Success.aspx">Success Page</a><b />
    <b />
    <b />
        <form id="form1" runat="server">
            <h2>Papa Bob's&#39; Pizza</h2>
        <h4>
            Pizza to Code by</h4>
        <hr />
        <p>
            Size:</p>

        <asp:DropDownList ID="sizeList" runat="server">
        <asp:ListItem Selected="True" Value="Small">Small (12&quot; - $12</asp:ListItem>
        <asp:ListItem Value="Medium">Medium (15&quot; - $15)</asp:ListItem>
        <asp:ListItem Value="Large">Large (10&#39; - $100)</asp:ListItem>
        </asp:DropDownList>
        <p>
            Crust:</p>
        <p>
            <asp:DropDownList ID="crustList" runat="server">
                <asp:ListItem Selected="True">Regular</asp:ListItem>
                <asp:ListItem>Thick</asp:ListItem>
                <asp:ListItem>Thin</asp:ListItem>
            </asp:DropDownList>
        </p>
            <p>
    <b />
                <asp:CheckBox ID="pepCheck" runat="server" Text="Pepperoni" />
                </b>
        </p>
            <p>
    <b />
                <asp:CheckBox ID="sausCheck" runat="server" Text="Sausage" />
                </b>
        </p>
            <p>
    <b />
                <asp:CheckBox ID="gpCheck" runat="server" Text="Green Peppers" />
                </b>
        </p>
            <p>
    <b />
                <asp:CheckBox ID="oniCheck" runat="server" Text="Onions" />
                </b>
        </p>
        <p>
            Name:</p>
        <p>
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Address:</p>
        <p>
            <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Zip:</p>
        <p>
            <asp:TextBox ID="zipTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Phone:</p>
        <p>
            <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
        </p>
        <h3>
            Payment:</h3>
        <p>
    <b />
            <asp:RadioButton ID="cashRButton" runat="server" GroupName="paymentGroup" Text="Cash" Checked="True" />
            </b>
        </p>
            <p>
    <b />
                <asp:RadioButton ID="creditRButton" runat="server" GroupName="paymentGroup" Text="Credit" />
                </b>
        </p>
            <p>
    <b />
                <asp:RadioButton ID="rpRButton" runat="server" GroupName="paymentGroup" Text="Republic Credits" />
                </b>
        </p>
        <p>
            <asp:Button ID="orderButton" runat="server" Text="Order" OnClick="orderButton_Click" 
                OnClientClick="window.open('Success.aspx', 'Default.aspx');"/>
        </p>
        <h3>
            Total Cost:
            <asp:Label ID="costLabel" runat="server"></asp:Label>
        </h3>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        </form>
    
</body>
</html>
