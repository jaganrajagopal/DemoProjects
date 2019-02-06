using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;


namespace NormalWebformPage
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // MyClassLibrary.Class1 obj = new 
            MyClassLibrary.subClassLibary.Class2 obj = new MyClassLibrary.subClassLibary.Class2();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button clicked");
        }
    }

  
}