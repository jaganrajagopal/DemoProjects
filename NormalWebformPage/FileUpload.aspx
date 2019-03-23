<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="NormalWebformPage.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            FileUpload
            <asp:FileUpload ID="fileuploadTag" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnsave" Text="Save" OnClick="FileUploadSave" runat="server" />
        </div>
    </form>
</body>
</html>
