<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instricpage.aspx.cs" Inherits="NormalWebformPage.Instricpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:Label ID="lblData" runat="server" value="data"></asp:Label>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />        
        
        <asp:Label ID="Name" Text="employeeName" runat="server"></asp:Label>
       
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:button ID="btnsubmit" Text="Click Here" runat="server" OnClick="btnsubmit_Click" />
    </form>
</body>
</html>
