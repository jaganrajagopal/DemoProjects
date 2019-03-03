<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebcontrolPage.aspx.cs" Inherits="NormalWebformPage.WebcontrolPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="PartEmployee" OnCheckedChanged="OnchangeRadiobutton" GroupName="employeetype" AutoPostBack="true" Enabled=""></asp:RadioButton>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="PermantentEmployee" OnCheckedChanged="OnchangeRadiobutton" GroupName="employeetype" AutoPostBack="true"></asp:RadioButton>
            <asp:RadioButton ID="RadioButton3" runat="server" Text="NotApplicable" OnCheckedChanged="OnchangeRadiobutton" GroupName="employeetype"  AutoPostBack="true"></asp:RadioButton>
        </div>
        <div>
            <asp:Wizard ID="Wizard1" runat="server">
                <WizardSteps>
                    <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1"></asp:WizardStep>
                    <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2"></asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
            

        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server"><asp:ListItem Text="Apple" Value="1"></asp:ListItem><asp:ListItem Text="Grapes" Value="2"></asp:ListItem></asp:RadioButtonList>
        <div> <asp:Label ID="lbldisplay" runat="server"></asp:Label>
            <asp:Xml ID="Xml1"  runat="server"></asp:Xml>
            <input id="Submit1" type="submit" value="submit" />
        </div>
    </form>
</body>
</html>
