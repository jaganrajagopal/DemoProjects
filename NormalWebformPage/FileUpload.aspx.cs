using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FileUploadSave(object sender, EventArgs e)
        {
           string filepath= Server.MapPath("~/fileupload");
            fileuploadTag.SaveAs(filepath + fileuploadTag.FileName );
            Response.Write("file size:" + fileuploadTag.FileBytes);
            Response.Write("file name:" + fileuploadTag.FileName);
        }
    }
}