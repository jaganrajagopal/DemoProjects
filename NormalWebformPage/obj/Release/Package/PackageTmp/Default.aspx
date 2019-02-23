<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NormalWebformPage._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Sample Grid</h1>
      
        <asp:GridView ID="GridView1" runat="server"  Visible="false">
        </asp:GridView>
        <asp:Button ID="btn" text="Databind" OnClick="bind" runat="server" />
     </div>

    

</asp:Content>
