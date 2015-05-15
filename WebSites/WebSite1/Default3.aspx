<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>
<%@ OutputCache Duration="120" VaryByParam="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Caching</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Cached datestamp: 
        <%= DateTime.Now.ToString() %><br/>
        <asp:DropDownList runat="server" ID="ddNumber" AutoPostBack="True">
            <asp:ListItem Value="1">1</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
        </asp:DropDownList>
        Fresh datestamp:
        <asp:Substitution runat="server" ID="UnCachedArea" MethodName="GetFreshDateTime"/>
    </div>
    </form>
</body>
</html>
