<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webcontrol.aspx.cs" Inherits="NormalWebformPage.Webcontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click">
                <asp:ListItem> Heritage</asp:ListItem>
                <asp:ListItem> Thirumala</asp:ListItem>
            </asp:BulletedList>
            <asp:Button ID="btnButton" Text="Get Click Here" BorderWidth="10px" OnClick="BtnClick" runat="server" BackColor="#FFCCFF" />
            
        </div>
        <asp:DropDownList ID="DropDownList2" runat="server">
            
        </asp:DropDownList>
        <asp:CheckBoxList ID="chkProduct" runat="server"></asp:CheckBoxList>
        <asp:HiddenField ID="hdnfields" value="workingfine" runat="server" />
        <asp:Image ImageUrl="~/Google.jpg" runat="server"/>
        <asp:ImageButton ID="imgButton" ImageUrl="~/Google.jpg" AlternateText="Image Button" OnClick="ImageButton_clicked" runat="server"/>
        <asp:LinkButton ID="linkbutton" Text="Link the action" PostBackUrl="~/Contact.aspx" runat="server">LinkButton</asp:LinkButton>
    </form>
    
</body>
</html>
