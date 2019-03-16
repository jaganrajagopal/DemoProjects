<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequiredFieldValidator.aspx.cs" Inherits="NormalWebformPage.RequiredFieldValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtdata"  runat="server">
            </asp:TextBox>
            <tr>
         <td class="style3">
            Class:
         </td>

         <td class="style2">
            <asp:TextBox ID="txtclass" runat="server"></asp:TextBox>
         </td>

         <td>
            <asp:RangeValidator ID="rvclass" 
               runat="server" ControlToValidate="txtclass" 
               ErrorMessage="Enter your class (6 - 12)" MaximumValue="12" 
               MinimumValue="6" Type="Integer">
            </asp:RangeValidator>

             <asp:HiddenField ID="hddn" runat="server" />
         </td>
      </tr>


        <tr>
         <td class="style3">
            Email:
         </td>

         <td class="style2">
            <asp:TextBox ID="txtemail" runat="server" style="width:250px">
            </asp:TextBox>
         </td>

         <td>
            <asp:RegularExpressionValidator ID="remail" runat="server" 
               ControlToValidate="txtemail" ErrorMessage="Enter your email" 
               ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
            </asp:RegularExpressionValidator>
         </td>
      </tr>
            <!--<asp:TextBox ID="txtsecondata"  runat="server">
            </asp:TextBox>
            <!--<asp:RangeValidator ID="rangeField" runat="server" ControlToValidate="txtdata" Type="Integer" MinimumValue="10" MaximumValue="20" ErrorMessage="Please select from 10 to 20" />-->

           <!-- <asp:CompareValidator ID="compareField" runat="server" ControlToValidate="txtdata"  ControlToCompare="txtsecondata" ErrorMessage="Please first two textbox should be same"></asp:CompareValidator>-->
           <!--<asp:TextBox runat="server" id="txtCustom" />-->
           <!-- <asp:CustomValidator runat="server" id="cusCustom" controltovalidate="txtdata" onservervalidate="cusCustom_ServerValidate" errormessage="The text must be exactly 8 characters long!" />-->
            <!--<asp:RegularExpressionValidator ID="regexp" ValidationExpression="\d+(\.\d\d)" ControlToValidate="txtdata" ErrorMessage="Please enter non negative number" runat="server"></asp:RegularExpressionValidator>-->
            <asp:ValidationSummary ID="validSummary" DisplayMode="BulletList" ShowSummary="true" HeaderText="Errors:" runat="server" />
            <asp:Button ID="btnsubmit" Text="Click Here" OnClick="ClickHere"  runat="server" />
        </div>
    </form>
</body>
</html>
