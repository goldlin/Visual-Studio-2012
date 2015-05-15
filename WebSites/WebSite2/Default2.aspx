<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" Culture="Auto"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CultureInfo Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <% Response.Write("Your current culture: " + System.Globalization.CultureInfo.CurrentCulture.DisplayName + " - " + System.Globalization.CultureInfo.CurrentCulture.Name + "<br/>"); %>
        <% Response.Write("Current date, in a culture specific format: " + DateTime.Now.ToString()); %>
    </div>
    </form>
</body>
</html>
