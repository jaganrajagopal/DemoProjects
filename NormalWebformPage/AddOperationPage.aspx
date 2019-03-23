<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOperationPage.aspx.cs" Inherits="NormalWebformPage.AddOperationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="firstvalue"></asp:Label>
            <asp:TextBox ID="txtinput1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="secondvalue"></asp:Label>
            <asp:TextBox ID="txtinput2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbldisplay" runat="server" Text="Label"></asp:Label>
        </div>
        <div><asp:Button ID="btn" OnClick="btnclick" runat="server" Text="Button" /></div>
        
    </form>
</body>
</html>
