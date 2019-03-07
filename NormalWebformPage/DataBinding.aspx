<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBinding.aspx.cs" Inherits="NormalWebformPage.DataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridview" runat="server"  AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" onrowediting="gvPerson_RowEditing" OnPageIndexChanging="gvPerson_PageIndexChanging" OnRowDataBound="gvPerson_RowDataBound"
                OnRowUpdating="gvPeron_RowUpdating" OnRowDeleting="gvPerson_RowDeleting" onrowcancelingedit="gvPerson_RowCancelingEdit"  onsorting="gvPerson_Sorting">
                <AlternatingRowStyle BackColor="White" />             
                <Columns>
                    <asp:CommandField ShowEditButton="True" /> 
                     <asp:CommandField ShowDeleteButton="True" /> 
                    <asp:BoundField Datafield="personid" HeaderText="PersonId" ReadOnly="true" SortExpression="personid" />
                   
            <asp:TemplateField HeaderText="LastName" SortExpression="LastName"> 
                <EditItemTemplate> 
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("LastName") %>'></asp:TextBox> 
            </EditItemTemplate> 
            <ItemTemplate> 
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("LastName") %>'></asp:Label> 
            </ItemTemplate> 
        </asp:TemplateField> 
        <asp:TemplateField HeaderText="FirstName" SortExpression="FirstName"> 
            <EditItemTemplate> 
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("FirstName") %>'></asp:TextBox> 
            </EditItemTemplate> 
            <ItemTemplate> 
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("FirstName") %>'></asp:Label> 
            </ItemTemplate> 
        </asp:TemplateField> 
                </Columns>
                
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
               
            </asp:GridView>
        </div>
    </form>
</body>
</html>
