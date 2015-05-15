<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" UICulture="zh-CN"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblHelloWorld" Text="Hello, world!" ForeColor="Blue" Font-Names="Verdana" meta:resourcekey="lblHelloWorld"></asp:Label><br/>
        <asp:Label runat="server" ID="lblHelloGuys" Text="<%$ Resources:Resource,lblHelloGuys %>"></asp:Label>
    </div>
    </form>
</body>
</html>
