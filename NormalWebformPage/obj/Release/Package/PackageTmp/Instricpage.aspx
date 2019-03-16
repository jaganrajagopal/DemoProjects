<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instricpage.aspx.cs" Inherits="NormalWebformPage.Instricpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">  
        .auto-style1 {  
            width: 478px;  
        }  
        .auto-style2 {  
            width: 224px;  
        }  
        .auto-style3 {  
            width: 219px;  
        }  
        .auto-style4 {  
            width: 218px;  
        }  
    </style>  
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:Label ID="lblData" runat="server" value="data"></asp:Label>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />        
        
        <asp:Label ID="Name" Text="employeeName"  runat="server"></asp:Label>
       
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:ListBox ID="listBoxItems" runat="Server" SelectionMode="Multiple"></asp:ListBox>
        
        <asp:Literal ID="literalData" Text="Running Now"  runat="server"></asp:Literal>
         <asp:MultiView ID="MultiView1" runat="server" Visible="true">  
  
                <asp:View ID="View1" runat="server"  > <%- --0 -- %>
                    <table style="width: 100%;">  
                        <tr>  
                            <td class="auto-style4"><strong>Student Details</strong></td>  
  
                        </tr>  
                        <tr>  
                            <td class="auto-style4">Student FirstName</td>  
                            <td>  
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>  
                            <td></td>  
                        </tr>  
                        <tr>  
                            <td class="auto-style4">Student LastName</td>  
                            <td>  
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>  
                            <td> </td>  
                        </tr>  
                        <tr>  
                            <td class="auto-style4"> </td>  
                            <td>  
                                <asp:Button ID="Button2" runat="server"  Text="Next" OnClick="Next_View" />  
                            </td>  
                            <td> </td>  
                        </tr>  
                    </table>  
  
                </asp:View>  
                <asp:View ID="View2" runat="server">  
                    <table style="width: 100%;">  
                        <tr>  
                            <td class="auto-style3"><strong>Student Course Detail</strong></td>  
  
                        </tr>  
                        <tr>  
                            <td class="auto-style3">Student Course</td>  
                            <td>  
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>  
  
                        </tr>  
                        <tr>  
                            <td class="auto-style3">Student Branch</td>  
                            <td>  
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>  
  
                        </tr>  
                        <tr>  
                            <td class="auto-style3">  
                                <asp:Button ID="Button3" runat="server" Text="Previous"  />  
                            </td>  
                            <td>  
                                <asp:Button ID="Button4" runat="server" Text="Next"  />  
                            </td>  
                        </tr>  
                    </table>  
  
  
                </asp:View>  
                <asp:View ID="View3" runat="server">  
  
                    <table style="width: 100%;">  
                        <tr>  
                            <td class="auto-style2"><strong>Student Personal Detail</strong></td>  
  
                        </tr>  
                        <tr>  
                            <td class="auto-style2">Student EmailId</td>  
                            <td>  
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>  
  
                        </tr>  
                        <tr>  
                            <td class="auto-style2">Student City</td>  
                            <td>  
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>  
  
                        </tr>  
                        <tr>  
                            <td class="auto-style2">Student State</td>  
                            <td>  
                                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>  
  
                        </tr>  
                        <tr>  
                            <td class="auto-style2">  
                                <asp:Button ID="Button5" runat="server" Text="Previous"  />  
                            </td>  
                            <td>  
                                <asp:Button ID="Button6" runat="server" Text="Next"  style="height: 26px" />  
                            </td>  
                        </tr>  
                    </table>  
  
                </asp:View>  
                <asp:View ID="View4" runat="server">  
  
                    <table class="auto-style1">  
                        <tr>  
                            <td><strong>Student Details</strong></td>  
  
                            <td> </td>  
  
                        </tr>  
                        <tr>  
                            <td>Student FirstName:</td>  
                            <td>  
                                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>  
                            </td>  
                            <td> </td>  
  
                        </tr>  
                        <tr>  
                            <td>Student LastName:</td>  
  
                            <td>  
                                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>  
                            </td>  
  
                        </tr>  
  
                        <tr>  
                            <td></td>  
                            <td> </td>  
                        </tr>  
                        <tr>  
                            <td><strong>Student Course Details</strong></td>  
                            <td> </td>  
                        </tr>  
  
                        <tr>  
                            <td>Student Course:</td>  
                            <td>  
                                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>  
                            </td>  
                        </tr>  
                        <tr>  
                            <td>Student Branch:</td>  
                            <td>  
                                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>  
                            </td>  
                        </tr>  
  
                        <tr>  
                            <td> </td>  
                            <td> </td>  
                        </tr>  
                        <tr>  
                            <td><strong>Student Personal Details</strong></td>  
                            <td> </td>  
                        </tr>  
                        <tr>  
                            <td>Student EmailId:</td>  
                            <td>  
                                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>  
                            </td>  
                        </tr>  
                        <tr>  
                            <td>Student City:</td>  
                            <td>  
                                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>  
                            </td>  
                        </tr>  
                        <tr>  
                            <td>Student State:</td>  
                            <td>  
                                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>  
                            </td>  
                        </tr>  
  
                    </table>  
                </asp:View>  
            </asp:MultiView>  
        <asp:button ID="btnsubmit" Text="Click Here"  runat="server"  />
        
    </form>
</body>
</html>
