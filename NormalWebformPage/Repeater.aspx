<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="NormalWebformPage.Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="repeaterGrid" runat="server">
                <HeaderTemplate> 
                    <table>
                        <tr>
                            <td>PersonId</td><td>FirstName</td><td>Lastname</td>
                        </tr>
                       
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table>
                        <tr>
                           <td>
                            <%#DataBinder.Eval(Container,"DataItem.Personid")%>
                          </td>
                           <td>
                            <%#DataBinder.Eval(Container,"DataItem.FirstName")%>
                        </td>
                           <td>
                            <%#DataBinder.Eval(Container,"DataItem.LastName")%>
                        </td>
                         </tr>
                        </table>
                </ItemTemplate>
                <AlternatingItemTemplate>
                   <table>
                        <tr>
                           <td>
                            <%#DataBinder.Eval(Container,"DataItem.Personid")%>
                          </td>
                           <td>
                            <%#DataBinder.Eval(Container,"DataItem.FirstName")%>
                        </td>
                           <td>
                            <%#DataBinder.Eval(Container,"DataItem.LastName")%>
                        </td>
                         </tr>
                        </table>

                </AlternatingItemTemplate>

                    <FooterTemplate>
                        Displaying the students details
                    </FooterTemplate>

            </asp:Repeater>
        </div>
    </form>
</body>
</html>
