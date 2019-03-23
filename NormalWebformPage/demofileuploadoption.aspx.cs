using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class demofileuploadoption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void FileUploadSave(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("~/fileupload");
            fileuploadTag.SaveAs(filepath +"\\" + fileuploadTag.FileName);
            Response.Write("file size:" + fileuploadTag.FileBytes);
            Response.Write("file name:" + fileuploadTag.FileName);
        }

        public void sendingMail()
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("FromMailAddress");
            message.To.Add(new MailAddress("ToMailAddress"));
            message.Subject = "Test";
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = "<h1>Hi Welcome learning center for webmail </h1>";
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("FromMailAddress", "password");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //message.Attachments.Add()
            smtp.Send(message);
        }
    }
}