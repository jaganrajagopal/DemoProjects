using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class Myusercontrol : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnCombineme(object sender, EventArgs e)
        {
            lbldisplay.Text = txtfirstname.Text + "" + txtlastname.Text;
        }
    }
}