<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Reference Control="~/UserInfoBoxControl.ascx" %>
<%@ Register tagPrefix="My" tagName="EventUserControl" src="~/EventUserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" id="HelloWorldLabel"></asp:Label>
        <br /><br />
        <asp:TextBox runat="server" id="TextInput" />
        <asp:Button runat="server" id="GreetButton" text="Say Hello!" OnClick="GreetButton_Click" />
        <br/><br/>
        <asp:DropDownList runat="server" id="GreetList" autopostback="true" OnSelectedIndexChanged="GreetList_SelectedIndexChanged">
            <asp:ListItem value="no one">No one</asp:ListItem>
            <asp:ListItem value="world">World</asp:ListItem>
            <asp:ListItem value="universe">Universe</asp:ListItem>
        </asp:DropDownList>
        <br/><br/>
        <My:EventUserControl runat="server" ID="MyEventUserControl" OnPageTitleUpdated="MyEventUserControl_PageTitleUpdated" OnUpdateText="MyEventUserControl_OnUpdateText" />
    </div>
    </form>
    <br/><br/>
    <asp:PlaceHolder runat="server" ID="phUserInfoBox"></asp:PlaceHolder>
    <br/><br/>
    <asp:HyperLink runat="server" NavigateUrl="~/Default2.aspx" Text="Default2"></asp:HyperLink>
</body>
</html>
