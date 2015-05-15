<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Your name:
        <asp:TextBox runat="server" ID="txtName">abc</asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="reqName" ControlToValidate="txtName" ErrorMessage="Please enter your name!" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <br/><br/>
        Small number:
        <asp:TextBox runat="server" ID="txtSmallNumber">2</asp:TextBox><br/>
        Big number:
        <asp:TextBox runat="server" ID="txtBigNumber">3</asp:TextBox><br/>
        <asp:CompareValidator runat="server" ID="cmpNumbers" ControlToValidate="txtSmallNumber" ControlToCompare="txtBigNumber" Operator="LessThan" Type="Integer" ErrorMessage="The first number should be smaller than the second one!" SetFocusOnError="True"></asp:CompareValidator>
        <br/><br/>
        Date:
        <asp:TextBox runat="server" ID="txtDate">01-01-2006</asp:TextBox>
        <asp:RangeValidator runat="server" ID="rngDate" ControlToValidate="txtDate" Type="Date" MinimumValue="01-01-2006" MaximumValue="12-31-2015" ErrorMessage="Please enter a valid date" SetFocusOnError="True"></asp:RangeValidator>
        <br/><br/>
        4 digit number:
        <asp:TextBox runat="server" id="txtNumber">4444</asp:TextBox>
        <asp:RegularExpressionValidator runat="server" id="rexNumber" controltovalidate="txtNumber" validationexpression="^\d{4}$" errormessage="Please enter a 4 digit number!" SetFocusOnError="True"/>
        <br /><br />
        Custom text:
        <asp:TextBox runat="server" ID="txtCustom">aaaa</asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusCustom" ControlToValidate="txtCustom" OnServerValidate="cusCustom_OnServerValidate" ErrorMessage="The text must be exactly 8 characters long!" SetFocusOnError="True"></asp:CustomValidator>
        <br/><br/>
        <asp:Button runat="server" ID="btnSubmitForm" Text="OK" OnClick="btnSubmitForm_Click"/>    
    </div>
    </form>
</body>
</html>
