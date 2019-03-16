<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Myusercontrol.ascx.cs" Inherits="NormalWebformPage.Myusercontrol" %>
<asp:Label ID="lblfirstname" Text="firstName" runat="server" /> 
<asp:TextBox ID="txtfirstname" runat="server" />
<asp:Label ID="lbllastname" Text="lastName" runat="server"></asp:Label>
<asp:TextBox ID="txtlastname" runat="server" />
<asp:Button ID="btnAdd" Text="Combine" OnClick="btnCombineme" runat="server" />



<p>
    <asp:Label ID="lbldisplay" runat="server" Text=""></asp:Label>
</p>




