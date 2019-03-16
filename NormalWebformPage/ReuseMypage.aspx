<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReuseMypage.aspx.cs" Inherits="NormalWebformPage.ReuseMypage" %>
<%@ Register TagPrefix="mylabel" TagName="labeldisplay" Src="~/Myusercontrol.ascx" %> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <mylabel:labeldisplay id="lblmydisplay"  runat="server"></mylabel:labeldisplay>
        </div>

    </form>
</body>
</html>
