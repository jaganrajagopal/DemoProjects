using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class AddOperationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnclick(object sender, EventArgs e)
        {
            WebserviceCalls.MyserviceSoapClient obj = new WebserviceCalls.MyserviceSoapClient();
            int a = int.Parse(txtinput1.Text);
            int b = int.Parse(txtinput2.Text);
           string addOpps= obj.AddOperation(a, b).ToString();
            lbldisplay.Text = addOpps;
        }
    }
}