<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sessions</title>
</head>
<body runat="server" id="BodyTag">
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList runat="server" ID="ColorSelector" AutoPostBack="True" OnSelectedIndexChanged="ColorSelector_IndexChanged">
            <asp:ListItem Value="White" Selected="True">Select color...</asp:ListItem>
            <asp:ListItem Value="Red">Red</asp:ListItem>
            <asp:ListItem Value="Green">Green</asp:ListItem>
            <asp:ListItem Value="Blue">Blue</asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
