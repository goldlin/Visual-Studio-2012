<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ViewState</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="NameField"></asp:TextBox>
        <asp:Button runat="server" ID="SubmitForm" OnClick="SubmitForm_OnClick" Text="Submit & set name"/>
        <asp:Button runat="server" ID="RefreshPage" Text="Just submit"/>
        <asp:Button runat="server" ID="SendMail" Text="Send mail" OnClick="SendMail_OnClick"/>
        <br /><br />
        <asp:FileUpload runat="server" ID="FileUploadControl"/>
        <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="UploadButton_OnClick"/>
        <br/><br/>
        Name retrieved from ViewState: <asp:Label runat="server" ID="NameLabel" />
    </div>
    </form>
</body>
</html>
