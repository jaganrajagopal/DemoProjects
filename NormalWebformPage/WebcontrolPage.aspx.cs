using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Xsl;

namespace NormalWebformPage
{
    public partial class WebcontrolPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //<Snippet3>
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("Books.xml"));
            //</Snippet3>

            //<Snippet4>
           // XslTransform trans = new XslTransform();
           // trans.Load(Server.MapPath("BookSchemaData.xsl"));
            //</Snippet4>
           
            Xml1.Document = doc;
           // Xml1.Transform = trans;
        }

        protected void OnchangeRadiobutton(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                lbldisplay.Text = "YOu have selected part employee";
            }
            else if (RadioButton2.Checked==true)
            {
                lbldisplay.Text = "YOu have selected Permanent employee";
            }
            else if (RadioButton3.Checked==true)
            {
                lbldisplay.Text = "YOu have selected Not applicable";
            }
        }
    }
}